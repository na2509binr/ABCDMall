namespace ABCDMallClient.Models
{
    public class Users
    {
        public string User_Id { get; set; }
        public string Name { get; set; } //Tên người dùng
        public string Email { get; set; } //Email liên hệ / tài khoản
        public string Password { get; set; } //Mật khẩu
        public string Phone { get; set; } //Số điện thoại liên hệ
        public int Role { get; set; } //Chức vụ
        public DateTime Created_At { get; set; } //Khu vực

        public Users()
        {

        }

        public Users(string user_Id, string name, string email, string password, string phone, int role, DateTime created_At)
        {
            User_Id = user_Id;
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Role = role;
            Created_At = created_At;
        }
    }
}
