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
    public partial class frmGenerate : Form
    {
        public frmGenerate()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            KeyManager keyManager = new KeyManager(textProductID.Text);
            KeyValuesClass kv;
            string productKey = String.Empty;
            if (comboBoxLicenceType.SelectedIndex == 0)
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1
                    
                };
                if (!keyManager.GenerateKey(kv,ref productKey))
                {
                    textProductKey.Text = "error";
                }
            }
            else
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,
                    Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(textExperienceDays.Text))

                };
                if (!keyManager.GenerateKey(kv, ref productKey))
                {
                    textProductKey.Text = "error";
                }
            }
            textProductKey.Text = productKey;



        }

        const int ProductCode = 1;
        private void frmGenerate_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxLicenceType.SelectedIndex = 0;
                textProductID.Text = ComputerInfo.GetComputerId();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
