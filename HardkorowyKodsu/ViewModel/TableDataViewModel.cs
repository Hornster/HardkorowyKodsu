using HardkorowyKodsu.View;

namespace HardkorowyKodsu.ViewModel
{
    internal class TableDataViewModel : BaseWinFormsViewModel
    {
        public override void ConnectEvents(IMainFormsView mainView)
        {
            mainView.ConnectTableDataGridToVm(this);
        }

        public override void Execute(object? parameter)
        {
            throw new System.NotImplementedException();
        }
    }
}