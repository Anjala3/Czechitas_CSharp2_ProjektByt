namespace ProjektByt
{

    internal abstract class Byty : Dane
    {
        public string Vlastnictvi;
        public static double Rozmer;
        public int PocetNajemniku;
        public int VyseNajmu;
        public string MajitelUctu;
        public static double DanovyKoeficient;
        public DateTime PlatnostSmlouvyDo;
        public List<Najemnici> NajemniciList { get; set; }


        public Byty(string vlastnictvi, double rozmer, int vyseNajmu, string majitelUctu, double danovyKoeficient)

        {
            Vlastnictvi = vlastnictvi;
            Rozmer = rozmer;
            VyseNajmu = vyseNajmu;
            MajitelUctu = majitelUctu;
            DanovyKoeficient = danovyKoeficient;
            NajemniciList = new List<Najemnici>();

            PocetNajemniku = 0;

        }

        public void PridejNajemnika(Najemnici najemnik)
        {
            NajemniciList.Add(najemnik);
            PocetNajemniku = NajemniciList.Count;
        }
        public virtual bool JeObsazen()
        {
            if (PocetNajemniku > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool PlatiSeDan()
        {
            if (Vlastnictvi == "osobni")
            { return true; }
            else { return false; }
        }

        public virtual int DoKonceSmlouvyZbyva()
        {
            DateTime now = DateTime.Now;
            TimeSpan zbyvajiciCas = PlatnostSmlouvyDo - now;
            return (int)zbyvajiciCas.TotalDays;
        }
        public virtual bool PlatiSmlouva() //mozna je to navic?
        {
            if (PlatnostSmlouvyDo <= DateTime.Today)
            {
                return true;
            }
            else
            { return false; }
        }


        public virtual void ZapisDoSOuboru()
        {
            // abych videla co zapisuji
            Console.WriteLine($"Nazev bytu: {this.GetType().Name}");
            Console.WriteLine($"Typ vlastnictvi: {Vlastnictvi}");
            Console.WriteLine($"Rozmer bytu: {Rozmer} m2");
            Console.WriteLine($"Obsazenost je {JeObsazen()}.");
            Console.WriteLine($"Pocet najemniku: {PocetNajemniku}.");
            VypisNajemnika();
            Console.WriteLine($"Vyse najemneho: {VyseNajmu} Kc");
            Console.WriteLine($"Najemne se plati na ucet patrici: {MajitelUctu}");
            Console.WriteLine($"Za tento byt se plati dan z nemovitosti: {PlatiSeDan()}");
            Console.WriteLine($"Vyse dane je: {VypoctiDan()}");
            Console.WriteLine($"Smlouva plati do {PlatnostSmlouvyDo.ToShortDateString()}");
            Console.WriteLine($"Smlouva plati jeste {DoKonceSmlouvyZbyva()} dni.");



            //ted uz samotny zapis do souboru


            List<string> najmeniciDoSouboru = new List<string>();
            string cestaKSouboru = @"C:\Users\komor\source\repos\Czechitas_CSharp2_ProjektByt\evidenceBytu.txt";
            string[] poleTextu = {$"Nazev bytu: {this.GetType().Name}", $"Typ vlastnictvi: {Vlastnictvi}", $"Rozmer bytu: {Rozmer} m2",
                $"Obsazenost je {JeObsazen()}", $"Pocet najemniku: {PocetNajemniku}", $"Vyse najemneho: {VyseNajmu} Kc",
                $"Najemne se plati na ucet patrici: {MajitelUctu}", $"Za tento byt se plati dan z nemovitosti: {PlatiSeDan()}",
                $"Vyse dane je: {VypoctiDan()}",
                $"Smlouva plati do {PlatnostSmlouvyDo.ToShortDateString()}", $"Smlouva plati jeste {DoKonceSmlouvyZbyva()} dni",

               };

            File.AppendAllText(cestaKSouboru, "\n");
            File.AppendAllLines(cestaKSouboru, poleTextu);

            foreach (var najemnik in NajemniciList)
            {
                najmeniciDoSouboru.Add($"{najemnik.Jmeno} {najemnik.Prijmeni}, Telefon: {najemnik.Telefon}, Email: {najemnik.Email}");
            }


            File.AppendAllLines(cestaKSouboru, najmeniciDoSouboru);
            File.AppendAllText(cestaKSouboru, "\n");

        }


        public override double VypoctiDan()
        {
            if (PlatiSeDan())
            { return base.VypoctiDan(); }
            else
            { return 0.0; };
        }

        public virtual void VypisNajemnika()
        {

            foreach (var najemnik in NajemniciList)
            {
                Console.WriteLine($"Najemnik: {najemnik.Jmeno} {najemnik.Prijmeni}");
                Console.WriteLine($"Telefon: {najemnik.Telefon}, Email: {najemnik.Email}");
            }
        }
    }
}

