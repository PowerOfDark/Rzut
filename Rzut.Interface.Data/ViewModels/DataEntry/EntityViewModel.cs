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

        private float _startY;
        public float StartY { get => _startY; set => SetProperty(ref _startY, value); }

        private float _startX;
        public float StartX { get => _startX; set => SetProperty(ref _startX, value); }

        private float _startAngle;
        public float StartAngle { get => _startAngle; set => SetProperty(ref _startAngle, value); }

        private float _velocity;
        public float Velocity { get => _velocity; set => SetProperty(ref _velocity, value); }

        private float _friction;//UNUSED!1!!!!111 TODO make actual friction
        public float Friction { get => _friction; set => SetProperty(ref _friction, value); }

        private float _airResistance;//Unused
        public float AirResistance { get => _airResistance; set => SetProperty(ref _airResistance, value); }

        private float _angularDrag;
        public float AngularDrag { get => _angularDrag; set => SetProperty(ref _angularDrag, value); }


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
                case nameof(StartY):
                    Validation.ValidateRange(this, t => t.StartY, 0.01f, 10000.0f, errors, "float");
                    break;
                case nameof(StartX):
                    Validation.ValidateRange(this, t => t.StartX, int.MinValue, int.MaxValue, errors, "float");
                    break;
                case nameof(StartAngle):
                    Validation.ValidateRange(this, t => t.StartAngle, 0, 360, errors, "float");
                    break;
                case nameof(Velocity):
                    Validation.ValidateRange(this, t => t.Velocity, 0, int.MaxValue, errors, "float");
                    break;
                case nameof(Friction):
                    Validation.ValidateRange(this, t => t.Friction, 0, int.MaxValue, errors, "float");
                    break;
                case nameof(AirResistance):
                    Validation.ValidateRange(this, t => t.AirResistance, 0, 1, errors, "float");
                    break;
                case nameof(AngularDrag):
                    Validation.ValidateRange(this, t => t.AirResistance, 0, 1, errors, "float");
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
