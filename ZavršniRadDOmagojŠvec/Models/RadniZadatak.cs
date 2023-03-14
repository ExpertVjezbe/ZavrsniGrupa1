namespace ZavršniRadDOmagojŠvec.Models
{
    public class RadniZadatak
    {
        public int Id { get; set; }
        public string ToDo { get; set; }
        public string OpisPosla { get; set; }
        public string RadnikIme { get; set; }
        public string RadnikPrezime { get; set; }
        public DateTime? Datum { get; set; }
        public bool IsDone { get; set; }
    }

}
    


