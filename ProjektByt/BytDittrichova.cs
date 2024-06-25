namespace ProjektByt
{
    internal class BytDittrichova : Byt, IHypoteka
    {
        public BytDittrichova() : base("osobni", 50, 19000, "Frantisek", 4.5)
        {
            Najemnici lenkaHajna = new Najemnici("Lenka", "Hajna", 2222222, "hajna@gmail.com");

            PridejNajemnika(lenkaHajna);
        }



        public int puvodniVyseHypoteky { get; set; } = 4500000;
        public int mesicniSplatka { get; set; } = 12000;
        public DateTime splatnostHypoteky { get; set; } = new DateTime(2050, 6, 17);
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
