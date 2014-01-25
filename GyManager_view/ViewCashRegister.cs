using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GyManager_controller;

namespace GyManager
{
    public partial class ViewCashRegister : Form, IViewCashRegister
    {
        public ViewCashRegister()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void DisplayData(string value)
        {
            textBox1.Text = value;
        }

        public void UpdateForm()
        {
            Controller controller = new Controller();
            controller.UpdatedCashRegister(this);
            this.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
