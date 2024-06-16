namespace ProjektByt
{
    internal interface IHypoteka
    {
        int puvodniVyseHypoteky { get; set; }
        int mesicniSplatka { get; set; }
        DateTime splatnostHypoteky { get; set; }

        int ZbyvajiciSplatky();
        double ZbyvaDoplatit();

        void VypisZbyvajiciDluh();

    }
}
