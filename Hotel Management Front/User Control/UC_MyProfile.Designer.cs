﻿namespace Hotel_System_Front.User_Control
{
    partial class UC_MyProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            name = new TextBox();
            password = new TextBox();
            address = new TextBox();
            phone = new TextBox();
            nationality = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(468, 23);
            label9.Name = "label9";
            label9.Size = new Size(240, 54);
            label9.TabIndex = 52;
            label9.Text = "My Profile";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(468, 226);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(723, 257);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(527, 518);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 54;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(893, 518);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(103, 45);
            button2.TabIndex = 55;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            name.Location = new Point(158, 219);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(259, 27);
            name.TabIndex = 56;
            // 
            // password
            // 
            password.Location = new Point(147, 292);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.Size = new Size(270, 27);
            password.TabIndex = 57;
            // 
            // address
            // 
            address.Location = new Point(147, 378);
            address.Margin = new Padding(3, 4, 3, 4);
            address.Name = "address";
            address.Size = new Size(270, 27);
            address.TabIndex = 58;
            // 
            // phone
            // 
            phone.Location = new Point(147, 465);
            phone.Margin = new Padding(3, 4, 3, 4);
            phone.Name = "phone";
            phone.Size = new Size(270, 27);
            phone.TabIndex = 59;
            // 
            // nationality
            // 
            nationality.Location = new Point(147, 554);
            nationality.Margin = new Padding(3, 4, 3, 4);
            nationality.Name = "nationality";
            nationality.Size = new Size(277, 27);
            nationality.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 226);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 61;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 298);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 62;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 382);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 63;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 469);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 64;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 561);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 65;
            label5.Text = "Nationality";
            // 
            // UC_MyProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nationality);
            Controls.Add(phone);
            Controls.Add(address);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_MyProfile";
            Size = new Size(1253, 851);
            Load += UC_MyProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox name;
        private TextBox password;
        private TextBox address;
        private TextBox phone;
        private TextBox nationality;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
