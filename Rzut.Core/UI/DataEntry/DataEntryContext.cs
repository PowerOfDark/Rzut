using EmptyKeys.UserInterface.Mvvm;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Rzut.Core.UI.DataEntry
{
    [Preserve(AllMembers = true)]
    public class DataEntryContext : ViewModelBase
    {
        private ObservableCollection<EntityViewModel> _entities;
        public ObservableCollection<EntityViewModel> Entities { get => _entities; set => SetProperty(ref _entities, value); }
        public string RadiusDisplay => i18n.Resources.Strings.EntityViewModel_Radius;


        public DataEntryContext()
        {
            Entities = new ObservableCollection<EntityViewModel>();
            Entities.Add(new EntityViewModel() { Index = 0, Color = Color.Red, Radius = 1.5f });
            Entities.Add(new EntityViewModel() { Index = 2, Color = Color.Black, Radius = 20f });
        }
    }
}
