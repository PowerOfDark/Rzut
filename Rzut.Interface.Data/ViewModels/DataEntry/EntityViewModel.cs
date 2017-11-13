using EmptyKeys.UserInterface.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Xamarin.Forms.Internals;
using EmptyKeys.UserInterface.Media;
using Microsoft.Xna.Framework;
using Rzut.Interface.Data.i18n;
using Rzut.Interface.Data.i18n.Resources;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface;

namespace Rzut.Interface.Data.ViewModels.DataEntry
{
    [Preserve(AllMembers = true)]
    public class EntityViewModel : ExtendedViewModel
    {
        public delegate void OnTabClicked(EntityViewModel entity);
        public event OnTabClicked TabClicked;
        public ICommand TabClickDown { get; set; }

        /*public int Index { get; set; }
        public string IndexString => Index.ToString();*/

        private bool _isActive;
        public bool IsActive { get => _isActive; set { SetProperty(ref _isActive, value); this.RaisePropertyChanged("IsSelectable"); } }
        public bool IsSelectable => !_isActive;

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

        private float _mass;
        public float Mass { get => _mass; set => SetProperty(ref _mass, value); }

        public EntityViewModel(IViewModelCollection context) : base(context)
        {
            TabClickDown = new RelayCommand(t => TabClicked?.Invoke(this));
            
        }

        public override bool Validate(string property, out ICollection<string> errors)
        {
            errors = new List<string>();
            switch(property)
            {
                case nameof(Radius):
                    Validation.ValidateRange(this, t => t.Radius, 0.01f, 100f, errors, "float");
                    break;
                case nameof(Mass):
                    Validation.ValidateRange(this, t => t.Mass, 0.01f, int.MaxValue, errors, "float");
                    break;
                default:
                    break;
            }
            return errors.Count == 0;
        }



        /*private readonly Dictionary<string, ICollection<string>> _validationErrors = 
            new Dictionary<string, ICollection<string>>();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public bool HasErrors => _validationErrors.Any();
        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName)
                || !_validationErrors.ContainsKey(propertyName))
                return null;

            return _validationErrors[propertyName];
        }*/
    }
}
