<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Storage Units.aspx.cs" Inherits="Storage_Management.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="homePlaceholder_1" runat="server">
     <asp:Image ID="mainImg" runat="server" ImageUrl="~/Images/3m_3m_3m_img.jpg" 
          Width="100%" Height="500px" />
        <br />
        <br />
    <hr style=" background:#FF5722; border:1px solid #FF5722; margin-bottom:5px" />
    <div style="display:inline-block;margin-bottom:10px;margin-top:10px">
          <div style="margin-right:1px;display:inline">
                <asp:ImageButton ID="classA" runat="server" ImageUrl="~/Images/3m_3m_3m_img.jpg" 
                    Width="100px" Height="100px" OnClick="classA_Click"/>
             
            </div>
            <div style="margin-right:1px;display:inline">
                <asp:ImageButton ID="classB" runat="server" ImageUrl="~/Images/3m_1.5m.jpg" 
                    Width="100px" Height="100px" OnClick="classB_Click"/>
            </div>
         <div style="margin-right:1px;display:inline">
                <asp:ImageButton ID="classC" runat="server" ImageUrl="~/Images/3m_2m.jpg" 
                    Width="100px" Height="100px" OnClick="classC_Click"/>
            </div>
        <div style="margin-right:1px;display:inline">
                <asp:ImageButton ID="classD" runat="server" ImageUrl="~/Images/3m_4m.jpg" 
                    Width="100px" Height="100px" OnClick="classD_Click"/>
            </div>
        <div style="margin-right:1px;display:inline">
                <asp:ImageButton ID="classE" runat="server" ImageUrl="~/Images/3m_6m.jpg" 
                    Width="100px" Height="100px" OnClick="classE_Click"/>
            </div>
        <div style="display:inline">
                <asp:ImageButton ID="classF" runat="server" ImageUrl="~/Images/3m_9m.jpg" 
                    Width="100px"  Height="100px" OnClick="classF_Click" />
            </div>
        
    </div>
    <p style="margin-bottom:10PX;color:#FF5722">&emsp;Class A&emsp;&emsp;&emsp;&emsp;Class B&emsp;&emsp;&emsp;&emsp;Class C&emsp;&emsp;&emsp;&emsp;Class D&emsp;&emsp;&emsp;Class E&emsp;&emsp;&emsp;Class F</p>
          
    <hr style=" background:#FF5722; border:1px solid #FF5722; margin-bottom:5px" />
        
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="sidePlaceholder" runat="server">
    <div style="color:#F44336;margin-bottom:10px">
         <asp:Label ID="lblUnitHeader" runat="server" Text="3m x 3m x 3m Storage Unit" Font-Size="X-Large"></asp:Label>
    </div>
    <div style="font:bold;margin-bottom:15px;margin-top:15px;color:#FF5722">
        <asp:Label ID="lblUnitClass" runat="server" Text="Class A" Font-Size="Larger"></asp:Label>
    </div>
    <p style="font:bold;margin-bottom:5px;color:darkgrey">Dimensions</p>
     <hr style=" background:#FF5722; border:1px solid #FF5722; margin-bottom:5px" />
    <div style="color:#FF5722;margin-bottom:10px">
        <asp:Label ID="lblUnitDimensions" runat="server" Text="3m(L) x 3m(W) x 3m(H)"></asp:Label>
    </div>
    <p style="color:darkgrey;margin-bottom:10px">
        Sizes are indicated as Length (L) x Width (W) x Height (H). 
        The sizes are for guide puposes only. 
        Some storage units are higher than 3 metres.
    </p>
    <div style="color:#F44336;margin-bottom:7px">
           <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price: R 650.00 p/m"></asp:Label>
    </div>
    <div style="color:#F44336;margin-bottom:7px">
           <asp:Label ID="lblTotalUnits" runat="server" Text="Total Units: 45 Units"></asp:Label>
    </div>
    <div style="color:#F44336;margin-bottom:7px">
           <asp:Label ID="lblRemainingUnits" runat="server" Text="Available Units: "></asp:Label>
    </div>

  <%--  <div style="color:#FF5722;margin-top:50px;margin-bottom:15px">
           <asp:Label ID="lblViewAllUnits" runat="server" Text="- All Units  " Font-Size="Medium"></asp:Label>
    </div>
    <div style="color:#FF5722;margin-bottom:15px">
           <asp:Label ID="lblViewAvailableUnits" runat="server" Text="- Available Units  " Font-Size="Medium"></asp:Label>
    </div>--%>
 
    
</asp:Content>

