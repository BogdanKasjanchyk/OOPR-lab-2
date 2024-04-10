namespace Kasianchuk_task_2
{
    partial class managerPanel
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
            materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // materialFlatButton1
            // 
            materialFlatButton1.AutoSize = true;
            materialFlatButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialFlatButton1.Depth = 0;
            materialFlatButton1.Location = new Point(35, 49);
            materialFlatButton1.Margin = new Padding(4, 6, 4, 6);
            materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFlatButton1.Name = "materialFlatButton1";
            materialFlatButton1.Primary = false;
            materialFlatButton1.Size = new Size(268, 36);
            materialFlatButton1.TabIndex = 1;
            materialFlatButton1.Text = "Показати всіх відвідувачів";
            materialFlatButton1.UseVisualStyleBackColor = true;
            materialFlatButton1.Click += materialFlatButton1_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = SystemColors.WindowFrame;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new Point(0, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(630, 324);
            listBox1.TabIndex = 2;
            // 
            // managerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(listBox1);
            Controls.Add(materialFlatButton1);
            Name = "managerPanel";
            Text = "managerPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private ListBox listBox1;
    }
}