using HardkorowyKodsu.View;
using HardkorowyKodsu.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu
{
    /// <summary>
    /// Contains logic responsible for processing the data, reacting to user input and communication with server.
    /// </summary>
    public class AppBackbones
    {
        private List<BaseWinFormsViewModel> _vms = new List<BaseWinFormsViewModel>();
        public AppBackbones() 
        { 
            _vms.Add(new TableDetailsViewModel());
            _vms.Add(new DbStructureViewModel());
            _vms.Add(new TableColumnsViewModel());
        }

        public void Initialize(IMainFormsView mainView)
        {
            foreach (var vm in _vms)
            {
                vm.ConnectEvents(mainView);
            }
        }
    }
}
