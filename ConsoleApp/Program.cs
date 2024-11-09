using ConsoleApp;

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

    public class ElektronickiUredaj
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }

        public int GodinaProizvodnje { get; set; }

        public ElektronickiUredaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvodjac}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }


    }

    public class PametniTelefon : ElektronickiUredaj
    {
        public string OperativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
        : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }
        public void IspisiInformacije()
        { 
            base.ispisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
        }

         public void InstalirajAplikaciju(string nazivAplikacije)
        {
        Console.WriteLine($"Aplikacija '{nazivAplikacije}' je instalirana na uređaj.");
        }
}

    class Program
    {
        static void Main(string[] args)
        {

            Proizvod proizvod = new Proizvod("Auto", 40000, 10);

            proizvod.IspisiInformacije();

            PametniTelefon telefon = new PametniTelefon("iPhone", "Apple", 2025, "iOS");
            telefon.IspisiInformacije();

        
            telefon.InstalirajAplikaciju("YouTube");
    }
    }


}
