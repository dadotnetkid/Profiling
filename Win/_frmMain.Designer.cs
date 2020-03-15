namespace Win
{
    partial class _frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel1.Size = new System.Drawing.Size(938, 110);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnProfiles);
            this.flowLayoutPanel1.Controls.Add(this.btnEmployee);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.btnMaintenance);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(898, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnDashboard.FlatAppearance.BorderSize = 2;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ImageIndex = 0;
            this.btnDashboard.ImageList = this.imageList1;
            this.btnDashboard.Location = new System.Drawing.Point(2, 10);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 10, 5, 10);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(91, 82);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home_32.png");
            this.imageList1.Images.SetKeyName(1, "delivery_64.png");
            this.imageList1.Images.SetKeyName(2, "computer_64.png");
            this.imageList1.Images.SetKeyName(3, "employee_64.png");
            this.imageList1.Images.SetKeyName(4, "maintenance_64.png");
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(296, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 10, 5, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "Deliveries";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProfiles
            // 
            this.btnProfiles.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnProfiles.FlatAppearance.BorderSize = 2;
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.ImageIndex = 2;
            this.btnProfiles.ImageList = this.imageList1;
            this.btnProfiles.Location = new System.Drawing.Point(100, 10);
            this.btnProfiles.Margin = new System.Windows.Forms.Padding(2, 10, 5, 10);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(91, 82);
            this.btnProfiles.TabIndex = 6;
            this.btnProfiles.Text = "Profiles";
            this.btnProfiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfiles.UseVisualStyleBackColor = true;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnMaintenance.FlatAppearance.BorderSize = 2;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.ImageIndex = 3;
            this.btnMaintenance.ImageList = this.imageList1;
            this.btnMaintenance.Location = new System.Drawing.Point(394, 10);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(2, 10, 5, 10);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(91, 82);
            this.btnMaintenance.TabIndex = 7;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnEmployee.FlatAppearance.BorderSize = 2;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ImageIndex = 3;
            this.btnEmployee.ImageList = this.imageList1;
            this.btnEmployee.Location = new System.Drawing.Point(198, 10);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2, 10, 5, 10);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(91, 82);
            this.btnEmployee.TabIndex = 8;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 517);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profiling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDashboard;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEmployee;
    }
}

