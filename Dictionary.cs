using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Dictionary : UserControl
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void btn_BackToMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
