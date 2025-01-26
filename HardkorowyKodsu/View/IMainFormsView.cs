using HardkorowyKodsu.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.View
{
    public interface IMainFormsView
    {
        void ConnectTableNamesGridToVm(BaseWinFormsViewModel baseVm);
        void ConnectTableDataGridToVm(BaseWinFormsViewModel baseVm);
        
    }
}
