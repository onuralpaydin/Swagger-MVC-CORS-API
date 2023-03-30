using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBorsa.Model;

namespace WebApiBorsa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KurlarController : ControllerBase
    {
        List<Kur> kurListesi = new List<Kur>()
        {
            new Kur() {Kod="USD",Deger=19.11m},
            new Kur() {Kod="EUR",Deger=20.11m},
            new Kur() {Kod="STE",Deger=21.11m},
        };

        //[HttpGet]
        //public List<Kur> GetKurListesi()
        //{
        //    return kurListesi;
        //}

        [HttpGet("{kod}")]
        public ActionResult<decimal> GetKurBilgisi(string kod)
        {
            Kur bulunacakKur = kurListesi.FirstOrDefault(x => x.Kod == kod);
            if (bulunacakKur == null)
            {
                return NotFound(); //not found kullanmak istiyorum. müsade etmiyor. actionresult tanımlarsam hem sayfa döndürcem hem de döndüreceğim sayfa decimal tipinde de olabilir.
                //404 not found.
            }
            return bulunacakKur.Deger;
        }

        //[HttpGet("{kod}")]
        //public KurBilgisiResponse GetKurBilgisi1(string kod)
        //{
        //    KurBilgisiResponse resp = new KurBilgisiResponse();
        //    Kur bulunacakKur = kurListesi.FirstOrDefault(x => x.Kod == kod);
        //    if (bulunacakKur == null)
        //    {
        //        resp.basariliMi = false;
        //        resp.Message = "Kod bulunamadı";

        //    }
        //    else
        //    {
        //        resp.basariliMi = true;
        //        resp.donenDeger = bulunacakKur.Deger;
        //    }
        //    return resp;
        //}

        public class Response
        {
            public bool basariliMi { get; set; }
            public string Message { get; set; }
        }

        public class KurBilgisiResponse:Response
        {
            public decimal donenDeger { get; set; }
        }
    }
}
