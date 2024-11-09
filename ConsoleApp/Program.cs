namespace ConsoleApp
{
    public class Proizvod
    {

        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }


        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena} E");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Proizvod proizvod = new Proizvod("Auto", 40000, 10);

            proizvod.IspisiInformacije();
        }
    }
}
