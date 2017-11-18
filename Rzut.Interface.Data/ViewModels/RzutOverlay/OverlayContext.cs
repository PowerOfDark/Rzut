using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rzut.Interface.Data.ViewModels.RzutOverlay
{
    public interface IOverlayContext<T> where T: BallBase
    {
        ObservableCollection<T> Balls { get; set; }
        ICommand ExitCommand { get; set; }
        string BackDisplay { get; }
    }
}
