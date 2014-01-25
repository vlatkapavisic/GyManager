namespace GyManager
{
    partial class ViewAllMembers
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Programs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Membership = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastPayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Surname,
            this.JMBG,
            this.Programs,
            this.Membership,
            this.LastPayed});
            this.listView1.Location = new System.Drawing.Point(31, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(634, 327);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 90;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 98;
            // 
            // JMBG
            // 
            this.JMBG.Text = "JMBG";
            this.JMBG.Width = 106;
            // 
            // Programs
            // 
            this.Programs.Text = "Programs";
            this.Programs.Width = 149;
            // 
            // Membership
            // 
            this.Membership.DisplayIndex = 5;
            this.Membership.Text = "Membership Price";
            this.Membership.Width = 99;
            // 
            // LastPayed
            // 
            this.LastPayed.DisplayIndex = 4;
            this.LastPayed.Text = "Last Payment";
            this.LastPayed.Width = 88;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAllMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            //this.Name = "ViewAllMembers";
            this.Text = "ViewAllMembers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader Programs;
        private System.Windows.Forms.ColumnHeader Membership;
        private System.Windows.Forms.ColumnHeader LastPayed;
        private System.Windows.Forms.Button button1;


    }
}