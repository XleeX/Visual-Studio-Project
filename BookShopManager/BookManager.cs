using BookShopEntity;
using BookShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManager
{
    public class BookManager
    {
        private BookInfoService bis = new BookInfoService();
        public BookInfo GetBookBy(int id)
        {
            return bis.SearchById(id);  
        }

        public List<BookInfo> GetBookList(int cateid)
        {
            return bis.GetBookList(cateid);
        }

        public bool Delete(int id)
        {
            return bis.S_Delete(id);  
        }

        public bool Add(BookInfo book)
        {
            return bis.S_Add(book);
        }
    }
}
