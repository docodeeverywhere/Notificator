using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;

using Newtonsoft.Json;

namespace Notificator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string AppToken { get; set; }

        [BindProperty]
        public string UserKey { get; set; }

        [BindProperty]
        public string Message { get; set; }
        
        public void OnGet()
        {
        }

        /// <summary>
        /// Send button click processing
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                var pushoverService = new PushoverService(AppToken);
                pushoverService.SendMessage(UserKey, Message);
            }
            catch
            {
                ViewData["Result"] = $"The operation failed.";
                return this.Page();
            }

            ViewData["Result"] = "The message was successfully sent!";
            
            return this.Page();
        }
    }
}
