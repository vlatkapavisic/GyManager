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
    public partial class GyManagerApp : Form
    {
        private Controller controller = new Controller();

        public GyManagerApp()
        {
            InitializeComponent();
        }

        private void addAMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAMember addForm = new AddAMember();
            addForm.Show();
        }

        private void viewAllMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllMembers viewForm = new ViewAllMembers();
            controller.ViewAllMembers(viewForm);
        }

        private void deleteAMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAMember deleteForm = new DeleteAMember();
            deleteForm.Show();
        }

        private void addAProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAProgramAndAnInstructor addForm = new AddAProgramAndAnInstructor();
            addForm.Show();
        }

        private void viewAllProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllPrograms viewForm = new ViewAllPrograms();
            controller.ViewAllPrograms(viewForm);
        }

        private void enrollAProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrollAProgram enrollForm = new EnrollAProgram();
            enrollForm.Show();
        }

        private void unenrollAProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnenrollAProgram unenrollForm = new UnenrollAProgram();
            unenrollForm.Show();
        }

        private void fireAndHireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FireAndHire fireForm = new FireAndHire();
            fireForm.Show();
        }

        private void viewAllInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllInstructors viewForm = new ViewAllInstructors();
            controller.ViewAllInstructors(viewForm);
        }

        private void membershipPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayMembership payForm = new PayMembership();
            payForm.Show();
        }

        private void salaryPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaySalary payForm = new PaySalary();
            payForm.Show();
        }

        private void viewCurrentStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCashRegister viewForm = new ViewCashRegister();
            controller.ViewCashRegister(viewForm);
        }

        

        

        
    }
}
