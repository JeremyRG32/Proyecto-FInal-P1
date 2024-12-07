namespace Vehicle_Management.Presentation
{
    partial class CreateVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVehicle));
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtmodel = new TextBox();
            txtbrand = new TextBox();
            txtyear = new TextBox();
            txtfuel = new TextBox();
            txtpassenger = new TextBox();
            txtplate = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel2 = new Panel();
            panel11 = new Panel();
            Confirm_Creation = new Button();
            button1 = new Button();
            chkavailable = new CheckBox();
            label8 = new Label();
            panel6 = new Panel();
            txtprice = new TextBox();
            label9 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 50, 90);
            panel1.Location = new Point(-18, -20);
            panel1.Name = "panel1";
            panel1.Size = new Size(72, 665);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 50, 90);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(2, -46);
            panel3.Name = "panel3";
            panel3.Size = new Size(974, 103);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 55);
            label1.Name = "label1";
            label1.Size = new Size(229, 38);
            label1.TabIndex = 0;
            label1.Text = "Agregar Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 127);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 3;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 127);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 4;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 258);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 5;
            label4.Text = "Año";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 258);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 6;
            label5.Text = "Combustible";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(677, 258);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 7;
            label6.Text = "Capacidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 375);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 8;
            label7.Text = "Matricula";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtmodel
            // 
            txtmodel.BorderStyle = BorderStyle.None;
            txtmodel.Location = new Point(394, 174);
            txtmodel.Name = "txtmodel";
            txtmodel.Size = new Size(150, 24);
            txtmodel.TabIndex = 11;
            // 
            // txtbrand
            // 
            txtbrand.BorderStyle = BorderStyle.None;
            txtbrand.Location = new Point(131, 177);
            txtbrand.Name = "txtbrand";
            txtbrand.Size = new Size(150, 24);
            txtbrand.TabIndex = 12;
            // 
            // txtyear
            // 
            txtyear.BorderStyle = BorderStyle.None;
            txtyear.Location = new Point(134, 308);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(150, 24);
            txtyear.TabIndex = 14;
            txtyear.TextChanged += txtyear_TextChanged;
            // 
            // txtfuel
            // 
            txtfuel.BorderStyle = BorderStyle.None;
            txtfuel.Location = new Point(397, 308);
            txtfuel.Name = "txtfuel";
            txtfuel.Size = new Size(150, 24);
            txtfuel.TabIndex = 15;
            txtfuel.TextChanged += txtfuel_TextChanged;
            // 
            // txtpassenger
            // 
            txtpassenger.BorderStyle = BorderStyle.None;
            txtpassenger.Location = new Point(654, 308);
            txtpassenger.Name = "txtpassenger";
            txtpassenger.Size = new Size(150, 24);
            txtpassenger.TabIndex = 16;
            // 
            // txtplate
            // 
            txtplate.BorderStyle = BorderStyle.None;
            txtplate.Location = new Point(260, 422);
            txtplate.Name = "txtplate";
            txtplate.Size = new Size(150, 24);
            txtplate.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(394, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 1);
            panel4.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(131, 200);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 1);
            panel5.TabIndex = 34;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(131, 331);
            panel7.Name = "panel7";
            panel7.Size = new Size(150, 1);
            panel7.TabIndex = 34;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(394, 331);
            panel8.Name = "panel8";
            panel8.Size = new Size(150, 1);
            panel8.TabIndex = 34;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(651, 331);
            panel9.Name = "panel9";
            panel9.Size = new Size(150, 1);
            panel9.TabIndex = 34;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(260, 445);
            panel10.Name = "panel10";
            panel10.Size = new Size(150, 1);
            panel10.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 50, 90);
            panel2.Location = new Point(2, 595);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 50);
            panel2.TabIndex = 35;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(35, 50, 90);
            panel11.Location = new Point(894, -20);
            panel11.Name = "panel11";
            panel11.Size = new Size(76, 662);
            panel11.TabIndex = 36;
            // 
            // Confirm_Creation
            // 
            Confirm_Creation.BackColor = Color.FromArgb(35, 50, 90);
            Confirm_Creation.FlatStyle = FlatStyle.Flat;
            Confirm_Creation.Font = new Font("Segoe UI", 13F);
            Confirm_Creation.ForeColor = Color.White;
            Confirm_Creation.ImageAlign = ContentAlignment.MiddleLeft;
            Confirm_Creation.Location = new Point(72, 503);
            Confirm_Creation.Name = "Confirm_Creation";
            Confirm_Creation.Size = new Size(215, 64);
            Confirm_Creation.TabIndex = 58;
            Confirm_Creation.Text = "Confirmar";
            Confirm_Creation.UseVisualStyleBackColor = false;
            Confirm_Creation.Click += Confirm_Creation_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 50, 90);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(664, 503);
            button1.Name = "button1";
            button1.Size = new Size(215, 64);
            button1.TabIndex = 59;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chkavailable
            // 
            chkavailable.AutoSize = true;
            chkavailable.Location = new Point(737, 180);
            chkavailable.Name = "chkavailable";
            chkavailable.Size = new Size(22, 21);
            chkavailable.TabIndex = 88;
            chkavailable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(695, 127);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 89;
            label8.Text = "Disponible";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(540, 445);
            panel6.Name = "panel6";
            panel6.Size = new Size(150, 1);
            panel6.TabIndex = 94;
            // 
            // txtprice
            // 
            txtprice.BorderStyle = BorderStyle.None;
            txtprice.Location = new Point(540, 422);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(150, 24);
            txtprice.TabIndex = 93;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(575, 375);
            label9.Name = "label9";
            label9.Size = new Size(60, 25);
            label9.TabIndex = 92;
            label9.Text = "Precio";
            // 
            // CreateVehicle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(947, 640);
            Controls.Add(panel6);
            Controls.Add(txtprice);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(chkavailable);
            Controls.Add(button1);
            Controls.Add(Confirm_Creation);
            Controls.Add(panel11);
            Controls.Add(panel2);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(txtplate);
            Controls.Add(txtpassenger);
            Controls.Add(txtfuel);
            Controls.Add(txtyear);
            Controls.Add(txtbrand);
            Controls.Add(txtmodel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateVehicle";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtmodel;
        private TextBox txtbrand;
        private TextBox txtyear;
        private TextBox txtfuel;
        private TextBox txtpassenger;
        private TextBox txtplate;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel2;
        private Panel panel11;
        private Button Confirm_Creation;
        private Button button1;
        private CheckBox chkavailable;
        private Label label8;
        private Panel panel6;
        private TextBox txtprice;
        private Label label9;
    }
}