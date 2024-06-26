namespace ProjektByt
{
    public abstract class Dan
    {


        public virtual double VypoctiDan()
        {

            double koeficientPlochy = 1.22;
            double dan = Byt.DanovyKoeficient * koeficientPlochy * (Byt.Rozmer * 2);
            return dan;
        }

    }
}
