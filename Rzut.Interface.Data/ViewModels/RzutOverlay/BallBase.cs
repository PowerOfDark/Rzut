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
        public string LinearVelocityDetails => string.Format(Strings.Overlay_LinearVelocityDetails, Body.LinearVelocity.X, Body.LinearVelocity.Y);
        public string AngularVelocity => Body.AngularVelocity.ToString("0.00");
        public string Distance => (Body.Position - StartPosition).ToString();

        protected Vector2 _lastVelocity;
        protected int _updateCounter = 0;

        public virtual void Update(GameTime time)
        {
            RaisePropertyChanged(nameof(LinearVelocity));
            RaisePropertyChanged(nameof(LinearVelocityDetails));
        }
    }
}
