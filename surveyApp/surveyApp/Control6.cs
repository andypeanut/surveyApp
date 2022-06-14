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
    public partial class Form6 : UserControl
    {
        MainForm mf;
        Bool_inf state;
        public Form6(MainForm mf, Bool_inf state)
        {
            this.mf = mf;
            this.state = state;
            InitializeComponent();

            if (state.gender != "여성") {
                label2.Text = "남성입니다.\n";
            }
            else
            {
                label2.Text = "여성입니다.\n";
            }
            if(state.exp == true)
            {
                label2.Text = label2.Text +  "아르바이트 경험이 있습니다.\n";
            }
            else
            {
                label2.Text = label2.Text + "아르바이트 경험이 없습니다.\n";
            }
            label2.Text += "해보고싶은 아르바이트들은 ";
            foreach (var item in state.selected)
            {
                label2.Text += item;
                label2.Text += ", ";
            }
            label2.Text = label2.Text.Remove(label2.Text.Length - 2);
            label2.Text += "입니다";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new Form5(mf, state));
        }
    }
}
