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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        const int ProductCode = 1;
        private void btnOk_Click(object sender, EventArgs e)
        {
            KeyManager keyManager = new KeyManager(textProductID.Text);
            string productKey = textProductKey.Text;
            if (keyManager.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (keyManager.DisassembleKey(productKey,ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "Orcun";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    keyManager.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("You have been successfully registered!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Your product key is invalid.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                textProductID.Text = ComputerInfo.GetComputerId();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
