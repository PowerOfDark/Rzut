using EmptyKeys.UserInterface.Mvvm;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Rzut.Core.i18n;
using Xamarin.Forms.Internals;
using EmptyKeys.UserInterface.Media;

namespace Rzut.Core.UI.DataEntry
{
    [Preserve(AllMembers = true)]
    public class EntityViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        public int Index { get; set; }

        private Color _color;
        public Color Color
        {
            get => _color;
            set
            {
                SetProperty(ref _color, value);
                ColorBrush = new SolidColorBrush(new ColorW(value.R, value.G, value.B));
            }
        }
        private Brush _colorBrush;
        public Brush ColorBrush { get => _colorBrush; set => SetProperty(ref _colorBrush, value); }

        private float _radius;
        public float Radius { get => _radius; set => SetProperty(ref _radius, value); }

        public EntityViewModel()
        {
            this.PropertyChanged += EntityViewModel_PropertyChanged;
        }

        private void EntityViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!Validate(e.PropertyName, out var errors))
            {
                _validationErrors[e.PropertyName] = errors;
            }
            else if (_validationErrors.ContainsKey(e.PropertyName))
            {
                _validationErrors.Remove(e.PropertyName);

            }
            else return;
            ErrorsChanged?.Invoke(sender, new DataErrorsChangedEventArgs(e.PropertyName));
        }

        public bool Validate(string property, out ICollection<string> errors)
        {
            errors = new List<string>();
            switch(property)
            {
                case nameof(Radius):
                    Validation.ValidateRange(this, t => t.Radius, 0.01f, 100f, errors, "float");
                    break;
                default:
                    break;
            }
            return errors.Count == 0;
        }



        private readonly Dictionary<string, ICollection<string>> _validationErrors = 
            new Dictionary<string, ICollection<string>>();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public bool HasErrors => _validationErrors.Any();
        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName)
                || !_validationErrors.ContainsKey(propertyName))
                return null;

            return _validationErrors[propertyName];
        }
    }
}
