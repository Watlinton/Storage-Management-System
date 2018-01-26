<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Storage_Management.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="homePlaceholder_1" runat="server">

    <h2 style=" color:#000000; margin-bottom:8px">Storage Unit Management</h2>
     <hr style=" background:#FF5722; border:1px solid #FF5722; margin-bottom:5px" />
        <br />
        <h1 style=" color:#F44336">Purpose</h1>
        <br />
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
                <h1 style=" color:#F44336">Prerequisites</h1>
                <br />
                <p>
                Lorem Ipsum is simply dummy text 
                of the printing and typesetting industry.
                Lorem Ipsum has been the industry's standard dummy 
                text ever since the 1500s, when an unknown printer 
                took a galley of type and scrambled it to make a type specimen book. 
               </p>
              <br />
                <h1 style=" color:#F44336">Features</h1>
                <br />
                <p>
                Lorem Ipsum is simply dummy text 
                of the printing and typesetting industry.
                Lorem Ipsum has been the industry's standard dummy 
                text ever since the 1500s, when an unknown printer 
                took a galley of type and scrambled it to make a type specimen book. 
                </p>
              
                   <ul style=" padding:20px">
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                        <li>Create New stuff using lorem ipsome</li>
                    </ul>
                    <hr style=" background:#FF5722; border:1px solid #FF5722; margin-bottom:5px" />
                    <asp:Image ID="imgFeedBack" runat="server" 
                        ImageUrl="~/Images/feedback.png" Height="30px" Width="30px" ImageAlign="AbsMiddle" />
                    <asp:Label ID="lblfeedback" runat="server" Text="Feedback"  ></asp:Label>
                    <br />
                    <br />
                    <h3>Was this page helpful?</h3>
                    <br />
                    <asp:Button ID="btnYes" runat="server" Text="Yes" 
                       BackColor="#FF5722" BorderColor="#FF5722" 
                       Width="70px" Height="30px"  ForeColor="White"/>
                    <asp:Button ID="btnNo" runat="server" Text="No" 
                       BackColor="#FF5722" BorderColor="#FF5722" 
                      Width="70px" Height="30px" ForeColor="White"/>
                    
                    <textarea id="txtAreaFeedBack" cols="20" rows="2" 
                        style=" display:block; 
                        width:350px; 
                        height:100px;Margin-top:10px">
                    </textarea>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit"
                            BackColor="#FF5722" BorderColor="#FF5722" 
                           Width="70px" Height="30px"  ForeColor="White" style="Margin-top:5px"/>

        
                  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="sidePlaceholder" runat="server">
</asp:Content>

