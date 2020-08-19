using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalLib;
namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CalLib obj;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            obj = new CalLib();
            obj.X = Convert.ToDouble(txtX.Text);
            obj.Y = Convert.ToDouble(txtY.Text);
            lblDisplay.Text = "Addition of two Num: " + obj.CalAdd().ToString();
            txtX.Text = "";
            txtY.Text = "";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            obj = new CalLib();
            obj.X = Convert.ToDouble(txtX.Text);
            obj.Y = Convert.ToDouble(txtY.Text);
            lblDisplay.Text = "Sub of two Num: " + obj.CalAdd().ToString();
            txtX.Text = "";
            txtY.Text = "";

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            obj = new CalLib();
            obj.X = Convert.ToDouble(txtX.Text);
            
            obj.Y = Convert.ToDouble(txtY.Text);
            lblDisplay.Text = "Mul of two Num: " + obj.CalAdd().ToString();
            txtX.Text = "";
            txtY.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            obj = new CalLib();
            obj.X = Convert.ToDouble(txtX.Text);
            obj.Y = Convert.ToDouble(txtY.Text);
            lblDisplay.Text = "Div of two Num: " + obj.CalAdd().ToString();
            txtX.Text = "";
            txtY.Text = "";
        }
    }
}
