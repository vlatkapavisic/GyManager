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
    public partial class AddAMember : Form, IAddAMember
    {
        public AddAMember()
        {
            InitializeComponent();
        }

        public int ShowForm()
        {
            DialogResult res = this.ShowDialog();

            if (res == DialogResult.OK)
                return 1;
            else
            {
                return 0;
            }
        }

        public string GetName()
        {
            return this.textBox1.Text;
        }

        public string GetSurname()
        {
            return this.textBox2.Text;
        }

        public string GetJmbg()
        {
            return this.textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.AddAMember(this);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ExceptionHandle(string text)
        {
            MessageBox.Show(this, text);
        }
        
    }
}
