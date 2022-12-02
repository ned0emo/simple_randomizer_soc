using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreasuresSoC
{
    public partial class OkForm : Form
    {
        public OkForm(string errMessage)
        {
            InitializeComponent();

            label1.Text = errMessage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
