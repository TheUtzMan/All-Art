using Microsoft.AspNetCore.Mvc.RazorPages;

namespace All_Art.Pages
{
    public class _HostModel:PageModel
    {
        public void OnGet()
        {
            Response.Headers.Add("Cross-Origin-Resource-Policy", "cross-origin");
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
            Response.Headers.Add("Access-Control-Allow-Methods", "GET");
            Response.Headers.Add("Access-Control-Allow-Credentials","true");
        }
    }
}
