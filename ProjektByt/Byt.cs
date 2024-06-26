using System.Xml.Serialization;

namespace ProjektByt
{
    [XmlInclude(typeof(BytLegerova))]
    [XmlInclude(typeof(BytHorky))]
    [XmlInclude(typeof(BytDittrichova))]
    [Serializable]
    public abstract class Byt : Dan
    {
        public string Vlastnictvi { get; set; }
        public static double Rozmer { get; set; }
        public int PocetNajemniku { get; set; }
        public int VyseNajmu { get; set; }
        public string MajitelUctu { get; set; }
        public static double DanovyKoeficient { get; set; }
        public DateTime PlatnostSmlouvyDo { get; set; }
        public List<Najemnik> NajemniciList { get; set; }


        public Byt(string vlastnictvi, double rozmer, int vyseNajmu, string majitelUctu, double danovyKoeficient)

        {
            Vlastnictvi = vlastnictvi;
            Rozmer = rozmer;
            VyseNajmu = vyseNajmu;
            MajitelUctu = majitelUctu;
            DanovyKoeficient = danovyKoeficient;
            NajemniciList = new List<Najemnik>();

            PocetNajemniku = 0;

        }

        public Byt() { }


        public void PridejNajemnika(Najemnik najemnik)
        {
            NajemniciList.Add(najemnik);
            PocetNajemniku = NajemniciList.Count;
        }
        public virtual bool JeObsazen() => PocetNajemniku > 0;

        public virtual bool PlatiSeDan() => Vlastnictvi == "osobni";

        public virtual int DoKonceSmlouvyZbyva()
        {
            DateTime now = DateTime.Now;
            TimeSpan zbyvajiciCas = PlatnostSmlouvyDo - now;
            return (int)zbyvajiciCas.TotalDays;
        }
        public virtual bool PlatiSmlouva() => PlatnostSmlouvyDo > DateTime.Today;


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

