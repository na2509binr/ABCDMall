using ABCD_Mall_Online.Models;
using X.PagedList;
using static System.Formats.Asn1.AsnWriter;

namespace ABCDMallClient.Models
{
    public class GetDataToViewModel
    {
        //public Category category { get; set; }
        //public IPagedList<Category> catList { get; set; }

        //public Store store { get; set; }
        //public IPagedList<Store> stList { get; set; }

        //public Genre genre { get; set; }
        //public IPagedList<Genre> genreList { get; set; }

        public Movies film { get; set; }
        public IPagedList<Movies> filmList { get; set; }
    }
}
