using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace BookShopEntity
{
    public class UserInfo
    {
        public int Id { set; get; }


        [DisplayName("登陆账号")]
       // [Required(ErroMessage = "{0}必填")]
        public string LoginId { set; get; }

        [DisplayName("登陆密码")]
        public string LoginPwd { set; get; }

        [DisplayName("确认密码")]
        //[Compare("LoginPwd", ErrorMessage = "{0}和{1}必须保持一致")]
        public string PasswordConfirm { get; set; }

        [DisplayName("用户名称")]
        public string UserName { set; get; }

        [DisplayName("地址")]
        public string Address { set; get; }

        [DisplayName("电话")]
        public string Phone { set; get; }

        [DisplayName("邮箱地址")]
        public string Mail { set; get; }
        public int UserRoleId { set; get; }
        public int UserStateId { set; get; }


    }
}
