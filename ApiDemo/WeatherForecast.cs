namespace ApiDemo
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    //dümdüz projeyi çalýþtýr. swagger bize bir arayüz sunuyor. arayüzü görmek istemezsem linke get istegi atarsam elde edeceðim görüntü aþaðýdaki.
    //https://localhost:7290/weatherforecast bu linke gidersem. kendim istek atarsam elde ettiðim görüntü.
    //[{"date":"2023-03-30T22:01:02.7472904+03:00","temperatureC":1,"temperatureF":33,"summary":"Freezing"},{ "date":"2023-03-31T22:01:02.7472961+03:00","temperatureC":15,"temperatureF":58,"summary":"Freezing"},{ "date":"2023-04-01T22:01:02.7472963+03:00","temperatureC":-11,"temperatureF":13,"summary":"Hot"},{ "date":"2023-04-02T22:01:02.7472964+03:00","temperatureC":10,"temperatureF":49,"summary":"Bracing"},{ "date":"2023-04-03T22:01:02.7472965+03:00","temperatureC":31,"temperatureF":87,"summary":"Bracing"}]
    //get e týkla execute de çýktýya bak
    //yukarýdaki çýktýyý okumak biraz zor o yüzden swagger çýkmýþ. Okumasý kolay
    //weatherforecast üstüne týkla þema açýlsýn. Þema endpointleri nasýl kullanacaðýmý veriye nasýl ulaþabileceðimi anlatýyor.
    //localhost json a týkla çýktýyý göster.
    //https://localhost:7290/swagger/v1/swagger.json
    //apimizin baþka programlarýn anlayacaðý þekilde json dosyasý olarak gösteriyor. Þemasýný anlatýyor.
    //apinin versiyonlarý olabilir versiyon eklenmiþ olabilir. yukarýdan versiyon seçmek önemli. deðiþiklikler olduysa vs
    //api nedir. UI ile data arasý iletiþimi saðlar bir veritabanýný birden fazla uygulama istemci client kullanabilir. Hem de dataya koruma saðlar.Direk bütün veritabanýna ulaþmaný deðil ilgili kýsýmlara ya da sana gösterilebilecek kadarýna eriþebiliyorsun.
    //program.cs ye gir
    //burayý biliyoruz mvc ye benziyor.
    //1 web applicationu temelini kuruyor..
    //5-6-7 swagger-8 open apimiz hakkýnda bilgi veriyor. dependency injection
    //10 uygulamamýzý kuruyor.
    //WeatherForecastController a git
}