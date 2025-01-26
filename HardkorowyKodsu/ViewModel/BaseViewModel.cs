using HardkorowyKodsu.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HardkorowyKodsu.ViewModel
{
    public abstract class BaseWinFormsViewModel : ICommand
    {
        //public event EventHandler<DataTable> GetDataCallback;

        protected BindingSource BindingSource { get; set; }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public abstract void Execute(object? parameter);

        public void BindSource(BindingSource bindingSource)
        {
            BindingSource = bindingSource;
        }
        public abstract void ConnectEvents(IMainFormsView mainView);
        protected void SetData(IEnumerable<object> data)
        {
            foreach(var item in data)
            {
                BindingSource.Add(item);
            }
        }

    }
}
