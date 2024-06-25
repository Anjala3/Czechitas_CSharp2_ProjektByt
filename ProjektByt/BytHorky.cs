namespace ProjektByt
{
    internal class BytHorky : Byt
    {

        public BytHorky() : base("osobni", 45, 15000, "Vlado", 4.5)
        {
            Najemnici petrModry = new Najemnici("Petr", "Modry", 777777, "modry@gmail.com");
            Najemnici janCerny = new Najemnici("Jan", "Cerny", 888888, "cerny@gmail.com");

            PridejNajemnika(petrModry);
            PridejNajemnika(janCerny);
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

    }
}
