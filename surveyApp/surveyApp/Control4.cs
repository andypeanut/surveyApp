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
    public partial class Form4 : UserControl
    {
        MainForm mf;
        Bool_inf state;
        public Form4(MainForm mf, Bool_inf state)
        {
            this.mf = mf;
            this.state = state;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new Form3(mf, state));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state.selected = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                state.selected.Add(item.ToString());
            } 
            this.mf.Controls.Clear();
            this.mf.Controls.Add(new Form5(mf, state));
            var loc = this.mf.Controls[mf.Controls.Count - 1].Location;
            loc.Y = 0;

            this.mf.Controls[mf.Controls.Count - 1].Location = loc;
            this.mf.Controls[mf.Controls.Count - 1].Dock = DockStyle.Fill;
            //Form3 f3=new Form3();
            //this.Visible = false;
        }
    }
}
