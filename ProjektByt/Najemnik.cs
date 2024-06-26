namespace ProjektByt
{
    [Serializable]
    public class Najemnik
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }



        public Najemnik(string jmeno, string prijmeni, int telefon, string email)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Telefon = telefon;
            Email = email;

        }

        public Najemnik() { }



    }
}
