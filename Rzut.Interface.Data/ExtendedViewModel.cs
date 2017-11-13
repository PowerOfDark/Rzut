using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using EmptyKeys.UserInterface.Media;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface.Data;
using Rzut.Interface.Data.UI;

namespace Rzut.Interface.Data
{
    public abstract class ExtendedViewModel : ViewModelBase
    {
        public Guid Identifier { get; private set; }
        public string IdentifierString => Identifier.ToString();
        public IViewModelCollection Context { get; set; }


        public abstract bool Validate(string property, out ICollection<string> errors);

        protected ExtendedViewModel(IViewModelCollection context)
        {
            Identifier = Guid.NewGuid();

            Context = context ?? this as IViewModelCollection;
            this.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Context?.Form == null) return;
            var elem = VisualTreeHelper.Instance.FindElementByName(Context.Form, e.PropertyName);
            var err = VisualTreeHelper.Instance.FindElementByName(Context.Form, "errors");
            if (elem == null || err == null) return;
            if (!Validate(e.PropertyName, out var errors))
            {
                /*var t = elem.ToolTip as ToolTip;
                if(t == null)
                {
                    elem.ToolTip = t = new ToolTip();
                    t.Placement = EmptyKeys.UserInterface.Controls.Primitives.PlacementMode.Top;

                    t.IsHitTestVisible = true;
                    t.TabIndex = -1;
                    //t.PlacementTarget = elem;
                    //t.Parent = elem;
                }
                t.IsOpen = true;
                t.IsEnabled = true;*/

                (err as TextBlock).Text = string.Join("\r\n", errors);

            }
            else
            {
                /*if(elem.ToolTip is ToolTip t)
                {
                    t.IsOpen = false;
                    t.IsEnabled = false;
                    t.Content = null;
                    //t.IsEnabled = false;
                    //t.Content = null;
                }*/
                (err as TextBlock).Text = null;
                //elem.ToolTip = null;

            }
        }
    }
}
