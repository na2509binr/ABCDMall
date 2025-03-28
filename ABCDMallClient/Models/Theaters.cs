namespace ABCDMallClient.Models
{
    public class Theaters
    {
        public string Theater_Id { get; set; }
        public string Cinema_Id { get; set; } 
        public string Name { get; set; } //Tên Phòng chiếu
        public string Rows_Of_Theater { get; set; } //Số hàng
        public string Seats_Per_Row { get; set; } //Số ghế mỗi hàng
        public int Capation { get; set; } //Sức chứa

        public Theaters()
        {

        }

        public Theaters(string theater_Id, string cinema_Id, string name, string rows_Of_Theater, string seats_Per_Row, int capation)
        {
            Theater_Id = theater_Id;
            Cinema_Id = cinema_Id;
            Name = name;
            Rows_Of_Theater = rows_Of_Theater;
            Seats_Per_Row = seats_Per_Row;
            Capation = capation;
        }
    }
}
