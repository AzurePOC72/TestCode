using APIClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIClient
{
    public partial class ApiClient
    {
        public async Task<List<Bank>> GetBanks()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "api/Bank"));
            return await GetAsync<List<Bank>>(requestUrl);
        }

        public async Task<Bank> GetBanks(int Id)
        {
            string queryString = $"/{Id}";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"api/Bank{queryString}"));
            return await GetAsync<Bank>(requestUrl);
        }

        public async Task<Message<Bank>> SaveBank(Bank model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "api/Bank"));
            return await PostAsync<Bank>(requestUrl, model);
        }

        public async Task<HttpResponseMessage> UpdateBank(int Id, Bank model)
        {
            string queryString = $"/{Id}";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"api/Bank{queryString}"));
            return await PutAsync<Bank>(requestUrl, model);
        }
        
        public async Task<HttpResponseMessage> DeleteBank(int Id)
        {
            string queryString = $"/{Id}";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"api/Bank{queryString}"));
            return await DeleteAsync(requestUrl);
        }
    }
}
