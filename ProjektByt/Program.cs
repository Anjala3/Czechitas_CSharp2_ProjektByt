namespace ProjektByt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cestaKSouboru = @"C:\Users\komor\source\repos\Czechitas_CSharp2_ProjektByt\evidenceBytu.txt";

            File.WriteAllText(cestaKSouboru, string.Empty); //promazu si soubor, aby se mi neretezily vypsane informace


            BytLegerova bytLegerova = new BytLegerova();
            DateTime platnostLegerova = new DateTime(2025, 1, 31);
            bytLegerova.PlatnostSmlouvyDo = platnostLegerova;

            bytLegerova.ZapisDoSOuboru();
            bytLegerova.ZbyvajiciSplatky();
            bytLegerova.VypisZbyvajiciDluh();
            Console.WriteLine();

            BytHorky bytHorky = new BytHorky();
            DateTime platnostHorky = new DateTime(2027, 2, 12);
            bytHorky.PlatnostSmlouvyDo = platnostHorky;

            bytHorky.ZapisDoSOuboru();
            Console.WriteLine();

            BytDittrichova bytDittrichova = new BytDittrichova();
            DateTime platnostDittrichova = new DateTime(2025, 10, 15);
            bytDittrichova.PlatnostSmlouvyDo = platnostDittrichova;

            bytDittrichova.ZapisDoSOuboru();
            bytDittrichova.ZbyvajiciSplatky();
            bytDittrichova.VypisZbyvajiciDluh();
            Console.WriteLine();





        }
    }
}
