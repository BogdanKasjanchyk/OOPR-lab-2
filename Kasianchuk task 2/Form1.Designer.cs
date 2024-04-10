namespace Kasianchuk_task_2
{
    partial class Form1
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
            materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // materialFlatButton1
            // 
            materialFlatButton1.AutoSize = true;
            materialFlatButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialFlatButton1.Depth = 0;
            materialFlatButton1.Location = new Point(50, 38);
            materialFlatButton1.Margin = new Padding(4, 6, 4, 6);
            materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFlatButton1.Name = "materialFlatButton1";
            materialFlatButton1.Primary = false;
            materialFlatButton1.Size = new Size(253, 36);
            materialFlatButton1.TabIndex = 0;
            materialFlatButton1.Text = "Демонстрація завдання5";
            materialFlatButton1.UseVisualStyleBackColor = true;
            materialFlatButton1.Click += materialFlatButton1_Click;
            // 
            // materialContextMenuStrip1
            // 
            materialContextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            materialContextMenuStrip1.Depth = 0;
            materialContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            materialContextMenuStrip1.Size = new Size(61, 4);
            // 
            // materialFlatButton2
            // 
            materialFlatButton2.AutoSize = true;
            materialFlatButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialFlatButton2.Depth = 0;
            materialFlatButton2.Location = new Point(50, 98);
            materialFlatButton2.Margin = new Padding(4, 6, 4, 6);
            materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFlatButton2.Name = "materialFlatButton2";
            materialFlatButton2.Primary = false;
            materialFlatButton2.Size = new Size(257, 36);
            materialFlatButton2.TabIndex = 2;
            materialFlatButton2.Text = "Демонстрація завдання 6";
            materialFlatButton2.UseVisualStyleBackColor = true;
            materialFlatButton2.Click += materialFlatButton2_Click;
            // 
            // materialRaisedButton1
            // 
            materialRaisedButton1.Depth = 0;
            materialRaisedButton1.Location = new Point(38, 272);
            materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRaisedButton1.Name = "materialRaisedButton1";
            materialRaisedButton1.Primary = true;
            materialRaisedButton1.Size = new Size(308, 40);
            materialRaisedButton1.TabIndex = 3;
            materialRaisedButton1.Text = "Реєстрація відвідувача";
            materialRaisedButton1.UseVisualStyleBackColor = true;
            materialRaisedButton1.Click += materialRaisedButton1_Click;
            // 
            // materialRaisedButton2
            // 
            materialRaisedButton2.Depth = 0;
            materialRaisedButton2.Location = new Point(38, 178);
            materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialRaisedButton2.Name = "materialRaisedButton2";
            materialRaisedButton2.Primary = true;
            materialRaisedButton2.Size = new Size(308, 40);
            materialRaisedButton2.TabIndex = 4;
            materialRaisedButton2.Text = "Менеджер";
            materialRaisedButton2.UseVisualStyleBackColor = true;
            materialRaisedButton2.Click += materialRaisedButton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(materialRaisedButton2);
            Controls.Add(materialRaisedButton1);
            Controls.Add(materialFlatButton2);
            Controls.Add(materialFlatButton1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}