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
    public partial class ViewAllInstructors : Form, IViewAllInstructos
    {
        public ViewAllInstructors()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void DisplayData(Dictionary<string, Instructor> instructors, Dictionary<string, Program> programs)
        {
            listView1.Items.Clear();
            foreach (Instructor instructor in instructors.Values)
            {

                ListViewItem item = new ListViewItem(instructor.name);
                item.SubItems.Add(instructor.surname);
                item.SubItems.Add(instructor.jmbg);
                item.SubItems.Add(instructor.program);
                Program program = programs[instructor.program];
                item.SubItems.Add(Convert.ToString(program.salary));
                if (!instructor.last_payment.Equals(DateTime.MinValue))
                    item.SubItems.Add(Convert.ToString(instructor.last_payment));
                else
                {
                    item.SubItems.Add("never");
                }
                listView1.Items.Add(item);
            }
        }

        public void UpdateForm()
        {
            Controller controller = new Controller();
            controller.UpdatedListOfInstructors(this);
            this.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
