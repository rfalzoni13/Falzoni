using Falzoni.Presentation.Administrator.Clients.Base;
using Falzoni.Presentation.Administrator.Clients.Interfaces.Registration;
using Falzoni.Presentation.Administrator.Models.Registration;
using Falzoni.Presentation.Administrator.Models.Tables.Registration;
using Falzoni.Utils.Helpers;
using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Linq;
using Falzoni.Presentation.Administrator.Models.Common;

namespace Falzoni.Presentation.Administrator.Clients.Registration
{
    public class CustomerClient : BaseClient<CustomerModel, CustomerTableModel>, ICustomerClient
    {
        public CustomerClient() :base() { }

        public override async Task<CustomerTableModel> GetTableAsync(string url)
        {
            var table = new CustomerTableModel();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var customers = await response.Content.ReadAsAsync<ICollection<CustomerModel>>();

                        foreach (var customer in customers)
                        {
                            table.data.Add(new CustomerListTableModel()
                            {
                                Id = customer.Id,
                                Name = customer.Name,
                                Document = customer.Document,
                                Email = customer.Email,
                                Gender = customer.Gender,
                                Created = customer.Created,
                                Modified = customer.Modified
                            });
                        }

                        table.recordsFiltered = table.data.Count();
                        table.recordsTotal = table.data.Count();
                    }
                    else
                    {
                        if(response.StatusCode != System.Net.HttpStatusCode.NotFound)
                        {
                            StatusCodeModel statusCode = response.Content.ReadAsAsync<StatusCodeModel>().Result;

                            table.error = statusCode.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                table.error = ExceptionHelper.CatchMessageFromException(ex);
            }

            return await Task.FromResult(table);
        }
    }
}