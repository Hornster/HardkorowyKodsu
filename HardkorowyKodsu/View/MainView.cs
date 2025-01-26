using HardkorowyKodsu.View;
using HardkorowyKodsu.ViewModel;
using System.Windows.Input;

namespace HardkorowyKodsu
{
    public partial class MainView : Form, IMainFormsView
    {
        private BindingSource _tableNamesBindingSource = new BindingSource();
        private BindingSource _tableDataBindingSource = new BindingSource();
        private BindingSource _tableColumnsBindingSource = new BindingSource();

        ICommand _getTableNamesCommand;
        public MainView(AppBackbones appBackbones)
        {
            InitializeComponent();
            appBackbones.Initialize(this);
            this.TableNamesGrid.DataSource = _tableNamesBindingSource;
            this.TableDetailsGrid.DataSource = _tableDataBindingSource;
        }

        public void ConnectTableDataGridToVm(BaseWinFormsViewModel baseVm)
        {
            baseVm.BindSource(_tableDataBindingSource);
        }

        public void ConnectTableNamesGridToVm(BaseWinFormsViewModel baseVm)
        {
            baseVm.BindSource(_tableNamesBindingSource);
            _getTableNamesCommand = baseVm;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            _getTableNamesCommand.Execute(null);
        }

        private void TableNamesGrid_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
