using HardkorowyKodsu.Model;
using HardkorowyKodsu.View;
using Newtonsoft.Json;
using System;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Mime;
using System.Text;
using HardkorowyKodsu.Helpers;

namespace HardkorowyKodsu.ViewModel
{
    internal class TableDetailsViewModel : BaseWinFormsViewModel
    {
        public override void ConnectEvents(IMainFormsView mainView)
        {
            mainView.ConnectTableDetailsGridToVm(this);
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
                { "tableId", tableNameModel.Id.ToString() },
                { "tableType", tableNameModel.Type.ToString() }
            };

            var queryString = string.Join("&", parameters.Select(p => $"{WebUtility.UrlEncode(p.Key)}={WebUtility.UrlEncode(p.Value)}"));
            var requestUri = new Uri($"table?{queryString}", UriKind.Relative);

            var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var responseStatusCode = HttpStatusCode.OK;

            try
            {
                var response = await client.SendAsync(requestMessage);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return response.StatusCode;
                }
                var data = await response.Content.ReadAsStringAsync();
                var tableDetails = JsonConvert.DeserializeObject<TableDetailsDataModel>(data);
                if (tableDetails == null)
                {
                    return HttpStatusCode.InternalServerError;
                }
                SetData(new List<TableDetailsDataModel>() { tableDetails });
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