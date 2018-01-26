using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls.Dialogs;
using StorageUnitManagementSystem.BL;
using StorageUnitManagementSystem.BL.Classes;

namespace StorageUnitManagementSystem
{
    /// <summary>
    /// Interaction logic for PopUp.xaml
    /// </summary>
    public partial class PopUp 
    {
        private LUBL _lubl;
        public PopUp()
        {
            InitializeComponent();
            _lubl = new LUBL("LeaseUnitsSQLiteProvider");
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            
            int rc = 0;
            LeaseUnits leaseUnit = new LeaseUnits();
            StorageUnit unit = new StorageUnit();
            List<LeaseUnits> list = _lubl.SelectAll();
            //foreach (LeaseUnits leaseUnits in list)
            //{
            //    if (leaseUnits.LeaseID.Equals(LeaseIDTxtBox.Text))
            //    {
            //        unitID = leaseUnits.StorageUnit.UnitId;
            //        unitClass = leaseUnits.StorageUnit.UnitClassification;
            //        unitPrice = leaseUnits.StorageUnit.UnitPrice;
            //    }
            //}
          
            LeaseIDTxtBox.IsEnabled = false;
            ClientIDTxtBox.IsEnabled = false;
            leaseUnit.LeaseID = LeaseIDTxtBox.Text;
            leaseUnit.Client.idNumber = ClientIDTxtBox.Text;
            leaseUnit.Client.FirstName = LeaseNameTxtBox.Text;
            leaseUnit.Client.LastName = LeaseSurnameTxtBox.Text;
            leaseUnit.AmountOwed = LeaseOwedTxtBox.Text;
            leaseUnit.AmountPaid = LeasePaidTxtBox.Text;
            leaseUnit.Paid = Convert.ToBoolean(1);
            leaseUnit.DateOfPayment = LeaseDateTxtBox.SelectedDate.Value.Date.ToShortDateString();
            leaseUnit.MonthsPaid = MonthspaidTxtBox.Text;
            LeaseUnits leaseUnit_UnitInfo = new LeaseUnits();
            _lubl.SelectLeaseUnit(leaseUnit.LeaseID, ref leaseUnit_UnitInfo);
            leaseUnit.StorageUnit.UnitId = leaseUnit_UnitInfo.StorageUnit.UnitId;
            leaseUnit.StorageUnit.UnitClassification = leaseUnit_UnitInfo.StorageUnit.UnitClassification;
            leaseUnit.StorageUnit.UnitPrice = leaseUnit_UnitInfo.StorageUnit.UnitPrice;

            if (int.Parse(LeaseDateTxtBox.SelectedDate.Value.Date.ToShortDateString().Substring(5,2)) > 1)
            {
                leaseUnit.TypeOfPayment = "Advance";
                unit.UnitInAdvance = Convert.ToBoolean(1);
            }
            else if (int.Parse(LeaseDateTxtBox.SelectedDate.Value.Date.ToShortDateString().Substring(5, 2)) == 1)
            {
                leaseUnit.TypeOfPayment = "Deposit";
            }
            else
            {
                leaseUnit.TypeOfPayment = "Deposit";
            }
            if (leaseUnit.Paid == Convert.ToBoolean(1))
            {
                leaseUnit.Status = "Up To Date";
                unit.UnitUpToDate = Convert.ToBoolean(1);
            }
            rc = _lubl.UpdatePopUp(leaseUnit);
            if (rc == 0)
            {
                this.ShowMessageAsync("Updated", "Successfully Updated!");
            }
            else
            {
                this.ShowMessageAsync("Updated Failed", "Update Did Not Perform!");
            }

        }
        private void UIElement_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }

        // Use the DataObject.Pasting Handler 
        private void TextBoxPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void Terminate_Click(object sender, RoutedEventArgs e)
        {
            List<LeaseUnits> leaseUnits = _lubl.SelectAll();
            foreach (LeaseUnits leaseUnit in leaseUnits)
            {
                if (leaseUnit.Client.idNumber.Equals(LeaseIDTxtBox.Text))
                {
                    leaseUnit.Refund = double.Parse(leaseUnit.AmountOwed);
                    _lubl.Insert(leaseUnit);
                    break;
                }
            }
            this.ShowMessageAsync("Client Terminated", "Refund will be awarded to client");
        }
    }
}
