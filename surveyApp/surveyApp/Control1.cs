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
    public partial class Form1 : UserControl
    {
        Bool_inf state;
        MainForm mf;
        public Form1(MainForm mf, Bool_inf state)
        {
            this.state = state;
            this.mf = mf;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new Form2(mf,state));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new 관리자로그인(mf, state));
        }

        public void setInfo(Bool_inf state, MainForm mf)
        {
            this.state = state;
            this.mf = mf;
        }
    }
}
