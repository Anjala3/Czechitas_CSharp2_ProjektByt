namespace ProjektByt
{
    internal class Najemnici
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }



        public Najemnici(string jmeno, string prijmeni, int telefon, string email)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Telefon = telefon;
            Email = email;

        }




    }
}
