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
    public partial class AddAProgramAndAnInstructor : Form, IAddAProgram
    {
        public AddAProgramAndAnInstructor()
        {
            InitializeComponent();
        }

        public void ExceptionHandle(string text)
        {
            MessageBox.Show(this, text);
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

        public string GetProgramName()
        {
            return textBox1.Text;
        }

        public string GetPrice()
        {
            return textBox2.Text;
        }

        public string GetPlaces()
        {
            return textBox3.Text;
        }

        public string GetInstructorsName()
        {
            return textBox4.Text;
        }

        public string GetInstructorsSurname()
        {
            return textBox5.Text;
        }

        public string GetInstructorsJmbg()
        {
            return textBox6.Text;
        }

        public string GetSalary()
        {
            return textBox7.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.AddAProgramAndAnInstructor(this);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
