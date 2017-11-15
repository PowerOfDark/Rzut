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

        private EntityViewModel _activeEntity;
        public EntityViewModel ActiveEntity { get => _activeEntity; set => SetProperty(ref _activeEntity, value); }

        public string RadiusDisplay => Strings.EntityViewModel_Radius;
        public string TabDisplay => Strings.Tab_Ball;
        public string MassDisplay => Strings.EntityViewModel_Mass;
        public string HeightDisplay => Strings.EntityViewModel_Height;

        public UIElement Form { get; set; }

        public void SetActive(EntityViewModel entity)
        {
            if(ActiveEntity != null)
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
        }

        public DataEntryContext(UIElement form) : base(null)
        {
            Form = form;
            Entities = new ObservableCollection<EntityViewModel>();
            AddTab(new EntityViewModel(this) { Color = Color.Red, Radius = 1.5f, Mass= 2f,  Height = 50f });
            AddTab(new EntityViewModel(this) { Color = Color.Green, Radius = 4f, Mass= 3f , Height = 3f});

            SetActive(Entities.First());

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
            switch(property)
            {

                default:
                    return true;
            }
        }
    }
}
