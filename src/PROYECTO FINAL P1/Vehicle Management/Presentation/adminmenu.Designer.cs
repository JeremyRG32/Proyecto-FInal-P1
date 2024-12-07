namespace Vehicle_Management.Presentation
{
    partial class adminmenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminmenu));
            pictureBox4 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            upperbar = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            adminselect = new Label();
            sidebar = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            sidebartimer = new System.Windows.Forms.Timer(components);
            listViewCars = new ListView();
            Delete_Vehicle = new Button();
            Update_Vehicle = new Button();
            Create_Vehicle = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            upperbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.Back;
            pictureBox4.Location = new Point(3, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 15, 0, 0);
            label1.Size = new Size(151, 45);
            label1.TabIndex = 50;
            label1.Text = "Volver al login";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 50, 90);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.image_2024_12_04_144453060_removebg_preview_resized__2_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(8, 160);
            button1.Name = "button1";
            button1.Size = new Size(348, 100);
            button1.TabIndex = 1;
            button1.Text = "Gestionar Vehiculos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 50, 90);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.Booking_outline;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(8, 260);
            button3.Name = "button3";
            button3.Size = new Size(348, 100);
            button3.TabIndex = 48;
            button3.Text = "Gestionar Reservas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 50, 90);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.Card_Payment;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(8, 360);
            button4.Name = "button4";
            button4.Size = new Size(348, 100);
            button4.TabIndex = 49;
            button4.Text = "Gestionar Pagos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 50, 90);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.Customer;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(8, 460);
            button2.Name = "button2";
            button2.Size = new Size(348, 100);
            button2.TabIndex = 47;
            button2.Text = "Gestionar Clientes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Close_outline;
            pictureBox1.Location = new Point(1441, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(25, 0, 25, 0);
            pictureBox1.Size = new Size(56, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // upperbar
            // 
            upperbar.BackColor = Color.FromArgb(35, 50, 90);
            upperbar.Controls.Add(label3);
            upperbar.Controls.Add(pictureBox3);
            upperbar.Controls.Add(label1);
            upperbar.Controls.Add(pictureBox4);
            upperbar.Controls.Add(label2);
            upperbar.Controls.Add(pictureBox1);
            upperbar.Controls.Add(adminselect);
            upperbar.Location = new Point(65, -2);
            upperbar.MaximumSize = new Size(1511, 155);
            upperbar.MinimumSize = new Size(1233, 155);
            upperbar.Name = "upperbar";
            upperbar.Size = new Size(1511, 155);
            upperbar.TabIndex = 52;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Restart;
            pictureBox3.Location = new Point(1441, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 75);
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1257, 3);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 15, 0, 0);
            label2.Size = new Size(178, 45);
            label2.TabIndex = 52;
            label2.Text = "Cerrar Aplicacion";
            // 
            // adminselect
            // 
            adminselect.AutoSize = true;
            adminselect.BackColor = Color.Transparent;
            adminselect.Font = new Font("Segoe UI", 20F);
            adminselect.ForeColor = Color.White;
            adminselect.Location = new Point(587, 40);
            adminselect.Name = "adminselect";
            adminselect.Size = new Size(254, 54);
            adminselect.TabIndex = 51;
            adminselect.Text = "Admin Menu";
            adminselect.Visible = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 50, 90);
            sidebar.Controls.Add(pictureBox2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(button1);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(button4);
            sidebar.Location = new Point(-9, -7);
            sidebar.MaximumSize = new Size(356, 891);
            sidebar.MinimumSize = new Size(75, 100);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(75, 891);
            sidebar.TabIndex = 53;
            sidebar.Paint += sidebar_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Menu_white;
            pictureBox2.Location = new Point(14, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 63);
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 50, 90);
            panel3.Location = new Point(352, 332);
            panel3.Name = "panel3";
            panel3.Size = new Size(1233, 556);
            panel3.TabIndex = 54;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 1;
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // listViewCars
            // 
            listViewCars.Location = new Point(65, 150);
            listViewCars.MultiSelect = false;
            listViewCars.Name = "listViewCars";
            listViewCars.ShowGroups = false;
            listViewCars.Size = new Size(1153, 734);
            listViewCars.TabIndex = 54;
            listViewCars.UseCompatibleStateImageBehavior = false;
            listViewCars.View = View.Details;
            listViewCars.Visible = false;
            listViewCars.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Delete_Vehicle
            // 
            Delete_Vehicle.BackColor = Color.FromArgb(35, 50, 90);
            Delete_Vehicle.FlatStyle = FlatStyle.Flat;
            Delete_Vehicle.Font = new Font("Segoe UI", 13F);
            Delete_Vehicle.ForeColor = Color.White;
            Delete_Vehicle.Image = Properties.Resources.Delete;
            Delete_Vehicle.ImageAlign = ContentAlignment.MiddleLeft;
            Delete_Vehicle.Location = new Point(3, 173);
            Delete_Vehicle.Name = "Delete_Vehicle";
            Delete_Vehicle.Padding = new Padding(25, 0, 0, 0);
            Delete_Vehicle.Size = new Size(299, 77);
            Delete_Vehicle.TabIndex = 55;
            Delete_Vehicle.Text = "Eliminar ";
            Delete_Vehicle.UseVisualStyleBackColor = false;
            Delete_Vehicle.Visible = false;
            Delete_Vehicle.Click += Delete_Vehicle_Click;
            // 
            // Update_Vehicle
            // 
            Update_Vehicle.BackColor = Color.FromArgb(35, 50, 90);
            Update_Vehicle.FlatStyle = FlatStyle.Flat;
            Update_Vehicle.Font = new Font("Segoe UI", 13F);
            Update_Vehicle.ForeColor = Color.White;
            Update_Vehicle.Image = Properties.Resources.Update_outline;
            Update_Vehicle.ImageAlign = ContentAlignment.MiddleLeft;
            Update_Vehicle.Location = new Point(3, 90);
            Update_Vehicle.Name = "Update_Vehicle";
            Update_Vehicle.Padding = new Padding(25, 0, 0, 0);
            Update_Vehicle.Size = new Size(299, 77);
            Update_Vehicle.TabIndex = 56;
            Update_Vehicle.Text = "Editar";
            Update_Vehicle.UseVisualStyleBackColor = false;
            Update_Vehicle.Visible = false;
            Update_Vehicle.Click += Update_Vehicle_Click;
            // 
            // Create_Vehicle
            // 
            Create_Vehicle.BackColor = Color.FromArgb(35, 50, 90);
            Create_Vehicle.FlatStyle = FlatStyle.Flat;
            Create_Vehicle.Font = new Font("Segoe UI", 13F);
            Create_Vehicle.ForeColor = Color.White;
            Create_Vehicle.Image = Properties.Resources.Create;
            Create_Vehicle.ImageAlign = ContentAlignment.MiddleLeft;
            Create_Vehicle.Location = new Point(3, 7);
            Create_Vehicle.Name = "Create_Vehicle";
            Create_Vehicle.Padding = new Padding(25, 0, 0, 0);
            Create_Vehicle.Size = new Size(299, 77);
            Create_Vehicle.TabIndex = 57;
            Create_Vehicle.Text = "Añadir";
            Create_Vehicle.UseVisualStyleBackColor = false;
            Create_Vehicle.Visible = false;
            Create_Vehicle.Click += Create_Vehicle_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Delete_Vehicle);
            flowLayoutPanel1.Controls.Add(Update_Vehicle);
            flowLayoutPanel1.Controls.Add(Create_Vehicle);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(1243, 625);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(302, 253);
            flowLayoutPanel1.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1272, 93);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 15, 0, 0);
            label3.Size = new Size(150, 45);
            label3.TabIndex = 59;
            label3.Text = "Refrescar Lista";
            // 
            // adminmenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1568, 883);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(upperbar);
            Controls.Add(sidebar);
            Controls.Add(listViewCars);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "adminmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminmenu";
            Load += adminmenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            upperbar.ResumeLayout(false);
            upperbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox4;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel upperbar;
        private Label adminselect;
        private Panel sidebar;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer sidebartimer;
        private ListView listViewCars;
        private ColumnHeader columnHeader2;
        private Button Delete_Vehicle;
        private Button Update_Vehicle;
        private Button Create_Vehicle;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
    }
}