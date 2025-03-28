namespace ABCDMallClient.Models
{
    public class Tickets
    {
        public string Ticket_Id { get; set; }
        public string User_Id { get; set; }
        public string Showtime_Id { get; set; }
        public string Seat_Id { get; set; }
        public DateTime Booking_Date { get; set; } //Thời gian mua vé
        public int Status { get; set; } //Trạng thái ghế

        public Tickets()
        {

        }

        public Tickets(string ticket_Id, string user_Id, string showtime_Id, string seat_Id, DateTime booking_Date, int status)
        {
            Ticket_Id = ticket_Id;
            User_Id = user_Id;
            Showtime_Id = showtime_Id;
            Seat_Id = seat_Id;
            Booking_Date = booking_Date;
            Status = status;
        }
    }
}
