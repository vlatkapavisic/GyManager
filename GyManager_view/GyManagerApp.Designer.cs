namespace GyManager
{
    partial class GyManagerApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollAProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unenrollAProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllInstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireAndHireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.programsToolStripMenuItem,
            this.instructorsToolStripMenuItem,
            this.cashRegisterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllMembersToolStripMenuItem,
            this.addAMemberToolStripMenuItem,
            this.deleteAMemberToolStripMenuItem,
            this.enrollAProgramToolStripMenuItem,
            this.unenrollAProgramToolStripMenuItem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // viewAllMembersToolStripMenuItem
            // 
            this.viewAllMembersToolStripMenuItem.Name = "viewAllMembersToolStripMenuItem";
            this.viewAllMembersToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.viewAllMembersToolStripMenuItem.Text = "View all members";
            this.viewAllMembersToolStripMenuItem.Click += new System.EventHandler(this.viewAllMembersToolStripMenuItem_Click);
            // 
            // addAMemberToolStripMenuItem
            // 
            this.addAMemberToolStripMenuItem.Name = "addAMemberToolStripMenuItem";
            this.addAMemberToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addAMemberToolStripMenuItem.Text = "Add a member";
            this.addAMemberToolStripMenuItem.Click += new System.EventHandler(this.addAMemberToolStripMenuItem_Click);
            // 
            // deleteAMemberToolStripMenuItem
            // 
            this.deleteAMemberToolStripMenuItem.Name = "deleteAMemberToolStripMenuItem";
            this.deleteAMemberToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteAMemberToolStripMenuItem.Text = "Delete a member";
            this.deleteAMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteAMemberToolStripMenuItem_Click);
            // 
            // enrollAProgramToolStripMenuItem
            // 
            this.enrollAProgramToolStripMenuItem.Name = "enrollAProgramToolStripMenuItem";
            this.enrollAProgramToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.enrollAProgramToolStripMenuItem.Text = "Enroll a program";
            this.enrollAProgramToolStripMenuItem.Click += new System.EventHandler(this.enrollAProgramToolStripMenuItem_Click);
            // 
            // unenrollAProgramToolStripMenuItem
            // 
            this.unenrollAProgramToolStripMenuItem.Name = "unenrollAProgramToolStripMenuItem";
            this.unenrollAProgramToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.unenrollAProgramToolStripMenuItem.Text = "Unenroll a program";
            this.unenrollAProgramToolStripMenuItem.Click += new System.EventHandler(this.unenrollAProgramToolStripMenuItem_Click);
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllProgramsToolStripMenuItem,
            this.addAProgramToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // viewAllProgramsToolStripMenuItem
            // 
            this.viewAllProgramsToolStripMenuItem.Name = "viewAllProgramsToolStripMenuItem";
            this.viewAllProgramsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.viewAllProgramsToolStripMenuItem.Text = "View all programs";
            this.viewAllProgramsToolStripMenuItem.Click += new System.EventHandler(this.viewAllProgramsToolStripMenuItem_Click);
            // 
            // addAProgramToolStripMenuItem
            // 
            this.addAProgramToolStripMenuItem.Name = "addAProgramToolStripMenuItem";
            this.addAProgramToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.addAProgramToolStripMenuItem.Text = "Add a program and an instructor";
            this.addAProgramToolStripMenuItem.Click += new System.EventHandler(this.addAProgramToolStripMenuItem_Click);
            // 
            // instructorsToolStripMenuItem
            // 
            this.instructorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllInstructorsToolStripMenuItem,
            this.fireAndHireToolStripMenuItem});
            this.instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            this.instructorsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.instructorsToolStripMenuItem.Text = "Instructors";
            // 
            // viewAllInstructorsToolStripMenuItem
            // 
            this.viewAllInstructorsToolStripMenuItem.Name = "viewAllInstructorsToolStripMenuItem";
            this.viewAllInstructorsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.viewAllInstructorsToolStripMenuItem.Text = "View all instructors";
            this.viewAllInstructorsToolStripMenuItem.Click += new System.EventHandler(this.viewAllInstructorsToolStripMenuItem_Click);
            // 
            // fireAndHireToolStripMenuItem
            // 
            this.fireAndHireToolStripMenuItem.Name = "fireAndHireToolStripMenuItem";
            this.fireAndHireToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fireAndHireToolStripMenuItem.Text = "Fire and hire";
            this.fireAndHireToolStripMenuItem.Click += new System.EventHandler(this.fireAndHireToolStripMenuItem_Click);
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCurrentStateToolStripMenuItem,
            this.membershipPaymentToolStripMenuItem,
            this.salaryPaymentToolStripMenuItem});
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cashRegisterToolStripMenuItem.Text = "Cash register";
            // 
            // viewCurrentStateToolStripMenuItem
            // 
            this.viewCurrentStateToolStripMenuItem.Name = "viewCurrentStateToolStripMenuItem";
            this.viewCurrentStateToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewCurrentStateToolStripMenuItem.Text = "View current state";
            this.viewCurrentStateToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentStateToolStripMenuItem_Click);
            // 
            // membershipPaymentToolStripMenuItem
            // 
            this.membershipPaymentToolStripMenuItem.Name = "membershipPaymentToolStripMenuItem";
            this.membershipPaymentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.membershipPaymentToolStripMenuItem.Text = "Membership payment";
            this.membershipPaymentToolStripMenuItem.Click += new System.EventHandler(this.membershipPaymentToolStripMenuItem_Click);
            // 
            // salaryPaymentToolStripMenuItem
            // 
            this.salaryPaymentToolStripMenuItem.Name = "salaryPaymentToolStripMenuItem";
            this.salaryPaymentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.salaryPaymentToolStripMenuItem.Text = "Salary payment";
            this.salaryPaymentToolStripMenuItem.Click += new System.EventHandler(this.salaryPaymentToolStripMenuItem_Click);
            // 
            // GyManagerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GyManager.Properties.Resources.tumblr_md2v8yqahl1r2jdszo1_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 377);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GyManagerApp";
            this.Text = "GyManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollAProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unenrollAProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllInstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireAndHireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryPaymentToolStripMenuItem;
    }
}

