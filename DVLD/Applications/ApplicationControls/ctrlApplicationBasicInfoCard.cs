using DVLD.People;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.ApplicationControls
{
    public partial class ctrlApplicationBasicInfoCard : UserControl
    {
        private int _ApplicationID = -1;
        private clsApplication _ApplicationInfo;
        
        public int ApplicationID { get { return _ApplicationID; } }
        public clsApplication ApplicationInfo { get { return _ApplicationInfo; } }


        public ctrlApplicationBasicInfoCard()
        {
            InitializeComponent();
        }


        public void LoadBasicApplicationInfo(int ApplicationID)
        {
            _ApplicationInfo = clsApplication.FindBaseApplication(ApplicationID);

            if(_ApplicationInfo == null)
            {
                MessageBox.Show($"There's no application with applicationID {ApplicationID}", "NULL");
                return;
            }

            _ApplicationID = ApplicationID;

            lbApplicationIDValue.Text = _ApplicationID.ToString();
            lbApplicationStatusValue.Text = _ApplicationInfo.StatusText;
            lbApplicationFeesValue.Text = Convert.ToDouble(_ApplicationInfo.PaidFees).ToString();
            lbApplicationTypeValue.Text = _ApplicationInfo.ApplicationTypeInfo.ApplicationTypeName;
            lbApplicantPersonValue.Text = _ApplicationInfo.ApplicantPersonInfo.FullName;
            lbApplicationDateValue.Text = _ApplicationInfo.ApplicationDate.ToString("dd/MM/yyyy");
            lbApplicationStatusDateValue.Text = _ApplicationInfo.LastStatusDate.ToString("dd/MM/yyyy");
            lbCreatedByValue.Text = _ApplicationInfo.CreatedByUserInfo.Username;
        }


        private void linkLabelShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails(_ApplicationInfo.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
