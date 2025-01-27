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
        ICommand _getTableDetailsCommand;
        ICommand _getTableColumnsCommand;
        public MainView(AppBackbones appBackbones)
        {
            InitializeComponent();
            appBackbones.Initialize(this);
            this.TableNamesGrid.DataSource = _tableNamesBindingSource;
            this.TableDetailsGrid.DataSource = _tableDataBindingSource;
            this.TableColumnsGrid.DataSource = _tableColumnsBindingSource;
        }

        public void ConnectTableColumnsGridToVm(BaseWinFormsViewModel vm)
        {
            vm.BindSource(_tableColumnsBindingSource);
            _getTableColumnsCommand = vm;
        }
        public void ConnectTableDetailsGridToVm(BaseWinFormsViewModel vm)
        {
            vm.BindSource(_tableDataBindingSource);
            _getTableDetailsCommand = vm;
        }

        public void ConnectTableNamesGridToVm(BaseWinFormsViewModel vm)
        {
            vm.BindSource(_tableNamesBindingSource);
            _getTableNamesCommand = vm;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            _getTableNamesCommand.Execute(null);
        }

        private void TableNamesGrid_SelectionChanged(object sender, EventArgs e)
        {
            var mySender = sender as DataGridView;

            if (mySender.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedRow = mySender.SelectedRows[0];
            CallTableDataRetrievalCommands(selectedRow);
        }

        private void TableNamesGridRefreshButton_Click(object sender, EventArgs e)
        {
            var grid = this.TableNamesGrid;
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.Selected = false;
            }
            foreach (DataGridViewCell cell in grid.SelectedCells)
            {
                cell.Selected = false;
            }
            _getTableNamesCommand.Execute(null);
        }

        private void TableNamesGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            var mySender = sender as DataGridView;
            
            if (mySender.SelectedCells.Count == 0)
            {
                return;
            }

            var selectedCell = mySender.SelectedCells[0];
            var selectedRow = mySender.Rows[selectedCell.RowIndex];
            CallTableDataRetrievalCommands(selectedRow);
        }
        private void CallTableDataRetrievalCommands(DataGridViewRow selectedRow)
        {
            var selectedItem = selectedRow.DataBoundItem;

            _getTableDetailsCommand.Execute(selectedItem);
            _getTableColumnsCommand.Execute(selectedItem);
        }
    }
}
