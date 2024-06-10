using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            lsKQ.Items.Clear();
            int cc = Convert.ToInt32(txtSo.Text);
            for (int i = 1; i <= 10; i++)
            {
                //lsKQ.Items.Add(txtSo.Text + " x " + i.ToString() + " = " + Convert.ToString(cc*i));
                lsKQ.Items.Add(string.Format("{1} x {0} = {2}", txtSo.Text, i.ToString(), Convert.ToString(cc*i)));
            }    
        }
    }
}
