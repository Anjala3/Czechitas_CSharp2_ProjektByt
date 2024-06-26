namespace ProjektByt
{
    [Serializable]
    public class BytLegerova : Byt, IHypoteka

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




        public override bool JeObsazen() => base.JeObsazen();
        public override bool PlatiSeDan() => base.PlatiSeDan();
        public override bool PlatiSmlouva() => base.PlatiSmlouva();
        public override int DoKonceSmlouvyZbyva() => base.DoKonceSmlouvyZbyva();

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
            Console.WriteLine($"Zbyvajici vyse dluhu z hypoteky: {ZbyvaDoplatit()}");
        }
    }



}
