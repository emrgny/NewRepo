namespace ParkingLotProject
{
    partial class RegisterPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(101, 99);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.Location = new Point(101, 149);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 0;
            label2.Text = "Surname :";
            // 
            // label3
            // 
            label3.Location = new Point(101, 199);
            label3.Name = "label3";
            label3.Size = new Size(119, 31);
            label3.TabIndex = 0;
            label3.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.Location = new Point(101, 249);
            label4.Name = "label4";
            label4.Size = new Size(106, 31);
            label4.TabIndex = 0;
            label4.Text = "Email :";
            // 
            // label5
            // 
            label5.Location = new Point(101, 299);
            label5.Name = "label5";
            label5.Size = new Size(106, 31);
            label5.TabIndex = 0;
            label5.Text = "Password :";
            // 
            // label6
            // 
            label6.Location = new Point(101, 349);
            label6.Name = "label6";
            label6.Size = new Size(137, 31);
            label6.TabIndex = 0;
            label6.Text = "Confirm Password :";
            // 
            // button1
            // 
            button1.Location = new Point(283, 515);
            button1.Name = "button1";
            button1.Size = new Size(138, 46);
            button1.TabIndex = 1;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(242, 249);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(242, 299);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(167, 27);
            textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(244, 349);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 27);
            textBox6.TabIndex = 2;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(192, 255, 255);
            label7.Location = new Point(12, 21);
            label7.Name = "label7";
            label7.Size = new Size(508, 56);
            label7.TabIndex = 0;
            label7.Text = "PARKINGLOT REGISTER PAGE";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(99, 515);
            button2.Name = "button2";
            button2.Size = new Size(138, 46);
            button2.TabIndex = 1;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.Location = new Point(101, 399);
            label8.Name = "label8";
            label8.Size = new Size(137, 31);
            label8.TabIndex = 0;
            label8.Text = "Vehicle Plate : ";
            // 
            // label9
            // 
            label9.Location = new Point(100, 449);
            label9.Name = "label9";
            label9.Size = new Size(137, 31);
            label9.TabIndex = 0;
            label9.Text = "Vehicle Type : ";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(244, 399);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(165, 27);
            textBox7.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Motorcycle", "Car", "Van", "Truck" });
            comboBox1.Location = new Point(244, 452);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 28);
            comboBox1.TabIndex = 3;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 255, 200);
            ClientSize = new Size(532, 584);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "RegisterPage";
            Text = "RegisterPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Button button2;
        private Label label8;
        private Label label9;
        private TextBox textBox7;
        private ComboBox comboBox1;
    }
}