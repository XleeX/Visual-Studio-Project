using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopEntity
{
    public class BookInfo
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Author { set; get; }
        public int PublisherId { set; get; }
        public string PublishDate { set; get; }
        public string ISBN { set; get; }
        public double UnitPrice { set; get; }
        public string ContentDescription { set; get; }
        public string TOC { set; get; }
        public int CategoryId { set; get; }
        public int Clicks { set; get; }
        
    }
}
