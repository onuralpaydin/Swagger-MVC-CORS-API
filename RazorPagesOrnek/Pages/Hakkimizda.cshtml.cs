using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesOrnek.Pages
{
    public class HakkimizdaModel : PageModel
    {
        public string Ad { get; set; }
        public void OnGet()
        {
            //hakkýmýzda sayfasý açýlýrken burasý çalýþacak.
            Ad = "Onur Alp Aydýn";
        }
    }
}
