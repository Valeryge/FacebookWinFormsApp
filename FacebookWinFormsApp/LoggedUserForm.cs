using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LoggedUserForm : Form
    {
        private readonly LoginResult k_LoginResult;
        private readonly User k_LoggedUser;
        public LoggedUserForm(LoginResult i_LoginResult)
        {
            k_LoginResult = i_LoginResult;
            k_LoggedUser = i_LoginResult.LoggedInUser;
            this.InitializeComponent();
            
        }
    }
}
