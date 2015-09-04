<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
</head>
<body>
    <div>
        <form action="/account/login" method="post">
            用户名：<input type="text" name="uname" /><br />
            密码：<input type="password" name="upwd" /><br />
            <input type="submit" value="登录" />
        </form>
    </div>
</body>
</html>
