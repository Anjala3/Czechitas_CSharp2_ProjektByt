namespace ProjektByt
{
    internal abstract class Dane
    {
        // zde bych rada navazala na metodu PlatiSeDan() z Byty,
        // ze pokud je to false, tak se nepocita dan a vypise to hlasku.
        // Akorat nevim jak na to.

        public virtual double VypoctiDan()
        {

            double koeficientPlochy = 1.22;
            double dan = Byt.DanovyKoeficient * koeficientPlochy * (Byt.Rozmer * 2);
            return dan;
        }

    }
}
