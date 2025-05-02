namespace ParkingLotProject
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(79, 142);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // label2
            // 
            label2.Location = new Point(79, 192);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.Location = new Point(79, 242);
            label3.Name = "label3";
            label3.Size = new Size(115, 29);
            label3.TabIndex = 0;
            label3.Text = "Vehicle Plate :";
            // 
            // button1
            // 
            button1.Location = new Point(79, 316);
            button1.Name = "button1";
            button1.Size = new Size(128, 46);
            button1.TabIndex = 1;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(272, 316);
            button2.Name = "button2";
            button2.Size = new Size(128, 46);
            button2.TabIndex = 1;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 27);
            textBox3.TabIndex = 2;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(128, 255, 255);
            label4.Location = new Point(63, 41);
            label4.Name = "label4";
            label4.Size = new Size(193, 63);
            label4.TabIndex = 0;
            label4.Text = "Welcome To ParkingLot";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 255, 200);
            ClientSize = new Size(487, 410);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
