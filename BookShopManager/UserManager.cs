using BookShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopService;


namespace BookShopManager
{
    public class UserManager 
    {
        private UserInfoService _uis = new UserInfoService();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool Add(UserInfo u)

        {
            return _uis.S_Add(u);            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return _uis.S_Delete(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool Update(UserInfo u)
        {
            return _uis.S_Update(u);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UserInfo SearchById(string loginid)
        {
            return _uis.S_SearchById(loginid);
        }

        public bool CheckAccount(string loginid, string pwd)
        {
            UserInfo u = SearchById(loginid);

            return u.LoginPwd == pwd;
        }
    }
}






