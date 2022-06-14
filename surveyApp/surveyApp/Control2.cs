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
    public partial class Form2 : UserControl
    {
        MainForm mf;
        Bool_inf state;
        public Form2(MainForm mf, Bool_inf state)
        {
            this.state = state;
            this.mf = mf;
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            //this.mf.Controls.Clear();
            //this.mf.Controls.Add(new Form1(mf, state));
            //Form1 f1 = new Form1(mf);
            //this.Visible = false;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "남성") this.state.gender = "남성";
            if (comboBox1.SelectedItem.ToString() == "여성") this.state.gender = "여성";
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new Form3(mf, state));
            //Form3 f3 = new Form3();
            //this.Visible = false;


        }
    }
}
