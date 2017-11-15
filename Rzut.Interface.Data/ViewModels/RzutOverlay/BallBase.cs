using EmptyKeys.UserInterface.Mvvm;
using Microsoft.Xna.Framework;
using Rzut.Interface.Data.ViewModels.DataEntry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tainicom.Aether.Physics2D.Dynamics;

namespace Rzut.Interface.Data.ViewModels.RzutOverlay
{
    public abstract class BallBase : ViewModelBase
    {
        public virtual Body Body { get; set; }
        public virtual EntityViewModel Data { get; set; }
        protected Vector2 _startPosition;
        public virtual Vector2 StartPosition { get => _startPosition; set { if (_startPosition != value) SetProperty(ref _startPosition, value); } }

        public string LinearVelocity => $"Vx: {Body.LinearVelocity.X}\nVy: {Body.LinearVelocity.Y}";
        public string AngularVelocity => Body.AngularVelocity.ToString("0.00");
        public string Distance => (Body.Position - StartPosition).ToString();


        public virtual void Update(GameTime time)
        {
            RaisePropertyChanged(nameof(LinearVelocity));
            RaisePropertyChanged(nameof(AngularVelocity));
            RaisePropertyChanged(nameof(Distance));
        }
    }
}
