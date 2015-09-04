﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<BookShopEntity.BookInfo>>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>BookInfo</title>
</head>
<body>
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
    <table>
        <tr>
            <th>
                <%: Html.DisplayNameFor(model => model.Title) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.Author) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.PublisherId) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.PublishDate) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.ISBN) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.UnitPrice) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.CategoryId) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.Clicks) %>
            </th>
            <th></th>
        </tr>
    
    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.Title) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Author) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.PublisherId) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.PublishDate) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.ISBN) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.UnitPrice) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.CategoryId) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Clicks) %>
            </td>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.Id }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.Id }) %> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.Id }) %>
            </td>
        </tr>
    <% } %>
    
    </table>
</body>
</html>
