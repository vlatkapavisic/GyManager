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
    public partial class ViewAllPrograms : Form, IViewAllPrograms
    {
        public ViewAllPrograms()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void DisplayData(Dictionary<string, Program> programs, Dictionary<string, Instructor> instructors)
        {
            listView1.Items.Clear();
            foreach (string programName in programs.Keys)
            {
                Program program = programs[programName];
                Instructor instructor = instructors[program.instructor];
                ListViewItem item = new ListViewItem(program.name);

                item.SubItems.Add(Convert.ToString(program.price));
                item.SubItems.Add(Convert.ToString(program.places_available + program.places_taken));
                item.SubItems.Add(Convert.ToString(program.places_available));
                item.SubItems.Add(instructor.name+" "+instructor.surname);

                listView1.Items.Add(item);
            }
            
        }

        public void UpdateForm()
        {
            Controller controller = new Controller();
            controller.UpdatedListOfPrograms(this);
            this.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
