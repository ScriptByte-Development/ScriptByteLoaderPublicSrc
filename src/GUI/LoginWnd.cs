using ScriptByteLoader.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ScriptByteLoader.Handler.Auth;
using static ScriptByteLoader.Handler.Security;

namespace ScriptByteLoader.GUI
{
    public partial class LoginWnd : Form
    {
        public LoginWnd()
        {
            InitializeComponent();
        }

        private void LoginWnd_Load(object sender, EventArgs e)
        {
            CheckKillSwitch();
            CheckForUpdate();
        }


        private void passwordtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginFunc();
            }
        }

        private void usernametextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginFunc();
            }
        }
