namespace ParkingLotProject
{
    partial class AddVehiclePage
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
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(156, 289);
            button2.Name = "button2";
            button2.Size = new Size(115, 44);
            button2.TabIndex = 11;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(305, 289);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Motorcycle", "Car", "Van", "Truck" });
            comboBox1.Location = new Point(269, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 225);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 171);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Plate :";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 255, 255);
            label4.Location = new Point(104, 78);
            label4.Name = "label4";
            label4.Size = new Size(354, 48);
            label4.TabIndex = 6;
            label4.Text = "ADD NEW VEHICLE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddVehiclePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 255, 200);
            ClientSize = new Size(562, 433);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Name = "AddVehiclePage";
            Text = "AddVehiclePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}