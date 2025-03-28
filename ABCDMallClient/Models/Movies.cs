using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ABCD_Mall_Online.Models
{
    public class Movies
    {
        public int Movie_Id { get; set; }
        public string Title { get; set; } //Tên film
        public string Genre { get; set; } //Thể loại
        public int Duration { get; set; } //Thời lượng
        public DateTime Release_Date { get; set; } //Ngày bắt đầu chiếu
        public DateTime Stop_Screening_Date { get; set; } //Ngày ngừng chiếu
        public string Description { get; set; } //Mô tả nội dung
        public string Poster_Url { get; set; } //Đường dẫn ảnh Poster phim
        public string Trailer { get; set; } 
        public int Status { get; set; } //Trạng thái phim (VD: đang chiếu, sắp chiếu, ngừng chiếu)

        public Movies()
        {
            
        }

        public Movies(int movie_Id, string title, string genre, int duration, DateTime release_Date, DateTime stop_Screening_Date, string description, string poster_Url, string trailer, int status)
        {
            Movie_Id = movie_Id;
            Title = title;
            Genre = genre;
            Duration = duration;
            Release_Date = release_Date;
            Stop_Screening_Date = stop_Screening_Date;
            Description = description;
            Poster_Url = poster_Url;
            Trailer = trailer;
            Status = status;
        }
    }
}
