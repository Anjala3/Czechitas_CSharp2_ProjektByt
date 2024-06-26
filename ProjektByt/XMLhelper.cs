using System.Xml.Serialization;

namespace ProjektByt
{
    public static class XMLhelper
    {
        public static void ExportToXml(List<Byt> seznamBytu, string cestaKSouboru)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Byt>));

                using (StreamWriter writer = new StreamWriter(cestaKSouboru, append: false))
                {
                    serializer.Serialize(writer, seznamBytu);
                }

                Console.WriteLine($"Export to XML successful. File path: {cestaKSouboru}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error exporting to XML: {ex.Message}");
                throw;
            }
        }
    }

}
