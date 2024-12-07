namespace Vehicle_Management.Presentation
{
    partial class Confirm_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_Payment));
            label10 = new Label();
            button1 = new Button();
            Confirm_Creation = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            txtamount = new TextBox();
            boxpaymethod = new ComboBox();
            txtvehicleid = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtvehiclename = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(461, 112);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 149;
            label10.Text = "Monto";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 50, 90);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(708, 505);
            button1.Name = "button1";
            button1.Size = new Size(215, 64);
            button1.TabIndex = 148;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Confirm_Creation
            // 
            Confirm_Creation.BackColor = Color.FromArgb(35, 50, 90);
            Confirm_Creation.FlatStyle = FlatStyle.Flat;
            Confirm_Creation.Font = new Font("Segoe UI", 13F);
            Confirm_Creation.ForeColor = Color.White;
            Confirm_Creation.ImageAlign = ContentAlignment.MiddleLeft;
            Confirm_Creation.Location = new Point(57, 505);
            Confirm_Creation.Name = "Confirm_Creation";
            Confirm_Creation.Size = new Size(215, 64);
            Confirm_Creation.TabIndex = 147;
            Confirm_Creation.Text = "Confirmar";
            Confirm_Creation.UseVisualStyleBackColor = false;
            Confirm_Creation.Click += Confirm_Creation_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 50, 90);
            panel3.Location = new Point(-84, -57);
            panel3.Name = "panel3";
            panel3.Size = new Size(93, 677);
            panel3.TabIndex = 143;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 50, 90);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 82);
            panel1.TabIndex = 142;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(394, 25);
            label1.Name = "label1";
            label1.Size = new Size(209, 38);
            label1.TabIndex = 1;
            label1.Text = "Confirmar Pago";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(408, 372);
            label8.Name = "label8";
            label8.Size = new Size(146, 25);
            label8.TabIndex = 141;
            label8.Text = "Metodo de Pago";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(391, 185);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 1);
            panel5.TabIndex = 135;
            // 
            // txtamount
            // 
            txtamount.BorderStyle = BorderStyle.None;
            txtamount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtamount.Location = new Point(388, 162);
            txtamount.Name = "txtamount";
            txtamount.ReadOnly = true;
            txtamount.Size = new Size(197, 24);
            txtamount.TabIndex = 129;
            txtamount.TextAlign = HorizontalAlignment.Center;
            // 
            // boxpaymethod
            // 
            boxpaymethod.FormattingEnabled = true;
            boxpaymethod.Items.AddRange(new object[] { "Efectivo", "Tarjeta de Credito", "Transferencia" });
            boxpaymethod.Location = new Point(392, 416);
            boxpaymethod.Name = "boxpaymethod";
            boxpaymethod.Size = new Size(182, 33);
            boxpaymethod.TabIndex = 150;
            // 
            // txtvehicleid
            // 
            txtvehicleid.BorderStyle = BorderStyle.None;
            txtvehicleid.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvehicleid.Location = new Point(15, 88);
            txtvehicleid.Name = "txtvehicleid";
            txtvehicleid.ReadOnly = true;
            txtvehicleid.Size = new Size(197, 24);
            txtvehicleid.TabIndex = 151;
            txtvehicleid.TextAlign = HorizontalAlignment.Center;
            txtvehicleid.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 232);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 154;
            label2.Text = "Nombre del vehiculo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(391, 302);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 153;
            // 
            // txtvehiclename
            // 
            txtvehiclename.BorderStyle = BorderStyle.None;
            txtvehiclename.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvehiclename.Location = new Point(388, 279);
            txtvehiclename.Name = "txtvehiclename";
            txtvehiclename.ReadOnly = true;
            txtvehiclename.Size = new Size(197, 24);
            txtvehiclename.TabIndex = 152;
            txtvehiclename.TextAlign = HorizontalAlignment.Center;
            // 
            // Confirm_Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 624);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(txtvehiclename);
            Controls.Add(txtvehicleid);
            Controls.Add(boxpaymethod);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(Confirm_Creation);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(panel5);
            Controls.Add(txtamount);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Confirm_Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirm_Payment";
            Load += Confirm_Payment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Button button1;
        private Button Confirm_Creation;
        private Panel panel3;
        private Panel panel1;
        private Label label1;
        private Label label8;
        private Panel panel5;
        private TextBox txtamount;
        private ComboBox boxpaymethod;
        private TextBox txtvehicleid;
        private Label label2;
        private Panel panel2;
        private TextBox txtvehiclename;
    }
}