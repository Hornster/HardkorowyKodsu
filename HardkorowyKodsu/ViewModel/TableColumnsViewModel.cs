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
using System.Windows.Input;

namespace HardkorowyKodsu.ViewModel
{
    public class TableColumnsViewModel : BaseWinFormsViewModel
    {
        public override void ConnectEvents(IMainFormsView mainView)
        {
            mainView.ConnectTableColumnsGridToVm(this);
        }


        public override void Execute(object? parameter)
        {
            OnGetDataSuccessfulCallbackAsync((TableNameModel)parameter);
        }
        protected async Task<HttpStatusCode> OnGetDataSuccessfulCallbackAsync(TableNameModel tableNameModel)
        {
            var client = Program.HttpClient;

            var parameters = new Dictionary<string, string>
            {
                { "tableId", tableNameModel.Id.ToString() }
            };

            var queryString = string.Join("&", parameters.Select(p => $"{WebUtility.UrlEncode(p.Key)}={WebUtility.UrlEncode(p.Value)}"));
            var requestUri = new Uri($"table/columns?{queryString}", UriKind.Relative);
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);

            var responseStatusCode = HttpStatusCode.OK;

            try
            {
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return response.StatusCode;
                }

                var data = await response.Content.ReadAsStringAsync();
                var tableDetails = JsonConvert.DeserializeObject<TableColumnsDataModel>(data);

                if (tableDetails == null)
                {
                    return HttpStatusCode.InternalServerError;
                }
                SetData(tableDetails.Columns);
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
