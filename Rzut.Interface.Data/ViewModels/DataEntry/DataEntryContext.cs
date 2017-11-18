using EmptyKeys.UserInterface.Mvvm;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;
using Rzut.Interface.Data.i18n.Resources;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Controls;
using System.Diagnostics;
using static Rzut.Interface.Data.ViewModels.DataEntry.EntityViewModel;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Media;
using Rzut.Interface.Data.i18n;
using tainicom.Aether.Physics2D;

namespace Rzut.Interface.Data.ViewModels.DataEntry
{
    [Preserve(AllMembers = true)]
    public class DataEntryContext : ExtendedViewModel, IViewModelCollection
    {
        //private static int LastIndex = 0;
        public event OnTabClicked TabClicked;

        public delegate void OnSimulationStarted(DataEntryContext context);
        public event OnSimulationStarted SimulationStarted;
        public ICommand StartSimulation { get; set; }

        private ObservableCollection<EntityViewModel> _entities;
        public ObservableCollection<EntityViewModel> Entities { get => _entities; set => SetProperty(ref _entities, value); }

        public ObservableCollection<Color> AvailableColors { get; set; }
        public ObservableCollection<SolidColorBrush> AvailableBrushes { get; set; }

        private EntityViewModel _activeEntity;
        public EntityViewModel ActiveEntity { get => _activeEntity; set => SetProperty(ref _activeEntity, value); }

        public string RadiusDisplay => Strings.EntityViewModel_Radius;
        public string TabDisplay => Strings.Tab_Ball;
        public string MassDisplay => Strings.EntityViewModel_Mass;
        public string StartXDisplay => Strings.EntityViewModel_StartX;
        public string StartYDisplay => Strings.EntityViewModel_StartY;
        public string StartAngleDisplay => Strings.EntityViewModel_StartAngle;
        public string VelocityDisplay => Strings.EntityViewModel_Velocity;
        public string FrictionDisplay => Strings.EntityViewModel_Friction;
        public string AirResistanceDisplay => Strings.EntityViewModel_AirResistance;
        public string AngularDragDisplay => Strings.EntityViewModel_AngularDrag;
        public string GravitationalAccelerationDisplay => Strings.EntityViewModel_GravitationalAcceleration;
        public string RestitutionDisplay => Strings.EntityViewModel_Restitution;
        public string AngularVelocityDisplay => Strings.EntityViewModel_AngularVelocity;
        public string ThrowParametersDisplay => Strings.Header_ThrowParameters;
        public string CoefficientsDisplay => Strings.Header_Coefficients;
        public string WorldDisplay => Strings.Header_World;
        public string CheckboxEnableCollisionsDisplay => Strings.Checkbox_EnableCollisions;
        public string ButtonAddDisplay => Strings.Button_Add;
        public string ButtonRemoveDisplay => Strings.Button_Remove;
        public string UnitRatioDisplay => Strings.Config_UnitRatio;

        private bool _enableCollision;
        public bool EnableCollision { get => _enableCollision; set => SetProperty(ref _enableCollision, value); }

        private float _unitRatio;
        public float UnitRatio { get => _unitRatio; set => SetProperty(ref _unitRatio, value); }


        public UIElement Form { get; set; }

        public void SetActive(EntityViewModel entity)
        {
            if (ActiveEntity != null)
                ActiveEntity.IsActive = false;
            ActiveEntity = entity;
            ActiveEntity.IsActive = true;
        }

        public void AddTab(EntityViewModel model)
        {
            model.TabClicked -= DataEntryContext_TabClicked;
            model.TabClicked += DataEntryContext_TabClicked;
            //model.Index = LastIndex++;
            model.Context = this;
            Entities.Add(model);
            var b = ToBrush(model.Color);
            var i = AvailableBrushes.IndexOf(t => t.Color.PackedValue == b.Color.PackedValue);
            AvailableBrushes.RemoveAt(i);
        }

        public static SolidColorBrush ToBrush(Color color)
        {
            return new SolidColorBrush(new ColorW(color.R, color.G, color.B));
        }

        public void RemoveTab(EntityViewModel model)
        {
            var brush = ToBrush(model.Color);
            if (Entities.Count == 1) return;
            model.TabClicked -= DataEntryContext_TabClicked;
            
            model.Context = null;
            Entities.Remove(model);
            if (model.IsActive)
            {
                SetActive(Entities.First());
            }
            AvailableBrushes.Add(brush);
        }

        public DataEntryContext(UIElement form) : base(null)
        {
            AvailableColors = new ObservableCollection<Color>()
            {
                Color.Red, Color.Green, Color.Purple, Color.Yellow, Color.CornflowerBlue, Color.Cyan, Color.DarkGoldenrod, Color.LightPink, Color.Lavender, Color.IndianRed
            };
            AvailableBrushes = new ObservableCollection<SolidColorBrush>(AvailableColors.Select(ToBrush));

            Form = form;
            Entities = new ObservableCollection<EntityViewModel>();
            AddTab(new EntityViewModel(this)
            {
                Color = Color.Red,
                Radius = 1.5f,
                Mass = 2f,
                StartY = 60f,
                StartX = 40f,
                Velocity = 100f,
                StartAngle = 270f,
                //Friction = 50f,
                AirResistance = 0.10f,
                AngularDrag = 0.10f,
                GravitationalAcceleration = 10,
                AngularVelocity = 50,
            });

            AddTab(new EntityViewModel(this)
            {
                Color = Color.Green,
                Radius = 2f,
                Mass = 3f,
                StartY = 60f,
                StartX = 0f,
                Velocity = 100f,
                StartAngle = 90f,
                //Friction = 50f,
                AirResistance = 0.10f,
                AngularDrag = 0.10f,
                GravitationalAcceleration = 10,
                AngularVelocity = 1
            });

            SetActive(Entities.First());

            UnitRatio = ConvertUnits.Ratio;

            StartSimulation = new RelayCommand(t => SimulationStarted?.Invoke(this));

        }



        [Obsolete("only for design mode", true)]
        public DataEntryContext() : this(null)
        {

        }

        private void DataEntryContext_TabClicked(EntityViewModel entity)
        {
            TabClicked?.Invoke(entity);
        }

        public override bool Validate(string property, out ICollection<string> errors)
        {
            errors = new List<string>();
            switch (property)
            {
                case nameof(UnitRatio):
                    Validation.ValidateRange(this, t => t.UnitRatio, 1f, 1000f, errors, "float");
                    break;
                default:
                    return true;
            }
            return errors.Count == 0;
        }
    }
}
