using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesOrnek.Pages
{
    public class HakkimizdaModel : PageModel
    {
        public string Ad { get; set; }
        public void OnGet()
        {
            //hakk�m�zda sayfas� a��l�rken buras� �al��acak.
            Ad = "Onur Alp Ayd�n";
        }
    }
}
