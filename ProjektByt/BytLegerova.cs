
namespace ProjektByt
{
    internal class BytLegerova : Byt, IHypoteka

    {


        public int puvodniVyseHypoteky { get; set; } = 5000000;
        public int mesicniSplatka { get; set; } = 20000;
        public DateTime splatnostHypoteky { get; set; } = new DateTime(2041, 1, 31);

        public BytLegerova() : base("druzstevni", 74, 28000, "Matej", 4.5)
        {
            Najemnik martinNovak = new Najemnik("Martin", "Novak", 777777, "novak@gmail.com");
            Najemnik petraNovakova = new Najemnik("Petra", "Novakova", 888888, "novakova@gmail.com");
            Najemnik diteNovak = new Najemnik("Julia", "Novakova", 0, string.Empty);

            PridejNajemnika(martinNovak);
            PridejNajemnika(petraNovakova);
            PridejNajemnika(diteNovak);
        }


        public override bool JeObsazen()
        {
            return base.JeObsazen();
        }

        public override bool PlatiSeDan()
        {
            return base.PlatiSeDan();

        }

        public override bool PlatiSmlouva()
        {
            return base.PlatiSmlouva();
        }

        public override int DoKonceSmlouvyZbyva()
        {
            return base.DoKonceSmlouvyZbyva();
        }
        public override void ZapisDoSOuboru()
        {
            base.ZapisDoSOuboru();
        }

        int zbyvajiciPocetSplatek;

        public int ZbyvajiciSplatky()
        {
            DateTime now = DateTime.Now;
            zbyvajiciPocetSplatek = ((splatnostHypoteky.Year - now.Year) * 12) + (splatnostHypoteky.Month - now.Month);


            if (now.Day > splatnostHypoteky.Day)
            {
                zbyvajiciPocetSplatek--;
            }

            return zbyvajiciPocetSplatek;
        }
        public double ZbyvaDoplatit()
        {
            double zbyvajiciDluh = puvodniVyseHypoteky - (mesicniSplatka * zbyvajiciPocetSplatek);
            return zbyvajiciDluh;

        }

        public void VypisZbyvajiciDluh()
        {
            //nejdriv na Consoli abych to videla :)
            Console.WriteLine($"Zbyvajici vyse dluhu z hypoteky:{ZbyvaDoplatit()}");

            //pak do souboru

            string pridejDoSouboru = $"Zbyvajici vyse dluhu z hypoteky:{ZbyvaDoplatit()}";
            File.AppendAllText(@"C:\Users\komor\source\repos\Czechitas_CSharp2_ProjektByt\evidenceBytu.txt", pridejDoSouboru);
            File.AppendAllText(@"C:\Users\komor\source\repos\Czechitas_CSharp2_ProjektByt\evidenceBytu.txt", "\n");

        }
    }



}
