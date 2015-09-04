using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShopManager;
using BookShopEntity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        private UserManager um = new UserManager();
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// log in
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="upwd"></param>
        /// <returns></returns>
        public ActionResult Login(string uname,  string upwd)
        {
            
            if (um.CheckAccount(uname, upwd))
            {
                Session[uname] = uname;
                Session.Timeout = 30;
                return RedirectToAction("index", "main");
            }
            else
                return RedirectToAction("Login", "account");
        }

        public ActionResult Logout()
        {
            Session["uname"] = null;
            return RedirectToAction("index","main");
        }
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(UserInfo info, string tempcode)
        {
            if (um.SearchById(info.LoginId).LoginId == null)
            {
                if (tempcode == TempData["SecurityCode"])
                {
                    um.Add(info);
                    return RedirectToAction("message");
                }
                else
                    return JavaScript("alert('验证码错误！')");
            }
            else
            {
                return Content("用户名已被注册") ;
            }
        }

        public ActionResult Message()
        {
            return View();
        }


        #region  生成验证码图片
        //[OutputCache(Location = OutputCacheLocation.None, Duration = 0, NoStore = false)]

        private string code;
        public ActionResult SecurityCode()
        {
            string oldcode = TempData["SecurityCode"] as string;
            code = CreateRandomCode(5);
            TempData["SecurityCode"] = code;
            return File(CreateValidateGraphic(code), "image/Jpeg");
        }

        /// <summary>
        /// 生成随机的字符串
        /// </summary>
        private string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(35);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }
        /// <summary>
        /// 创建验证码的图片
        /// </summary>
        public byte[] CreateValidateGraphic(string validateCode)
        {
            Bitmap image = new Bitmap((int)Math.Ceiling(validateCode.Length * 16.0), 27);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器
                Random random = new Random();
                //清空图片背景色
                g.Clear(Color.White);
                //画图片的干扰线
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }
                Font font = new Font("Arial", 13, (FontStyle.Bold | FontStyle.Italic));
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height),
                 Color.Blue, Color.DarkRed, 1.2f, true);
                g.DrawString(validateCode, font, brush, 3, 2);
                //画图片的前景干扰点
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }
                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                //保存图片数据
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);
                //输出图片流
                return stream.ToArray();
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }
        #endregion

    }
}
