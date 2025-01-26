using HardkorowyKodsu.Helpers;
using HardkorowyKodsu.Model;
using HardkorowyKodsu.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.ViewModel
{
    public class ColumnDetailsViewModel : BaseWinFormsViewModel
    {
        public override void ConnectEvents(IMainFormsView mainView)
        {
            //mainView.ConnectColumnDetailsGridToVm(this);
        }

        public override void Execute(object? parameter)
        {
            
            OnGetDataSuccessfulCallbackAsync((ColumnDetailsInfoObj)parameter);
        }

        protected async Task<HttpStatusCode> OnGetDataSuccessfulCallbackAsync(ColumnDetailsInfoObj tableNameModel)
        {
            var responseStatusCode = HttpStatusCode.OK;
            var client = Program.HttpClient;
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("table/column");
            request.Method = HttpMethod.Get;
            request.Options.TryAdd("columnId", tableNameModel.ColumnId);
            request.Options.TryAdd("tableId", tableNameModel.TableId);

            try
            {
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return response.StatusCode;
                }
                var data = await response.Content.ReadAsStringAsync();
                var columnDetails = JsonConvert.DeserializeObject<TableColumnDetailsModel>(data);
                if (columnDetails == null)
                {
                    return HttpStatusCode.InternalServerError;
                }
                SetData(new List<TableColumnDetailsModel>() { columnDetails });
            }
            catch (HttpRequestException ex)
            {
                //This should be fine. If it is not, something went wron on serverside.
                ExceptionHelper.HandleException(ex);
            }
            return responseStatusCode;

        }
    }
}
