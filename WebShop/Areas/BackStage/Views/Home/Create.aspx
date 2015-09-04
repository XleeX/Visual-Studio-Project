<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/BackStage/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<BookShopEntity.BookInfo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>
    <script src="../../../../Script/Time.js"></script>
<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>BookInfo</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Title) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Title) %>
            <%: Html.ValidationMessageFor(model => model.Title) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Author) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Author) %>
            <%: Html.ValidationMessageFor(model => model.Author) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PublisherId) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PublisherId) %>
            <%: Html.ValidationMessageFor(model => model.PublisherId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PublishDate) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.PublishDate, new { onclick = "fPopCalendar(event, this, this)", onfocus = "this.select()" })%>
            <%: Html.ValidationMessageFor(model => model.PublishDate) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ISBN) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ISBN) %>
            <%: Html.ValidationMessageFor(model => model.ISBN) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.UnitPrice) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.UnitPrice) %>
            <%: Html.ValidationMessageFor(model => model.UnitPrice) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ContentDescription) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ContentDescription) %>
            <%: Html.ValidationMessageFor(model => model.ContentDescription) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TOC) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TOC) %>
            <%: Html.ValidationMessageFor(model => model.TOC) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CategoryId) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CategoryId) %>
            <%: Html.ValidationMessageFor(model => model.CategoryId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Clicks) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Clicks) %>
            <%: Html.ValidationMessageFor(model => model.Clicks) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
