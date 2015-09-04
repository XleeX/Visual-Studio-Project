using BookShop.DAL;
using BookShopEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopService
{
    public class UserInfoService : SqlHelper
    {
        /// <summary>
        ///Add a new user
        /// </summary>
        /// <param name="u">UserInfo</param>
        /// <returns>bool</returns>
        public bool S_Add(UserInfo u) 
        {   
            string sql = "insert into dbo.Users (LoginId, LoginPwd, UserName, Address, Phone, Mail, UserRoleId, UserStateId)"
                                        +"values(@loginid, @loginpwd, @username, @address, @phone, @mail, @userroleid, @userstateid)";
            SqlParameter[] para = {
                                   new SqlParameter("loginid", u.LoginId),
                                   new SqlParameter("loginpwd", u.LoginPwd),
                                   new SqlParameter("name", u.UserName),
                                   new SqlParameter("address", u.Address),
                                   new SqlParameter("phone", u.Phone),
                                   new SqlParameter("mail", u.Mail),
                                   new SqlParameter("userroleid", u.UserRoleId),
                                   new SqlParameter("userstateid", u.UserStateId),
                                  };
             return ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, para) == 1;

        }
        /// <summary>
        /// Delete user by Login ID 
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
        public bool S_Delete(int id)
        {
            string sql = "delete from dbo.Users where Id = @id";
            SqlParameter[] para = {
                                   new SqlParameter("id", id)
                                  };
            return ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, para) == 1;

        }
        /// <summary>
        /// Update user information
        /// </summary>
        /// <param name="u">UserInfo</param>
        /// <returns>bool</returns>
        public bool S_Update(UserInfo u)
        {
            string sql = "UPDATE dbo.Users " +
               "SET " +
                   "UserStateId = @UserStateId, " + //FK
                   "UserRoleId = @UserRoleId, " + //FK
                   "LoginId = @LoginId, " +
                   "LoginPwd = @LoginPwd, " +
                   "Name = @Name, " +
                   "Address = @Address, " +
                   "Phone = @Phone, " +
                   "Mail = @Mail, " +
                   "WHERE Id = @Id";
            SqlParameter[] para = new SqlParameter[]
			{
				new SqlParameter("@Id", u.Id),
				new SqlParameter("@UserStateId", u.UserStateId), 
				new SqlParameter("@UserRoleId", u.UserRoleId), 
				new SqlParameter("@LoginId", u.LoginId),
				new SqlParameter("@LoginPwd", u.LoginPwd),
				new SqlParameter("@Name", u.UserName),
				new SqlParameter("@Address", u.Address),
				new SqlParameter("@Phone", u.Phone),
				new SqlParameter("@Mail", u.Mail),
			};
            return ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, para) == 1;
        }
        /// <summary>
        /// Search UserInfo by given Login ID
        /// </summary>
        /// <param name="loginid">int</param>
        /// <returns>UserInfo</returns>
        public UserInfo S_SearchById(string loginid)
        {
            UserInfo u = new UserInfo(); ;
            string sql = "select * from dbo.Users where LoginId = @loginid";
            SqlParameter para = new SqlParameter("loginid", loginid); 
            using(SqlDataReader reader = ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sql, para))
            {
                if(reader.Read())
                {
                    u.Id = (int)reader["Id"];
                    u.LoginId = (string)reader["LoginId"];
                    u.LoginPwd = (string)reader["LoginPwd"];
                    u.UserName = (string)reader["UserName"];
                    u.Address = (string)reader["Address"];
                    u.Phone = (string)reader["Phone"];
                    u.Mail = (string)reader["Mail"];

                    reader.Close();
                }
            }

            return u;
        }


    }
}










