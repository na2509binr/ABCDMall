using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ABCD_Mall_Online.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; } //Tên film
        public string Actor { get; set; } //Diễn viên
        public string Director { get; set; } //Đạo diễn
        public int Time { get; set; } //Thời lượng(phút)
        public DateTime ReleaseDate { get; set; } //Ngày bắt đầu chiếu
        public string Image { get; set; } 
        public string Genre { get; set; } //Thể loại

        public Film()
        {
            
        }

        public Film(int filmId, string title, string actor, string director, int time, DateTime releaseDate, string image, string genre)
        {
            FilmId = filmId;
            Title = title;
            Actor = actor;
            Director = director;
            Time = time;
            ReleaseDate = releaseDate;
            Image = image;
            Genre = genre;
        }
    }
}
