<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="Storage_Management.About" %>
 <asp:Content ID="Content1" ContentPlaceHolderID="homePlaceholder_1" runat="server">
    <h1 style="color:#FF5722; margin-bottom:20px">About One's & Zero's</h1>
     <asp:Image ID="imgBuilding" runat="server" ImageUrl="~/Images/Binary_img.jpg" 
                width="100%" Height="150px"/>
    <hr style="margin-bottom:20px; border:White" />
    <p>
         Lorem Ipsum is simply dummy text 
         of the printing and typesetting industry.
         Lorem Ipsum has been the industry's standard dummy 
         text ever since the 1500s, when an unknown printer 
         took a galley of type and scrambled it to make a type specimen book. 
         It has survived not only five centuries, but also the leap into electronic typesetting,
         remaining essentially unchanged. It was popularised in the 1960s with the release of
         Letraset sheets containing Lorem Ipsum passages, and more recently with desktop 
         publishing software like Aldus PageMaker including versions of Lorem Ipsum.
    </p>
    <br />
    <p>
         Lorem Ipsum is simply dummy text 
         of the printing and typesetting industry.
         Lorem Ipsum has been the industry's standard dummy 
         text ever since the 1500s, when an unknown printer 
         took a galley of type and scrambled it to make a type specimen book. 
    </p>
    <br />
    <p>
         Lorem Ipsum has been the industry's standard dummy 
         text ever since the 1500s, when an unknown printer 
         took a galley of type and scrambled it to make a type specimen book. 
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="sidePlaceholder" runat="server">
    <h2 style=" color:#F44336; margin-bottom:10px">Executive Officers:</h2>
    <p style="color:#FF5722">Watlinton Moholo</p>
        CEO
        <br />
         <br />
    <p style="color:#FF5722">Shahbaaz Sheikh</p>
        CFO
        <br />
        <br />
    <p style="color:#FF5722">Alrick Visagie</p>
        Chief Legal Officer
        <br />
        <br />
    <p style="color:#FF5722">Lovias Betana</p>
        President
        <br />
        <br />
</asp:Content>

