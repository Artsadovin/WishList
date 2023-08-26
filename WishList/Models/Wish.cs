namespace Models
{
    public class Wish
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        //public ??? Voice { get; set; }
    }
}