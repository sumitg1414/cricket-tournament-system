namespace CRICKETNEW
{
    partial class Login
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(372, 150);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Teamname :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(372, 197);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Password :-";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(489, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(489, 194);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.newback;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(379, 258);
            button1.Name = "button1";
            button1.Size = new Size(96, 35);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(508, 233);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.newback;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(498, 258);
            button2.Name = "button2";
            button2.Size = new Size(96, 35);
            button2.TabIndex = 6;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Image = Properties.Resources.newback;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(186, 46);
            label3.Name = "label3";
            label3.Size = new Size(490, 24);
            label3.TabIndex = 7;
            label3.Text = "WELCOME TO CRICKET TOURNAMENT 2023-24";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.newback;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(762, 418);
            button3.Name = "button3";
            button3.Size = new Size(96, 35);
            button3.TabIndex = 8;
            button3.Text = "Admin Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = Properties.Resources.newback;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(634, 418);
            button4.Name = "button4";
            button4.Size = new Size(96, 35);
            button4.TabIndex = 9;
            button4.Text = "Contact";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(806, 12);
            button5.Name = "button5";
            button5.Size = new Size(52, 32);
            button5.TabIndex = 10;
            button5.Text = "<-";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.newback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(886, 480);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}