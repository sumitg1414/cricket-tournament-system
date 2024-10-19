namespace CRICKETNEW
{
    partial class TournamentAdmin
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
            label5 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button5 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(325, 26);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 3;
            label1.Text = "Tournament Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(23, 26);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 12;
            label2.Text = "Admin Panel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RebeccaPurple;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(316, 22);
            label5.TabIndex = 13;
            label5.Text = "Enter The 1st Round Winning Team:-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RebeccaPurple;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(12, 228);
            label3.Name = "label3";
            label3.Size = new Size(327, 22);
            label3.TabIndex = 14;
            label3.Text = "Enter The 2nd  Round Winning Team:-";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 23);
            textBox2.TabIndex = 16;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Firebrick;
            button2.Location = new Point(144, 401);
            button2.Name = "button2";
            button2.Size = new Size(90, 37);
            button2.TabIndex = 17;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(406, 405);
            button5.Name = "button5";
            button5.Size = new Size(93, 33);
            button5.TabIndex = 18;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(348, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 23);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RebeccaPurple;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(12, 283);
            label4.Name = "label4";
            label4.Size = new Size(325, 22);
            label4.TabIndex = 20;
            label4.Text = "Enter The 3rd  Round Winning Team:-";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(474, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(386, 246);
            dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(279, 401);
            button1.Name = "button1";
            button1.Size = new Size(90, 37);
            button1.TabIndex = 22;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TournamentAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RebeccaPurple;
            ClientSize = new Size(886, 480);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TournamentAdmin";
            Text = "TournamentAdmin";
            Load += TournamentAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button5;
        private TextBox textBox3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button1;
    }
}