using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        const int ProductCode = 1;

        private void frmAbout_Load(object sender, EventArgs e)
        {
            try
            {
                lblProductID.Text = ComputerInfo.GetComputerId();
                KeyManager km = new KeyManager(lblProductID.Text);
                LicenseInfo lic = new LicenseInfo();
                int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
                string productKey = lic.ProductKey;
                if (km.ValidKey(ref productKey))
                {
                    KeyValuesClass kv = new KeyValuesClass();
                    if (km.DisassembleKey(productKey, ref kv))
                    {
                        lblProductName.Text = "Orcun";
                        lblProductKey.Text = productKey;
                        if (kv.Type == LicenseType.TRIAL)
                        {
                            lblLicenceType.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);

                        }
                        else
                        {
                            lblLicenceType.Text = "Full";
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           

        }
    }
}
