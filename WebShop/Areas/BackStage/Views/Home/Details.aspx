<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/BackStage/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<BookShopEntity.BookInfo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>BookInfo</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Title) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Title) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Author) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Author) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.PublisherId) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PublisherId) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.PublishDate) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PublishDate) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.ISBN) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ISBN) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.UnitPrice) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.UnitPrice) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.ContentDescription) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ContentDescription) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.TOC) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TOC) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.CategoryId) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CategoryId) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Clicks) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Clicks) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.Id }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
