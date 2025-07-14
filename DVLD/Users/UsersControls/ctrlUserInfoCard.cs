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

namespace DVLD.Controls
{
    public partial class ctrlUserInfoCard : UserControl
    {
        private int _UserID;
        public int UserID { get { return _UserID; } }

        clsUser _User;
        public clsUser UserInfo { get { return _User; } }


        public ctrlUserInfoCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.FindByUserID(UserID);

            if(_User == null)
            {
                MessageBox.Show("No User With UserID = " + UserID.ToString());
                return;
            }

            _UserID = UserID;

            lbUserIDValue.Text = UserID.ToString();
            lbUsernameValue.Text = _User.Username.ToString();

            if (_User.IsActive)
                lbIsActiveValue.Text = "Yes";
            else
                lbIsActiveValue.Text = "No";

            ucPersonCardInfo1.LoadPersonInfo(_User.PersonID);
        }

    }
}
