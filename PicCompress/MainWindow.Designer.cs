namespace PicCompress
{
    partial class MainWindow
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
            this.Txt_imgPath = new System.Windows.Forms.TextBox();
            this.Button_openFile = new System.Windows.Forms.Button();
            this.Txt_outPath = new System.Windows.Forms.TextBox();
            this.Button_openPath = new System.Windows.Forms.Button();
            this.Label_imgPath = new System.Windows.Forms.Label();
            this.Label_outPath = new System.Windows.Forms.Label();
            this.compressBar = new System.Windows.Forms.ProgressBar();
            this.Button_run = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Button_setPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_imgPath
            // 
            this.Txt_imgPath.Location = new System.Drawing.Point(16, 49);
            this.Txt_imgPath.Name = "Txt_imgPath";
            this.Txt_imgPath.Size = new System.Drawing.Size(325, 23);
            this.Txt_imgPath.TabIndex = 0;
            // 
            // Button_openFile
            // 
            this.Button_openFile.Location = new System.Drawing.Point(347, 49);
            this.Button_openFile.Name = "Button_openFile";
            this.Button_openFile.Size = new System.Drawing.Size(75, 23);
            this.Button_openFile.TabIndex = 1;
            this.Button_openFile.Text = "button1";
            this.Button_openFile.UseVisualStyleBackColor = true;
            this.Button_openFile.Click += new System.EventHandler(this.Button_openFile_Click);
            // 
            // Txt_outPath
            // 
            this.Txt_outPath.Location = new System.Drawing.Point(16, 106);
            this.Txt_outPath.Name = "Txt_outPath";
            this.Txt_outPath.Size = new System.Drawing.Size(325, 23);
            this.Txt_outPath.TabIndex = 2;
            // 
            // Button_openPath
            // 
            this.Button_openPath.Location = new System.Drawing.Point(347, 106);
            this.Button_openPath.Name = "Button_openPath";
            this.Button_openPath.Size = new System.Drawing.Size(75, 23);
            this.Button_openPath.TabIndex = 3;
            this.Button_openPath.Text = "button2";
            this.Button_openPath.UseVisualStyleBackColor = true;
            this.Button_openPath.Click += new System.EventHandler(this.Button_openPath_Click);
            // 
            // Label_imgPath
            // 
            this.Label_imgPath.AutoSize = true;
            this.Label_imgPath.Location = new System.Drawing.Point(16, 29);
            this.Label_imgPath.Name = "Label_imgPath";
            this.Label_imgPath.Size = new System.Drawing.Size(43, 17);
            this.Label_imgPath.TabIndex = 4;
            this.Label_imgPath.Text = "label1";
            // 
            // Label_outPath
            // 
            this.Label_outPath.AutoSize = true;
            this.Label_outPath.Location = new System.Drawing.Point(16, 86);
            this.Label_outPath.Name = "Label_outPath";
            this.Label_outPath.Size = new System.Drawing.Size(43, 17);
            this.Label_outPath.TabIndex = 5;
            this.Label_outPath.Text = "label2";
            // 
            // compressBar
            // 
            this.compressBar.Location = new System.Drawing.Point(16, 149);
            this.compressBar.Name = "compressBar";
            this.compressBar.Size = new System.Drawing.Size(406, 23);
            this.compressBar.TabIndex = 6;
            // 
            // Button_run
            // 
            this.Button_run.Location = new System.Drawing.Point(347, 196);
            this.Button_run.Name = "Button_run";
            this.Button_run.Size = new System.Drawing.Size(75, 23);
            this.Button_run.TabIndex = 7;
            this.Button_run.Text = "button3";
            this.Button_run.UseVisualStyleBackColor = true;
            this.Button_run.Click += new System.EventHandler(this.Button_run_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(252, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Button_setPath
            // 
            this.Button_setPath.Location = new System.Drawing.Point(16, 198);
            this.Button_setPath.Name = "Button_setPath";
            this.Button_setPath.Size = new System.Drawing.Size(129, 23);
            this.Button_setPath.TabIndex = 9;
            this.Button_setPath.Text = "button1";
            this.Button_setPath.UseVisualStyleBackColor = true;
            this.Button_setPath.Click += new System.EventHandler(this.Button_setPath_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 231);
            this.Controls.Add(this.Button_setPath);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Button_run);
            this.Controls.Add(this.compressBar);
            this.Controls.Add(this.Label_outPath);
            this.Controls.Add(this.Label_imgPath);
            this.Controls.Add(this.Button_openPath);
            this.Controls.Add(this.Txt_outPath);
            this.Controls.Add(this.Button_openFile);
            this.Controls.Add(this.Txt_imgPath);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txt_imgPath;
        private Button Button_openFile;
        private TextBox Txt_outPath;
        private Button Button_openPath;
        private Label Label_imgPath;
        private Label Label_outPath;
        private ProgressBar compressBar;
        private Button Button_run;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox checkBox1;
        private Button Button_setPath;
    }
}