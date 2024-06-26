namespace ProjektByt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cestaKeSlozce = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            string cestaKSouboru = Path.Combine(cestaKeSlozce, "evidenceBytu.txt");

            File.WriteAllText(cestaKSouboru, string.Empty); //promazu si soubor, aby se mi neretezily vypsane informace

            BytLegerova bytLegerova = new BytLegerova
            {
                PlatnostSmlouvyDo = new DateTime(2025, 1, 31)
            };
            bytLegerova.ZbyvajiciSplatky();
            bytLegerova.VypisZbyvajiciDluh();

            BytHorky bytHorky = new BytHorky
            {
                PlatnostSmlouvyDo = new DateTime(2027, 2, 12)
            };

            BytDittrichova bytDittrichova = new BytDittrichova
            {
                PlatnostSmlouvyDo = new DateTime(2025, 10, 15)
            };
            bytDittrichova.ZbyvajiciSplatky();
            bytDittrichova.VypisZbyvajiciDluh();

            List<Byt> seznamBytu = new List<Byt> { bytLegerova, bytHorky, bytDittrichova };


            XMLhelper.ExportToXml(seznamBytu, cestaKSouboru);





        }
    }
}
