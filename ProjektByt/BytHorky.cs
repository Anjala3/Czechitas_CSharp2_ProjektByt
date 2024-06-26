namespace ProjektByt
{
    [Serializable]
    public class BytHorky : Byt
    {

        public BytHorky() : base("osobni", 45, 15000, "Vlado", 4.5)
        {
            Najemnik petrModry = new Najemnik("Petr", "Modry", 777777, "modry@gmail.com");
            Najemnik janCerny = new Najemnik("Jan", "Cerny", 888888, "cerny@gmail.com");

            PridejNajemnika(petrModry);
            PridejNajemnika(janCerny);
        }

        public override bool JeObsazen() => base.JeObsazen();
        public override bool PlatiSeDan() => base.PlatiSeDan();
        public override bool PlatiSmlouva() => base.PlatiSmlouva();
        public override int DoKonceSmlouvyZbyva() => base.DoKonceSmlouvyZbyva();
    }

}

