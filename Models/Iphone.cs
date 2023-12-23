namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write($"Instalando o aplicativo {nomeApp} no Iphone \n");
        }
    }
    // TODO: Sobrescrever o método "InstalarAplicativo"
}
