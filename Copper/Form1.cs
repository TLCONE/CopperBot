using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copper
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnSnipes_Click(object sender, EventArgs e)
        {
            //Open new form 
            //Close old form
        }

        private void bttnkickz_Click(object sender, EventArgs e)
        {
            var FrmKickz = new FrmKickz();
            var SSForm = new Form1();
            FrmKickz.Show();
            SSForm.Close();
            //Close old form
        }

        private void bttnalllike_Click(object sender, EventArgs e)
        {
            //Open new form 
            //Close old form
        }

        private void bttnadidas_Click(object sender, EventArgs e)
        {
            //Open new form 
            //Close old form
        }
    }
}
