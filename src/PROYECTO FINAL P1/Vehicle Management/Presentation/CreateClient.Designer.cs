namespace Vehicle_Management.Presentation
{
    partial class CreateClient
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtlicense = new TextBox();
            txtemail = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            txtfullname = new TextBox();
            txtaddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Confirm_Creation = new Button();
            panel8 = new Panel();
            label6 = new Label();
            txtphone = new TextBox();
            label5 = new Label();
            datebirth = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 50, 90);
            panel1.Location = new Point(0, -13);
            panel1.Name = "panel1";
            panel1.Size = new Size(47, 534);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 50, 90);
            panel2.Location = new Point(827, -13);
            panel2.Name = "panel2";
            panel2.Size = new Size(45, 534);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 50, 90);
            panel3.Controls.Add(button3);
            panel3.Location = new Point(-48, -10);
            panel3.Name = "panel3";
            panel3.Size = new Size(920, 80);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(247, 0);
            button3.Name = "button3";
            button3.Size = new Size(478, 84);
            button3.TabIndex = 9;
            button3.Text = "Ingrese sus datos";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 228);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 30;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(628, 136);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 29;
            label4.Text = "E-Mail";
            // 
            // txtlicense
            // 
            txtlicense.BorderStyle = BorderStyle.None;
            txtlicense.Location = new Point(465, 184);
            txtlicense.Multiline = true;
            txtlicense.Name = "txtlicense";
            txtlicense.Size = new Size(350, 29);
            txtlicense.TabIndex = 28;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Location = new Point(471, 99);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(350, 29);
            txtemail.TabIndex = 27;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 117, 214);
            panel6.Location = new Point(471, 131);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 1);
            panel6.TabIndex = 26;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 117, 214);
            panel7.Location = new Point(465, 215);
            panel7.Name = "panel7";
            panel7.Size = new Size(350, 1);
            panel7.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 117, 214);
            panel5.Location = new Point(53, 212);
            panel5.Name = "panel5";
            panel5.Size = new Size(350, 1);
            panel5.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 117, 214);
            panel4.Location = new Point(53, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 1);
            panel4.TabIndex = 20;
            // 
            // txtfullname
            // 
            txtfullname.BorderStyle = BorderStyle.None;
            txtfullname.Location = new Point(53, 100);
            txtfullname.Multiline = true;
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(350, 29);
            txtfullname.TabIndex = 21;
            // 
            // txtaddress
            // 
            txtaddress.BorderStyle = BorderStyle.None;
            txtaddress.Location = new Point(53, 181);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(350, 29);
            txtaddress.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 136);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 23;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 216);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 24;
            label2.Text = "Direccion";
            // 
            // Confirm_Creation
            // 
            Confirm_Creation.BackColor = Color.FromArgb(35, 50, 90);
            Confirm_Creation.FlatStyle = FlatStyle.Flat;
            Confirm_Creation.Font = new Font("Segoe UI", 13F);
            Confirm_Creation.ForeColor = Color.White;
            Confirm_Creation.ImageAlign = ContentAlignment.MiddleLeft;
            Confirm_Creation.Location = new Point(330, 442);
            Confirm_Creation.Name = "Confirm_Creation";
            Confirm_Creation.Size = new Size(215, 64);
            Confirm_Creation.TabIndex = 59;
            Confirm_Creation.Text = "Confirmar";
            Confirm_Creation.UseVisualStyleBackColor = false;
            Confirm_Creation.Click += Confirm_Creation_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 117, 214);
            panel8.Location = new Point(53, 312);
            panel8.Name = "panel8";
            panel8.Size = new Size(350, 1);
            panel8.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(185, 316);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 35;
            label6.Text = "Telefono";
            // 
            // txtphone
            // 
            txtphone.BorderStyle = BorderStyle.None;
            txtphone.Location = new Point(53, 281);
            txtphone.Multiline = true;
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(350, 29);
            txtphone.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 320);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 62;
            label5.Text = "Fecha de Nacimiento";
            // 
            // datebirth
            // 
            datebirth.Location = new Point(515, 286);
            datebirth.Name = "datebirth";
            datebirth.Size = new Size(300, 31);
            datebirth.TabIndex = 63;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // CreateClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 518);
            Controls.Add(datebirth);
            Controls.Add(label5);
            Controls.Add(Confirm_Creation);
            Controls.Add(label6);
            Controls.Add(txtphone);
            Controls.Add(panel8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtlicense);
            Controls.Add(txtemail);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtaddress);
            Controls.Add(txtfullname);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateClient";
            Load += CreateClient_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private Label label3;
        private Label label4;
        private TextBox txtlicense;
        private TextBox txtemail;
        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private Panel panel4;
        private TextBox txtfullname;
        private TextBox txtaddress;
        private Label label1;
        private Label label2;
        private Button Confirm_Creation;
        private Panel panel8;
        private Label label6;
        private TextBox txtphone;
        private Label label5;
        private DateTimePicker datebirth;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}