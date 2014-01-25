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
    public partial class ViewAllMembers : Form, IViewAllMembers
    {
        public ViewAllMembers()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void DisplayData(Dictionary<string, Member> members)
        {
            listView1.Items.Clear();
            foreach (Member member in members.Values)
            {
                ListViewItem item = new ListViewItem(member.name);
                item.SubItems.Add(member.surname);
                item.SubItems.Add(member.jmbg);
                item.SubItems.Add(String.Join(", ", member.programs));
                item.SubItems.Add(Convert.ToString(member.membership));
                if(!member.last_payment.Equals(DateTime.MinValue))
                    item.SubItems.Add(Convert.ToString(member.last_payment));
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
            controller.UpdatedListOfMembers(this);
            this.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
