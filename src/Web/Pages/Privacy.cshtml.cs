using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Microsoft.eShopWeb.Web.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            throw new Exception(
                "This is an (un)expected exception. " +
                "This exception is added on purpose for use in an Azure Workshop");
        }
    }
}
