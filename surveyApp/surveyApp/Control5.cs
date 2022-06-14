using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surveyApp
{
    public partial class Form5 : UserControl
    {
        MainForm mf;
        Bool_inf state;
        public Form5(MainForm mf, Bool_inf state)
        {
            this.mf = mf;
            this.state = state;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new 관리자로그인(mf,state));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new Form6(mf, state));
        }
    }
}
