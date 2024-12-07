namespace Vehicle_Management.Presentation
{
    partial class clientmenu
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
            upperbar = new Panel();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            adminselect = new Label();
            sidebar = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            Delete_Vehicle = new Button();
            Cancel_Reservation = new Button();
            Reserve_Vehicle = new Button();
            listViewClient = new ListView();
            txtuserid = new TextBox();
            txtrealuser = new TextBox();
            upperbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // upperbar
            // 
            upperbar.BackColor = Color.FromArgb(35, 50, 90);
            upperbar.Controls.Add(label1);
            upperbar.Controls.Add(pictureBox4);
            upperbar.Controls.Add(pictureBox3);
            upperbar.Controls.Add(label2);
            upperbar.Controls.Add(pictureBox1);
            upperbar.Controls.Add(adminselect);
            upperbar.Location = new Point(61, 0);
            upperbar.MaximumSize = new Size(1511, 155);
            upperbar.MinimumSize = new Size(1233, 155);
            upperbar.Name = "upperbar";
            upperbar.Size = new Size(1511, 155);
            upperbar.TabIndex = 53;
            upperbar.Paint += upperbar_Paint;
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
            // adminselect
            // 
            adminselect.AutoSize = true;
            adminselect.BackColor = Color.Transparent;
            adminselect.Font = new Font("Segoe UI", 20F);
            adminselect.ForeColor = Color.White;
            adminselect.Location = new Point(623, 44);
            adminselect.Name = "adminselect";
            adminselect.Size = new Size(240, 54);
            adminselect.TabIndex = 51;
            adminselect.Text = "Client Menu";
            adminselect.Visible = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 50, 90);
            sidebar.Controls.Add(pictureBox2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(button1);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(button4);
            sidebar.Location = new Point(-4, 0);
            sidebar.MaximumSize = new Size(356, 891);
            sidebar.MinimumSize = new Size(75, 100);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(306, 891);
            sidebar.TabIndex = 54;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Menu_white;
            pictureBox2.Location = new Point(8, 3);
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
            button1.Text = "Reservar Vehiculos";
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
            button3.Text = "Ver Reservas";
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
            button4.Text = "Ver Pagos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 1;
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Delete_Vehicle);
            flowLayoutPanel1.Controls.Add(Cancel_Reservation);
            flowLayoutPanel1.Controls.Add(Reserve_Vehicle);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(1234, 564);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(322, 321);
            flowLayoutPanel1.TabIndex = 60;
            // 
            // Delete_Vehicle
            // 
            Delete_Vehicle.BackColor = Color.FromArgb(35, 50, 90);
            Delete_Vehicle.FlatStyle = FlatStyle.Flat;
            Delete_Vehicle.Font = new Font("Segoe UI", 13F);
            Delete_Vehicle.ForeColor = Color.White;
            Delete_Vehicle.Image = Properties.Resources.Delete;
            Delete_Vehicle.ImageAlign = ContentAlignment.MiddleLeft;
            Delete_Vehicle.Location = new Point(3, 241);
            Delete_Vehicle.Name = "Delete_Vehicle";
            Delete_Vehicle.Padding = new Padding(25, 0, 0, 0);
            Delete_Vehicle.Size = new Size(316, 77);
            Delete_Vehicle.TabIndex = 55;
            Delete_Vehicle.Text = "Eliminar ";
            Delete_Vehicle.UseVisualStyleBackColor = false;
            Delete_Vehicle.Visible = false;
            // 
            // Cancel_Reservation
            // 
            Cancel_Reservation.BackColor = Color.FromArgb(35, 50, 90);
            Cancel_Reservation.FlatStyle = FlatStyle.Flat;
            Cancel_Reservation.Font = new Font("Segoe UI", 13F);
            Cancel_Reservation.ForeColor = Color.White;
            Cancel_Reservation.Image = Properties.Resources.Update_outline;
            Cancel_Reservation.ImageAlign = ContentAlignment.MiddleLeft;
            Cancel_Reservation.Location = new Point(3, 158);
            Cancel_Reservation.Name = "Cancel_Reservation";
            Cancel_Reservation.Padding = new Padding(25, 0, 0, 0);
            Cancel_Reservation.Size = new Size(316, 77);
            Cancel_Reservation.TabIndex = 56;
            Cancel_Reservation.Text = "Cancelar";
            Cancel_Reservation.UseVisualStyleBackColor = false;
            Cancel_Reservation.Visible = false;
            // 
            // Reserve_Vehicle
            // 
            Reserve_Vehicle.BackColor = Color.FromArgb(35, 50, 90);
            Reserve_Vehicle.FlatStyle = FlatStyle.Flat;
            Reserve_Vehicle.Font = new Font("Segoe UI", 13F);
            Reserve_Vehicle.ForeColor = Color.White;
            Reserve_Vehicle.Image = Properties.Resources.Create;
            Reserve_Vehicle.ImageAlign = ContentAlignment.MiddleLeft;
            Reserve_Vehicle.Location = new Point(3, 75);
            Reserve_Vehicle.Name = "Reserve_Vehicle";
            Reserve_Vehicle.Padding = new Padding(25, 0, 0, 0);
            Reserve_Vehicle.Size = new Size(316, 77);
            Reserve_Vehicle.TabIndex = 57;
            Reserve_Vehicle.Text = "Reservar";
            Reserve_Vehicle.UseVisualStyleBackColor = false;
            Reserve_Vehicle.Visible = false;
            Reserve_Vehicle.Click += Reserve_Vehicle_Click;
            // 
            // listViewClient
            // 
            listViewClient.Location = new Point(64, 154);
            listViewClient.MultiSelect = false;
            listViewClient.Name = "listViewClient";
            listViewClient.ShowGroups = false;
            listViewClient.Size = new Size(1153, 734);
            listViewClient.TabIndex = 61;
            listViewClient.UseCompatibleStateImageBehavior = false;
            listViewClient.View = View.Details;
            listViewClient.Visible = false;
            listViewClient.SelectedIndexChanged += listViewClient_SelectedIndexChanged;
            // 
            // txtuserid
            // 
            txtuserid.Location = new Point(1361, 154);
            txtuserid.Name = "txtuserid";
            txtuserid.Size = new Size(196, 31);
            txtuserid.TabIndex = 62;
            txtuserid.Visible = false;
            txtuserid.TextChanged += txtuserid_TextChanged;
            // 
            // txtrealuser
            // 
            txtrealuser.Location = new Point(1362, 197);
            txtrealuser.Name = "txtrealuser";
            txtrealuser.Size = new Size(196, 31);
            txtrealuser.TabIndex = 63;
            txtrealuser.Visible = false;
            // 
            // clientmenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1568, 883);
            Controls.Add(txtrealuser);
            Controls.Add(txtuserid);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(upperbar);
            Controls.Add(sidebar);
            Controls.Add(listViewClient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "clientmenu";
            Load += clientmenu_Load;
            upperbar.ResumeLayout(false);
            upperbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel upperbar;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label adminselect;
        private Panel sidebar;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button button1;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer sidebartimer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Delete_Vehicle;
        private Button Cancel_Reservation;
        private Button Reserve_Vehicle;
        private ListView listViewClient;
        private TextBox txtuserid;
        private TextBox txtrealuser;
    }
}