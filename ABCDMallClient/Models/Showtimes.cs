namespace ABCDMallClient.Models
{
    public class Showtimes
    {
        public string Showtime_Id { get; set; }
        public string Movie_Id { get; set; }
        public string Theater_Id { get; set; }
        public DateTime Start_Time { get; set; }

        public Showtimes()
        {

        }

        public Showtimes(string showtime_Id, string movie_Id, string theater_Id, DateTime start_Time)
        {
            Showtime_Id = showtime_Id;
            Movie_Id = movie_Id;
            Theater_Id = theater_Id;
            Start_Time = start_Time;
        }
    }
}
