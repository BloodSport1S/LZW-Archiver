namespace LZWAlgorithms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.CompressingFiles = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressingFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompressingFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.AutoWordSelection = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(11, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1044, 460);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "";
            // 
            // CompressingFiles
            // 
            this.CompressingFiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CompressingFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.decompressingFilesToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.CompressingFiles.Location = new System.Drawing.Point(0, 0);
            this.CompressingFiles.Name = "CompressingFiles";
            this.CompressingFiles.Size = new System.Drawing.Size(1067, 40);
            this.CompressingFiles.TabIndex = 6;
            this.CompressingFiles.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(365, 36);
            this.toolStripMenuItem1.Text = "Выберите файлы для сжатия в архив";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // decompressingFilesToolStripMenuItem
            // 
            this.decompressingFilesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decompressingFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decompressingFilesToolStripMenuItem.Image")));
            this.decompressingFilesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decompressingFilesToolStripMenuItem.Name = "decompressingFilesToolStripMenuItem";
            this.decompressingFilesToolStripMenuItem.Size = new System.Drawing.Size(323, 36);
            this.decompressingFilesToolStripMenuItem.Text = "Выберите файлы для распаковки";
            this.decompressingFilesToolStripMenuItem.Click += new System.EventHandler(this.decompressingFilesToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.clearToolStripMenuItem.Text = "Очистка информации";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.AutoWordSelection = true;
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(420, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(520, 46);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Установление/cнятие пароля с архива";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CompressingFiles);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.CompressingFiles;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LZW Packer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CompressingFiles.ResumeLayout(false);
            this.CompressingFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox textBox2;
        private System.Windows.Forms.MenuStrip CompressingFiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decompressingFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}

