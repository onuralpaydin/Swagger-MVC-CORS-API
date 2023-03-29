namespace ApiDemo
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    //d�md�z projeyi �al��t�r. swagger bize bir aray�z sunuyor. aray�z� g�rmek istemezsem linke get istegi atarsam elde edece�im g�r�nt� a�a��daki.
    //https://localhost:7290/weatherforecast bu linke gidersem. kendim istek atarsam elde etti�im g�r�nt�.
    //[{"date":"2023-03-30T22:01:02.7472904+03:00","temperatureC":1,"temperatureF":33,"summary":"Freezing"},{ "date":"2023-03-31T22:01:02.7472961+03:00","temperatureC":15,"temperatureF":58,"summary":"Freezing"},{ "date":"2023-04-01T22:01:02.7472963+03:00","temperatureC":-11,"temperatureF":13,"summary":"Hot"},{ "date":"2023-04-02T22:01:02.7472964+03:00","temperatureC":10,"temperatureF":49,"summary":"Bracing"},{ "date":"2023-04-03T22:01:02.7472965+03:00","temperatureC":31,"temperatureF":87,"summary":"Bracing"}]
    //get e t�kla execute de ��kt�ya bak
    //yukar�daki ��kt�y� okumak biraz zor o y�zden swagger ��km��. Okumas� kolay
    //weatherforecast �st�ne t�kla �ema a��ls�n. �ema endpointleri nas�l kullanaca��m� veriye nas�l ula�abilece�imi anlat�yor.
    //localhost json a t�kla ��kt�y� g�ster.
    //https://localhost:7290/swagger/v1/swagger.json
    //apimizin ba�ka programlar�n anlayaca�� �ekilde json dosyas� olarak g�steriyor. �emas�n� anlat�yor.
    //apinin versiyonlar� olabilir versiyon eklenmi� olabilir. yukar�dan versiyon se�mek �nemli. de�i�iklikler olduysa vs
    //api nedir. UI ile data aras� ileti�imi sa�lar bir veritaban�n� birden fazla uygulama istemci client kullanabilir. Hem de dataya koruma sa�lar.Direk b�t�n veritaban�na ula�man� de�il ilgili k�s�mlara ya da sana g�sterilebilecek kadar�na eri�ebiliyorsun.
    //program.cs ye gir
    //buray� biliyoruz mvc ye benziyor.
    //1 web applicationu temelini kuruyor..
    //5-6-7 swagger-8 open apimiz hakk�nda bilgi veriyor. dependency injection
    //10 uygulamam�z� kuruyor.
    //WeatherForecastController a git
}