using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rzut.Interface.Data.UI
{
    public class FloatProxyConverter : IValueConverter
    {
        private string user_string = null;

        public FloatProxyConverter() { }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (user_string != null)
            {
                return user_string;
            }

            float number = (float)value;
            return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0}", number);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string s_value = value.ToString();
            float result = 0;

            if (!float.TryParse(s_value, System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.CurrentCulture, out result))
                return null;

            user_string = s_value;

            return result;
        }

        public static DependencyProperty GetUpdateOnLostFocus(DependencyObject obj)
        {
            return (DependencyProperty)obj.GetValue(UpdateOnLostFocusProperty);
        }

        public static void SetUpdateOnLostFocus(DependencyObject obj, DependencyProperty value)
        {
            obj.SetValue(UpdateOnLostFocusProperty, value);
            
        }

        public static readonly DependencyProperty UpdateOnLostFocusProperty =
            DependencyProperty.RegisterAttached("UpdateOnLostFocus", typeof(DependencyProperty),
            typeof(FloatProxyConverter), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None, UpdateOnLostFocusChanged));

        private static void UpdateOnLostFocusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (UIElement)d;

            if (e.NewValue != null)
            {
                element.LostFocus += new RoutedEventHandler(element_LostFocus);
            }

            if (e.OldValue != null)
            {
                element.LostFocus -= new RoutedEventHandler(element_LostFocus);
            }
        }

        static void element_LostFocus(object sender, RoutedEventArgs e)
        {
            var element = (UIElement)sender;

            var b = BindingOperations.GetAllBindings(element);

            BindingExpression bindingExpression = b.FirstOrDefault(t => t.TargetProperty == UpdateOnLostFocusProperty);//element.GetBindingExpression(GetUpdateOnLostFocus(element));
            Binding parentBinding = bindingExpression.ParentBinding;
            var converter = parentBinding.Converter as FloatProxyConverter;
            if (converter != null)
            {
                converter.user_string = null;
                bindingExpression.UpdateTarget();
            }
        }
    }
}
