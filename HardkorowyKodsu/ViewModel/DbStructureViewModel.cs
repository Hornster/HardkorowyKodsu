using HardkorowyKodsu.Helpers;
using HardkorowyKodsu.Model;
using HardkorowyKodsu.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HardkorowyKodsu.ViewModel
{
    public class DbStructureViewModel : BaseWinFormsViewModel
    {
        public override void ConnectEvents(IMainFormsView mainView)
        {
            mainView.ConnectTableNamesGridToVm(this);
        }

        public override void Execute(object? parameter)
        {
            //We do not expect any arguments here. Just proceed with data retrieval.
            GetData();
        }

        public void GetData()
        {
            OnGetDataSuccessfulCallbackAsync();
        }

        protected async Task<HttpStatusCode> OnGetDataSuccessfulCallbackAsync()
        {
            var client = Program.HttpClient;
            var responseStatusCode = HttpStatusCode.OK;

            try
            {
                var response = await client.GetAsync("dbstructure");
                response.EnsureSuccessStatusCode();


                var data = await response.Content.ReadAsStringAsync();

                var dbStructure = JsonConvert.DeserializeObject<DbStructureModel>(data);

                if (dbStructure == null)
                {
                    //This should be fine. If it is not, something went wron on serverside.
                    return HttpStatusCode.InternalServerError;
                }

                SetData(dbStructure.Tables);

                responseStatusCode = response.StatusCode;
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
