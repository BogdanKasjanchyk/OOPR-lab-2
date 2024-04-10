namespace Kasianchuk_task_2
{
    partial class VisitorPanel
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 0;
            label1.Text = "Реєстрація";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(35, 94);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 29);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Чоловік", "Жінка" });
            comboBox1.Location = new Point(35, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(92, 28);
            comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(35, 299);
            numericUpDown1.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Montserrat SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(35, 349);
            button1.Name = "button1";
            button1.Size = new Size(205, 35);
            button1.TabIndex = 5;
            button1.Text = "Зареєструватись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(35, 75);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 6;
            label2.Text = "Введіть ім'я";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(35, 135);
            label3.Name = "label3";
            label3.Size = new Size(120, 16);
            label3.TabIndex = 7;
            label3.Text = "Введіть прізвище";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(35, 154);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 29);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(35, 199);
            label4.Name = "label4";
            label4.Size = new Size(92, 16);
            label4.TabIndex = 9;
            label4.Text = "Введіть стать";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Маскарад", "Рок-концерт", "Гопак" });
            comboBox2.Location = new Point(90, 298);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 28);
            comboBox2.TabIndex = 10;
            // 
            // label5
            // 
            label5.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(90, 258);
            label5.Name = "label5";
            label5.Size = new Size(128, 37);
            label5.TabIndex = 11;
            label5.Text = "Виберіть, на який концерт підете";
            // 
            // VisitorPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(287, 419);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "VisitorPanel";
            Text = "VisitorPanel";
            FormClosed += VisitorPanel_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
    }
}