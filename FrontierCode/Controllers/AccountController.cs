using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;
using System.Threading.Tasks;

using FrontierCode.Models;
using FrontierCode.Services;

namespace FrontierCode.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService accountService = null;

        public AccountController(IAccountService accountService)
            : base()
        {
            this.accountService = accountService;
        }

        public async Task<ActionResult> GetAllAccounts()
        {
            var accounts = await accountService.GetAccounts();
            return View(accounts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
