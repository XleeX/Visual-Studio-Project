<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    洋哥书店
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <div>
        <!--middle content-->
    <div id="content">
    	<div id="magic"><img src="../../Images/a_b_02.jpg" alt="幻灯图片" width="480" height="200" /></div>
        <div id="a_b_02">
        	<a href="#">电子词典专柜上线</a>
            <a href="#">Lucy陪你说真人口语英语对译软件</a>
            <a href="#" class="red">哇~这东西真便宜，大家快来抢啊！</a>
        </div>
        <!--comment books start-->
        <div id="comment_book">
        	<ul>             
            	<li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
                <li><a href="#"><img src="../../Images/book_01.gif" alt="" /></a><a href="#">中级口译试题解析</a></li>
            </ul>
        </div>
        <!--comment books end-->
    </div>
    
    <!--sidebar content-->
    <div id="sidebar">
        <ul id="notice">
            <li><a href="#">国庆期间货物延期配送公告</a></li>
            <li><a href="#">英语高级口语资格考试</a></li>
            <li><a href="#">英语高级口语资格考试</a></li>
            <li><a href="#">英语高级口语资格考试</a></li>
      </ul>
        <div id="order_find">
        	<form action="" method="post" target="_blank">
           	  <label>订单号：</label><input type="text" id="keyword" class="order_key" />
                <input type="submit" id="s_submit" class="order_sub" value="查询状态" />
            </form>
        </div>
        <div class="service">
        	<p><a href="#"><img src="../../Images/QQ_01.gif" /></a>
                <a href="#"><img src="../../Images/QQ_02.gif" /></a>
                <a href="#"><img src="../../Images/QQ_02.gif" /></a></p>
            <p><a href="#"><img src="../../Images/taobao_01.gif" /></a>
            	<a href="#"><img src="../../Images/taobao_02.gif" /></a></p>
        </div>
        <!--hot books start-->
        <div class="sidedt hots">
        	<h1>热销排行</h1>
            <ul>
            	<li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
            </ul>
        </div>
        <!--hot books end-->
        <!--laster books start-->
        <div class="sidedt laster">
        	<h1>热销排行</h1>
            <ul>
            	<li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
                <li><a href="#">英语高级口语资格考试</a></li>
            </ul>
        </div>
        <!--laster books end-->
    </div>
</div>

</asp:Content>
