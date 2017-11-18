using EmptyKeys.UserInterface.Mvvm;
using Microsoft.Xna.Framework;
using Rzut.Interface.Data.i18n.Resources;
using Rzut.Interface.Data.ViewModels.DataEntry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tainicom.Aether.Physics2D.Dynamics;
using Xamarin.Forms.Internals;

namespace Rzut.Interface.Data.ViewModels.RzutOverlay
{
    [Preserve(AllMembers = true)]
    public abstract class BallBase : ViewModelBase
    {
        public virtual Body Body { get; set; }
        public virtual EntityViewModel Data { get; set; }
        protected Vector2 _startPosition;
        public virtual Vector2 StartPosition { get => _startPosition; set { if (_startPosition != value) SetProperty(ref _startPosition, value); } }

        public string LinearVelocityDisplay => Strings.Body_LinearVelocity;
        public string LinearVelocity => string.Format(Strings.Overlay_LinearVelocity, Body.LinearVelocity.Length());
        public string LinearVelocityDetails => string.Format(Strings.Overlay_LinearVelocityDetails, Body.LinearVelocity.X, -Body.LinearVelocity.Y);

        public string AngularVelocityDisplay => Strings.Body_AngularVelocity;
        public string AngularVelocity => string.Format(Strings.Overlay_AngularVelocity, Body.AngularVelocity);

        public string Distance => (Body.Position - StartPosition).ToString();

        public string PositionDisplay => Strings.Body_Position;
        public string Position => string.Format(Strings.Overlay_Position, Body.Position.X, -Body.Position.Y);

        public string RangeDisplay => Strings.Body_Range;
        protected float _rangeValue;
        public string Range => string.Format(Strings.Overlay_Range, _rangeValue);
        
        protected Vector2 _lastVelocity;
        protected int _updateCounter = 0;

        public virtual void Update(GameTime time)
        {
            _rangeValue = Math.Max(_rangeValue, Math.Abs(StartPosition.X - Body.Position.X));

            RaisePropertyChanged(nameof(LinearVelocity));
            RaisePropertyChanged(nameof(LinearVelocityDetails));
            RaisePropertyChanged(nameof(Position));
            RaisePropertyChanged(nameof(AngularVelocity));
            RaisePropertyChanged(nameof(Range));
        }
    }
}
