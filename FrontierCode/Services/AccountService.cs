using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using FrontierCode.Models;

namespace FrontierCode.Services
{
    public class AccountService : IAccountService
    {
        public async Task<IList<AccountModel>> GetAccounts()
        {
            string azureUrl = "https://frontiercodingtests.azurewebsites.net/api/accounts/getall";
            IList<AccountModel> retVal = null;

            using (var httpClient = new HttpClient())
            {
                var responseMessage = await httpClient.GetAsync($"{azureUrl}");
                retVal = JsonConvert.DeserializeObject<IList<AccountModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return retVal.OrderBy(account => account.AccountStatusId)
                         .ThenBy (account => account.Id)
                         .ToList();
        }
    }
}