using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopEntity;
using BookShop.DAL;
using System.Data;
using System.Data.SqlClient;

namespace BookShopService
{
   public class BookInfoService : SqlHelper
    {
        
       public bool S_Add(BookInfo b)  
       {
           string sql = "insert into dbo.Books (Title, Author, PubliserId, PublishDate, ISBN, UnitPrice, ContentDescrption, TOC, CategoryId, Clicks) "
               + "values(@title, @author, @publisherId, @publishDate, @isbn, @unitPrice, @contentDescrption, @tOC, @categoryId)";                               

           SqlParameter[] para = {
                                      new SqlParameter("title", b.Title),
                                      new SqlParameter("author", b.Author),
                                      new SqlParameter("publisherId", b.PublisherId),
                                      new SqlParameter("publishDate", b.PublishDate),
                                      new SqlParameter("isbn", b.ISBN),
                                      new SqlParameter("unitPrice", b.UnitPrice),
                                      new SqlParameter("contentDescrption", b.ContentDescription),
                                      new SqlParameter("tOC", b.TOC),
                                      new SqlParameter("categoryId", b.CategoryId),
                                  };
           
           return ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, para) == 1; 
       }

       
       public bool S_Delete(int id)
       {
           string sql = "delete from dbo.Books where Id = @id";
           SqlParameter[] para = {
                                     new SqlParameter("id", id) 
                                 };
           
           return ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, para) == 1;
        }

       public bool S_Update(BookInfo b)
        {
            string sql = "UPDATE dbo.Books " +
                "SET " +
                    "Title = @title, " + //FK
                    "Author = @author, " + //FK
                    "PublisherId = @publisherId, " +
                    "PublishDate = @publishDate, " +
                    "ISBN = @isbn, " +
                    "Unitprice = @unitprice, " +
                    "ContentDescription = @Pcontentdescription, " +
                    "TOC = @toc, " +
                    "CategoryId = @categoryid, " +
                    "WHERE Id = @Id";
            SqlParameter[] para = new SqlParameter[]
			{
				new SqlParameter("@title", b.Title),
				new SqlParameter("@author", b.Author), 
				new SqlParameter("@publisherId", b.PublisherId), 
				new SqlParameter("@publishDate", b.PublishDate),
				new SqlParameter("@isbn", b.ISBN),
				new SqlParameter("@unitprice", b.UnitPrice),
				new SqlParameter("@contentdescription", b.ContentDescription),
				new SqlParameter("@toc", b.TOC),
				new SqlParameter("@categoryidail", b.CategoryId),
                new SqlParameter("@Id", b.Id),
			};
            return ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, para) == 1;
        }

       public BookInfo SearchById(int id)
       { 
            BookInfo b = new BookInfo(); ;
            string sql = "select * from dbo.Books where Id = @id";
            SqlParameter para = new SqlParameter("id", id);
            using (SqlDataReader reader = ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql, para))
            {
                if (reader.Read())
                {
                    b.Id = (int)reader["Id"];
                    b.Title = (string)reader["Title"];
                    b.Author = (string)reader["Author"];
                    b.PublisherId = (int)reader["PublisherId"];
                    b.PublishDate = reader["PublishDate"].ToString();
                    b.ISBN = (string)reader["ISBN"];
                    b.UnitPrice = (double)reader["UnitPrice"];
                    b.ContentDescription = (string)reader["UnitPrice"];
                    b.TOC = (string)reader["TOC"];
                    b.CategoryId = (int)reader["CategoryId"];
                    b.Clicks = (int)reader["Clicks"];

                    reader.Close();
                }
            }
            return b;
       }

       public List<BookInfo> GetBookList(int cateId)
       {
           List<BookInfo> list = new List<BookInfo>();

           string sql = "select * from dbo.Books where CategoryId = @cateid";
           SqlParameter[] para = {
                                      new SqlParameter("cateid", cateId) 
                                 };
           DataTable dt = ExecuteDataset(ConnectionString, CommandType.Text, sql, para).Tables[0];

           if(dt != null)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   BookInfo book = new BookInfo();

                   book.Id = (int)dt.Rows[i]["Id"];
                   book.Title = dt.Rows[i]["Title"].ToString();
                   book.Author = dt.Rows[i]["Author"].ToString();
                   book.PublisherId = (int)dt.Rows[i]["PublisherId"];
                   book.PublishDate = dt.Rows[i]["PublishDate"].ToString();
                   book.ISBN = dt.Rows[i]["ISBN"].ToString();
                   book.UnitPrice = Convert.ToDouble(dt.Rows[i]["UnitPrice"]);
                   book.ContentDescription = dt.Rows[i]["ContentDescription"].ToString();
                   book.TOC = dt.Rows[i]["TOC"].ToString();
                   book.CategoryId = (int)dt.Rows[i]["CategoryId"];
                   book.Clicks = (int)dt.Rows[i]["Clicks"];

                   list.Add(book);
               }
           }

           return list;
       }


       #region

 
 
       #endregion



    }
}











