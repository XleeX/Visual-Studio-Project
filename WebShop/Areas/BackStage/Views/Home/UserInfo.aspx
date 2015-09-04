<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/BackStage/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<BookShopEntity.UserInfo>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    UserInfo
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>UserInfo</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.LoginId) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.LoginPwd) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.PasswordConfirm) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.UserName) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Address) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Phone) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Mail) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.UserRoleId) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.UserStateId) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.LoginId) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.LoginPwd) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.PasswordConfirm) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.UserName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Address) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Phone) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Mail) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.UserRoleId) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.UserStateId) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.Id }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.Id }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.Id }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
