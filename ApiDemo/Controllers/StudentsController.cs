using ApiDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //httpget default almıyor
        [HttpGet]
        public string AdGetir()
        {
            //neden ad getir gözükmedi. Parametresiz bulduğu methodu getirdi.
     
            
            return "Ali";
        }
        //        [HttpGet]
        //        public string AdGetir2()
        //        {
        //            //hata verecek parametre almayan 2 tane get methodu var             return "Ali";
        //            return "Ali";
        //        //hatanın ne olduğunu söylemiyor. veriyi çekeniyorum diyor sadece.
        //        //https://localhost:7290/api/students linke gittik
        ////        AmbiguousMatchException: The request matched multiple endpoints.Matches:

        ////ApiDemo.Controllers.StudentsController.AdGetir(ApiDemo)
        ////ApiDemo.Controllers.StudentsController.AdGetir2(ApiDemo)
        //        }


        [HttpGet("{ogrenciAdi}")]
        //yolu artık farklı endpointleri artık farklı.
        public string AdGetir2(string ogrenciAdi)
        {
            //hata verecek parametre almayan 2 tane get methodu var             return "Ali";
            return "merhaba " + ogrenciAdi;
          //artık çakışma yok
        }

        //classı açtıktan sonra liste çekeceğim
        [HttpPost]
        public List<Student> OgrencileriGetir()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { Id = 1, Adi = "Onur Alp", Soyadi = "Aydın", Yasi = 27 });
            studentList.Add(new Student() { Id = 1, Adi = "ali", Soyadi = "veli", Yasi = 19 });
            studentList.Add(new Student() { Id = 1, Adi = "veli", Soyadi = "ali", Yasi = 20 });
            return studentList;
           
        }
        //çakışma oluyor üstteki ile kurtulmam lazım. Ya parametreleri düzelteceğim ya get post
        //get methodu gibi yaptım ama post kullandım. İki farklı method gibi düşünün. Post yazdım diye veri göndermesine gerek yok. ama linki yazıp gitmeye çalışırsam get çalışır. Önemli ve gizli verileri gönderirken kullanmalısın. 
        //oluşturduğumuz listeyi json formatta çektik.

        // response headers anlat get post headers kısmı farklı postta veri body de taşınıyor ulaşmak daha zor.
        //https://www.kampuskod.com/yazilim/java/get-vs-post-arasindaki-fark-nedir/
    }
}
