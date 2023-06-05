namespace BorrowingBooks.Models
{
    public class BorrowModel
    {
        public int Id { get; set; }
        public string Taker { get; set; }
        public string Provider { get; set; }
        public string BookName { get; set; }
        public DateTime BorrowUpdateDate { get; set; } = DateTime.Now;
    }
}
