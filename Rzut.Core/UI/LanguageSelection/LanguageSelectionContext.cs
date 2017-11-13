using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Mvvm;
using EmptyKeys.UserInterface.Shapes;
using Rzut.Core.i18n;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Rzut.Core.UI
{
    [Preserve(AllMembers = true)]
    public class LanguageSelectionContext : ViewModelBase
    {

        public string Title => i18n.Resources.Strings.Header_Title;
        public string Action => i18n.Resources.Strings.Header_ChooseLanguage;
        public string Apply => i18n.Resources.Strings.Button_Apply;

        public LanguageSelectionContext()
        {

        }

        public void Update()
        {
            this.RaisePropertyChanged();
            this.RaisePropertyChanged("Title");
            this.RaisePropertyChanged("Action");
            this.RaisePropertyChanged("Apply");
        }
    }
}
