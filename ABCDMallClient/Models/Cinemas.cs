namespace ABCDMallClient.Models
{
    public class Cinemas
    {
        public string Cinema_Id { get; set; }
        public string Name { get; set; } //Tên rạp chiếu
        public string Location { get; set; } //Địa chỉ rạp chiếu
        public string Phone { get; set; } //Số điện thoại liên hệ
        public string City { get; set; } //Khu vực

        public Cinemas()
        {
            
        }

        public Cinemas(string cinema_Id, string name, string location, string phone, string city)
        {
            Cinema_Id = cinema_Id;
            Name = name;
            Location = location;
            Phone = phone;
            City = city;
        }
    }
}
