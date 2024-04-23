using Falzoni.Presentation.Administrator.Clients.Base;
using Falzoni.Presentation.Administrator.Clients.Interfaces.Register;
using Falzoni.Presentation.Administrator.Models.Common;
using Falzoni.Presentation.Administrator.Models.Register;
using Falzoni.Presentation.Administrator.Models.Tables.Register;
using Falzoni.Utils.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Falzoni.Presentation.Administrator.Clients.Register
{
    public class RoleClient : BaseClient<RoleModel, RoleTableModel>, IRoleClient
    {
        public RoleClient() :base() { }

        public List<string> GetAllNames()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = UrlConfigurationHelper.RoleGetAllNames;

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var roles = response.Content.ReadAsAsync<List<string>>().Result;

                    return roles;
                }
                else
                {
                    StatusCodeModel statusCode = response.Content.ReadAsAsync<StatusCodeModel>().Result;

                    throw new ApplicationException(statusCode.Message);
                }
            }
        }
    }
}