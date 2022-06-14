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
    public partial class Form3 : UserControl
    {
        Bool_inf state;
        MainForm mf;
        public Form3(MainForm mf, Bool_inf state)
        {
            this.mf = mf;
            this.state = state;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new Form2(mf, state));
            //Form2 f2 = new Form2(null);
            //this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) state.exp = true;
            if (radioButton2.Checked) state.exp = false;
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new Form4(mf, state));
            //Form4 f4= new Form4();
            //this.Visible=false;
        }
    }
}
