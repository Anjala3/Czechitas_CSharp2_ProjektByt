namespace ProjektByt
{
    internal abstract class Dan
    {
        // zde bych rada navazala na metodu PlatiSeDan() z Byt,
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
