using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Storage_Management
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void classA_Click(object sender, ImageClickEventArgs e)
        {
            classB.BorderStyle = BorderStyle.NotSet;
            classB.BorderColor = System.Drawing.Color.Empty;
            classC.BorderStyle = BorderStyle.NotSet;
            classC.BorderColor = System.Drawing.Color.Empty;
            classD.BorderStyle = BorderStyle.NotSet;
            classD.BorderColor = System.Drawing.Color.Empty;
            classE.BorderStyle = BorderStyle.NotSet;
            classE.BorderColor = System.Drawing.Color.Empty;
            classF.BorderStyle = BorderStyle.NotSet;
            classF.BorderColor = System.Drawing.Color.Empty;
            classA.BorderStyle = BorderStyle.Solid;
            classA.BorderColor = System.Drawing.Color.OrangeRed;
            mainImg.ImageUrl = mainImg.ResolveUrl("~/Images/3m_3m_3m_img.jpg");
            lblUnitHeader.Text = " 3m x 3m x 3m Storage Unit";
            lblUnitClass.Text = "Class A";
            lblUnitDimensions.Text = "3m(L) x 3m(W) x 3m(H)";
            lblUnitPrice.Text = "Unit Price: R 650.00 p/m";
            lblTotalUnits.Text = "Total Units: 45 Units";
            //lblRemainingUnits.Text = "";
        }
        protected void classB_Click(object sender, ImageClickEventArgs e)
        {
            classA.BorderStyle = BorderStyle.NotSet;
            classA.BorderColor = System.Drawing.Color.Empty;
            classC.BorderStyle = BorderStyle.NotSet;
            classC.BorderColor = System.Drawing.Color.Empty;
            classD.BorderStyle = BorderStyle.NotSet;
            classD.BorderColor = System.Drawing.Color.Empty;
            classE.BorderStyle = BorderStyle.NotSet;
            classE.BorderColor = System.Drawing.Color.Empty;
            classF.BorderStyle = BorderStyle.NotSet;
            classF.BorderColor = System.Drawing.Color.Empty;
            classB.BorderStyle = BorderStyle.Solid;
            classB.BorderColor = System.Drawing.Color.OrangeRed;
            mainImg.ImageUrl = mainImg.ResolveUrl("~/Images/3m_1.5m.jpg");
            lblUnitHeader.Text = " 3m x 5m x 3m Storage Unit";
            lblUnitClass.Text = "Class B";
            lblUnitDimensions.Text = "3m(L) x 5m(W) x 3m(H)";
            lblUnitPrice.Text = "Unit Price: R 750.00 p/m";
            lblTotalUnits.Text = "Total Units: 20 Units";
            //lblRemainingUnits.Text = "";
        }
        protected void classC_Click(object sender, ImageClickEventArgs e)
        {
            classB.BorderStyle = BorderStyle.NotSet;
            classB.BorderColor = System.Drawing.Color.Empty;
            classA.BorderStyle = BorderStyle.NotSet;
            classA.BorderColor = System.Drawing.Color.Empty;
            classD.BorderStyle = BorderStyle.NotSet;
            classD.BorderColor = System.Drawing.Color.Empty;
            classE.BorderStyle = BorderStyle.NotSet;
            classE.BorderColor = System.Drawing.Color.Empty;
            classF.BorderStyle = BorderStyle.NotSet;
            classF.BorderColor = System.Drawing.Color.Empty;
            classC.BorderStyle = BorderStyle.Solid;
            classC.BorderColor = System.Drawing.Color.OrangeRed;
            mainImg.ImageUrl = mainImg.ResolveUrl("~/Images/3m_2m.jpg");
            lblUnitHeader.Text = " 3m x 5m x 5m Storage Unit";
            lblUnitClass.Text = "Class C";
            lblUnitDimensions.Text = "3m(L) x 5m(W) x 5m(H)";
            lblUnitPrice.Text = "Unit Price: R 950.00 p/m";
            lblTotalUnits.Text = "Total Units: 15 Units";
            //lblRemainingUnits.Text = "";
        }
        protected void classD_Click(object sender, ImageClickEventArgs e)
        {
            classB.BorderStyle = BorderStyle.NotSet;
            classB.BorderColor = System.Drawing.Color.Empty;
            classC.BorderStyle = BorderStyle.NotSet;
            classC.BorderColor = System.Drawing.Color.Empty;
            classA.BorderStyle = BorderStyle.NotSet;
            classA.BorderColor = System.Drawing.Color.Empty;
            classE.BorderStyle = BorderStyle.NotSet;
            classE.BorderColor = System.Drawing.Color.Empty;
            classF.BorderStyle = BorderStyle.NotSet;
            classF.BorderColor = System.Drawing.Color.Empty;
            classD.BorderStyle = BorderStyle.Solid;
            classD.BorderColor = System.Drawing.Color.OrangeRed;
            mainImg.ImageUrl = mainImg.ResolveUrl("~/Images/3m_4m.jpg");
            lblUnitHeader.Text = " 3m x 7m x 3m Storage Unit";
            lblUnitClass.Text = "Class D";
            lblUnitDimensions.Text = "3m(L) x 7m(W) x 3m(H)";
            lblUnitPrice.Text = "Unit Price: R 1,150.00 p/m";
            lblTotalUnits.Text = "Total Units: 10 Units";
            //lblRemainingUnits.Text = "";
        }

        protected void classE_Click(object sender, ImageClickEventArgs e)
        {
            classB.BorderStyle = BorderStyle.NotSet;
            classB.BorderColor = System.Drawing.Color.Empty;
            classC.BorderStyle = BorderStyle.NotSet;
            classC.BorderColor = System.Drawing.Color.Empty;
            classD.BorderStyle = BorderStyle.NotSet;
            classD.BorderColor = System.Drawing.Color.Empty;
            classA.BorderStyle = BorderStyle.NotSet;
            classA.BorderColor = System.Drawing.Color.Empty;
            classF.BorderStyle = BorderStyle.NotSet;
            classF.BorderColor = System.Drawing.Color.Empty;
            classE.BorderStyle = BorderStyle.Solid;
            classE.BorderColor = System.Drawing.Color.OrangeRed;
            mainImg.ImageUrl = mainImg.ResolveUrl("~/Images/3m_6m.jpg");
            lblUnitHeader.Text = " 3m x 7m x 5m Storage Unit";
            lblUnitClass.Text = "Class E";
            lblUnitDimensions.Text = "3m(L) x 7m(W) x 5m(H)";
            lblUnitPrice.Text = "Unit Price: R 1,250.00 p/m";
            lblTotalUnits.Text = "Total Units: 10 Units";
            //lblRemainingUnits.Text = "";
        }

        protected void classF_Click(object sender, ImageClickEventArgs e)
        {
            classB.BorderStyle = BorderStyle.NotSet;
            classB.BorderColor = System.Drawing.Color.Empty;
            classC.BorderStyle = BorderStyle.NotSet;
            classC.BorderColor = System.Drawing.Color.Empty;
            classD.BorderStyle = BorderStyle.NotSet;
            classD.BorderColor = System.Drawing.Color.Empty;
            classE.BorderStyle = BorderStyle.NotSet;
            classE.BorderColor = System.Drawing.Color.Empty;
            classA.BorderStyle = BorderStyle.NotSet;
            classA.BorderColor = System.Drawing.Color.Empty;
            classF.BorderStyle = BorderStyle.Solid;
            classF.BorderColor = System.Drawing.Color.OrangeRed;
            mainImg.ImageUrl = mainImg.ResolveUrl("~/Images/3m_9m.jpg");
            lblUnitHeader.Text = " 5m x 6m x 4m Storage Unit";
            lblUnitClass.Text = "Class F";
            lblUnitDimensions.Text = "5m(L) x 6m(W) x 4m(H)";
            lblUnitPrice.Text = "Unit Price: R 1,400.00 p/m";
            lblTotalUnits.Text = "Total Units: 5 Units";
            //lblRemainingUnits.Text = "";
        }
    }
}