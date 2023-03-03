using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Lab01
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler Button_Click;
    
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button_Click?.Invoke(this, e);
        }

        public void set_enable(bool enable)
        {
            if (enable == false)
            {
                axWindowsMediaPlayer1.settings.mute = enable;
            }
        }
    }
}
