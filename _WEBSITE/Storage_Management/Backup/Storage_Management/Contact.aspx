<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Storage_Management.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="homePlaceholder_1" runat="server">
    <form runat="server">
        <h1 >Contact US</h1>
         <hr style=" background:#FF5722; border:1px solid #FF5722; margin-bottom:5px" />
         <h2 style="color:#FF5722">Thank You For Choosing Ones's & Zero's!</h2>
         <br />
         <h2 style="color:#FF5722">Contact Us By Email</h2>
         <br />
         <p>Please complete the form below. Detailed information helps us answer you more quickly and accurately.</p>
 <table style="width: 100%;">
     <tr>
         <td>
            <div style=" display:block ; margin-bottom:5px">
            <asp:Label ID="Label1" runat="server" Text="Name" Font-Bold="True"></asp:Label>
          </div>
        
         <asp:TextBox ID="TextBox1"  runat="server" Height="30px" width="180px"></asp:TextBox>
         </td>
         <td>
             &nbsp;
         </td>
     </tr>
     <tr>
         <td>
             &nbsp;
             <div style=" display:block ; margin-bottom:5px">
                 <asp:Label ID="lblEmail" runat="server" Font-Bold="True" Text="Email"></asp:Label>
             </div>
             <asp:TextBox ID="txtBoxEmail" runat="server" width="180px" Height="30px"></asp:TextBox>
         </td>
         <td>
             &nbsp;
             <div style="display:block; margin-bottom:5px">
                 <asp:Label ID="lblPhone" runat="server" Font-Bold="True" 
                     style="margin-bottom:5px" Text="Phone Number"></asp:Label>
             </div>
               <asp:TextBox ID="txtBoxPhone" runat="server" Height="30px" width="180px"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td  colspan="2">
                 <div style="display:block; margin-bottom:5px;margin-top:5px">
                 <asp:Label ID="lblInquiry" runat="server" Font-Bold="True" 
                     style="margin-bottom:5px" Text="Nature of Iquiry"></asp:Label>
             </div>
             <textarea id="txtArea" cols="20"
                     rows="4" style="width:80%"></textarea>
                     
                     <div style=" margin-top:15px">
                        <asp:Button ID="btnContactSUbmit" runat="server" Text="Submit" 
                       BackColor="#FF5722" BorderColor="#FF5722" 
                       Width="70px" Height="30px" ForeColor="White"/>
                     </div>
              
         </td>
     </tr>
 </table>

         
 </form>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="sidePlaceholder" runat="server">
    <h2 style="color:#FF5722">Contact Us By Telephone</h2>
   <hr style=" background:#FF5722; border:1px solid #FF5722; margin-bottom:5px" />
   <br />
   <br />
   <h2 style="color:#FF5722;margin-bottom:5px">Office Hours:</h2>
   <p style="color:#F44336">Monday to Friday:</p>
        08:00 AM - 17:00 PM
        <br />
        <br />
   <p style="color:#F44336">Saturdays:</p>
        09:00 AM - 16:00 PM
         <br />
         <br />
   <p style="color:#F44336">Sundays:</p>
        09:00 AM - 14:00 PM
         <br />
         <br />
         <br />
         <br />
  <h2 style="color:#FF5722; margin-bottom:5px">New Clients</h2>  
        <p style="font-style:normal; margin-bottom:5px">051-000-0000</p>     
  <h2 style="color:#FF5722; margin-bottom:5px">Existing Clients</h2>  
        <p style="font-style:normal; margin-bottom:5px">051-111-0000</p> 
        <br />
         <hr style=" background:#FF5722; border:1px solid #FF5722; margin-bottom:5px" />
  <h2 style="color:#FF5722;margin-bottom:10px">Contact Us By Mail</h2>  
      <p> One's & Zero's
      <br />
       1 Park Road 
       <br />
       Bloemfontein
       <br />
       9301 
       <br />
       South Africa
       </p>
</asp:Content>

