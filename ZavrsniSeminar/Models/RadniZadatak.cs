namespace ZavrsniSeminar.Models
{
    public class RadniZadatak
    {
        public int Id { get; set; }
        public string todo { get; set; }
        public string radnikIme { get; set; }
        public string radnikPrezime { get; set; }
        public string opisPosla { get; set; }
        public DateTime? datum { get; set; }
        public bool IsDone { get; set; }
    }
}
