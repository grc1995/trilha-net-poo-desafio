namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalar o aplicativo {nomeApp} no iPhone");
        }

        public Iphone (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }
    }
}