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

        protected void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            VerifyF(e.PropertyName);
            
        }
        internal bool VerifyF(string prop)
        {
            if (Context?.Form == null) return true;
            var elem = VisualTreeHelper.Instance.FindElementByName(Context.Form, prop);
            var err = VisualTreeHelper.Instance.FindElementByName(Context.Form, "errors");
            if (elem == null || err == null) return true;
            if (!Validate(prop, out var errors))
            {
                (err as TextBlock).Text = string.Join("\r\n", errors);
                return false;
            }
            else
            {
                (err as TextBlock).Text = null;
                return true;
            }
        }
    }
}
