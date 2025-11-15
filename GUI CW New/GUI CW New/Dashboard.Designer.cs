namespace GUI_CW_New
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnwed = new System.Windows.Forms.Button();
            this.btnvendor = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.btndash = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(260, 49);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(949, 637);
            this.mainpanel.TabIndex = 5;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::GUI_CW_New.Properties.Resources.e;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.btnwed);
            this.panel2.Controls.Add(this.btnvendor);
            this.panel2.Controls.Add(this.btnclient);
            this.panel2.Controls.Add(this.btndash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 637);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "REPORTS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome, Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::GUI_CW_New.Properties.Resources.h;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(81, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 61);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.LightPink;
            this.btnlogout.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(124, 559);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(112, 32);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnwed
            // 
            this.btnwed.BackColor = System.Drawing.Color.Transparent;
            this.btnwed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnwed.BackgroundImage")));
            this.btnwed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnwed.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwed.Location = new System.Drawing.Point(26, 395);
            this.btnwed.Name = "btnwed";
            this.btnwed.Size = new System.Drawing.Size(210, 53);
            this.btnwed.TabIndex = 5;
            this.btnwed.Text = "EVENT DETAILS";
            this.btnwed.UseVisualStyleBackColor = false;
            this.btnwed.Click += new System.EventHandler(this.btnwed_Click);
            // 
            // btnvendor
            // 
            this.btnvendor.BackColor = System.Drawing.Color.White;
            this.btnvendor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvendor.BackgroundImage")));
            this.btnvendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvendor.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendor.Location = new System.Drawing.Point(26, 324);
            this.btnvendor.Name = "btnvendor";
            this.btnvendor.Size = new System.Drawing.Size(210, 50);
            this.btnvendor.TabIndex = 4;
            this.btnvendor.Text = "VENDORS";
            this.btnvendor.UseVisualStyleBackColor = false;
            this.btnvendor.Click += new System.EventHandler(this.btnvendor_Click);
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.Color.Transparent;
            this.btnclient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclient.BackgroundImage")));
            this.btnclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnclient.FlatAppearance.BorderSize = 2;
            this.btnclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnclient.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.Location = new System.Drawing.Point(26, 245);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(210, 53);
            this.btnclient.TabIndex = 3;
            this.btnclient.Text = "CLIENTS";
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btndash
            // 
            this.btndash.BackColor = System.Drawing.Color.Transparent;
            this.btndash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndash.BackgroundImage")));
            this.btndash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndash.FlatAppearance.BorderSize = 2;
            this.btndash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btndash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btndash.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndash.Location = new System.Drawing.Point(26, 166);
            this.btndash.Name = "btndash";
            this.btndash.Size = new System.Drawing.Size(210, 53);
            this.btndash.TabIndex = 2;
            this.btndash.Text = "DASHBOARD";
            this.btndash.UseVisualStyleBackColor = false;
            this.btndash.Click += new System.EventHandler(this.btndash_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BackgroundImage = global::GUI_CW_New.Properties.Resources.e;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 49);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1176, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Planning Management System";
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 686);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnwed;
        private System.Windows.Forms.Button btnvendor;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btndash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}