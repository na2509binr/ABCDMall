namespace ABCDMallClient.Models
{
    public class Seats
    {
        public string Seat_Id { get; set; }
        public string Theater_Id { get; set; }
        public string Seat_Name { get; set; } //Tên Ghế
        public decimal Price { get; set; } //Giá ghế
        public int Type { get; set; } //Loại Ghế

        public Seats()
        {

        }

        public Seats(string seat_Id, string theater_Id, string seat_Name, decimal price, int type)
        {
            Seat_Id = seat_Id;
            Theater_Id = theater_Id;
            Seat_Name = seat_Name;
            Price = price;
            Type = type;
        }
    }
}
