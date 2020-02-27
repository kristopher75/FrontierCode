using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using FrontierCode.Models;

namespace FrontierCode.Services
{
    public interface IAccountService
    {
        Task<IList<AccountModel>> GetAccounts();       
    }
}
