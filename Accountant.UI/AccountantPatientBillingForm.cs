using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI.Accountant.UI
{
    public partial class AccountantPatientBillingForm : MetroFramework.Forms.MetroForm
    {
        public AccountantPatientBillingForm()
        {
            InitializeComponent();
            hmsDataContext dbcon = new hmsDataContext();
            Invoice inv = dbcon.Invoices.SingleOrDefault(x => x.InvoicePatientName == Accountant.UC.UserControlAccountantCreateInvoice.invoice);
            metroLabel31.Text = Convert.ToString(inv.InvoiceId);
            metroLabel30.Text = inv.InvoiceDate;
            metroLabel29.Text = Accountant.UC.UserControlAccountantCreateInvoice.invoice;
            metroLabel28.Text = inv.InvoiceDoctorName;
            metroLabel27.Text = inv.InvoiceDateOfAdmission;
            metroLabel26.Text = inv.InvoiceDateOfRelease;
            metroLabel25.Text = inv.InvoiceAdmissionCharge;
            metroLabel24.Text = inv.InvoiceServiceCharge;
            metroLabel23.Text = inv.InvoiceDoctorFees;
            metroLabel22.Text = inv.InvoiceRoomNo;
            metroLabel21.Text = inv.InvoiceRoomChargePerDay;
            metroLabel20.Text = inv.InvoiceRoomNoOfDays;
            metroLabel19.Text = inv.InvoiceVat;
            metroLabel18.Text = inv.InvoiceDiscount;
            metroLabel17.Text = inv.InvoiceTotalBill;
        }

        private void AccountantPatientBillingForm_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel23_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel24_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel26_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel27_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel29_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel30_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel31_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
