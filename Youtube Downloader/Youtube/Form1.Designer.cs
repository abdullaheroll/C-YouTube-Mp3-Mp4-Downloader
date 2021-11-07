
namespace Youtube
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.baslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonMP4 = new System.Windows.Forms.RadioButton();
            this.radioButtonMP3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(78, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "BAŞLAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(78, 300);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(391, 37);
            this.progressBar1.TabIndex = 4;
            // 
            // baslik
            // 
            this.baslik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.baslik.Location = new System.Drawing.Point(38, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(699, 63);
            this.baslik.TabIndex = 5;
            this.baslik.Text = "YOUTUBE MP3 - MP4 İNDİRİCİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(4, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL:";
            // 
            // radioButtonMP4
            // 
            this.radioButtonMP4.AutoSize = true;
            this.radioButtonMP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMP4.ForeColor = System.Drawing.Color.Coral;
            this.radioButtonMP4.Location = new System.Drawing.Point(372, 151);
            this.radioButtonMP4.Name = "radioButtonMP4";
            this.radioButtonMP4.Size = new System.Drawing.Size(97, 36);
            this.radioButtonMP4.TabIndex = 2;
            this.radioButtonMP4.TabStop = true;
            this.radioButtonMP4.Text = "MP4";
            this.radioButtonMP4.UseVisualStyleBackColor = true;
            this.radioButtonMP4.TextChanged += new System.EventHandler(this.radioButtonMP4_TextChanged);
            // 
            // radioButtonMP3
            // 
            this.radioButtonMP3.AutoSize = true;
            this.radioButtonMP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMP3.ForeColor = System.Drawing.Color.Coral;
            this.radioButtonMP3.Location = new System.Drawing.Point(78, 151);
            this.radioButtonMP3.Name = "radioButtonMP3";
            this.radioButtonMP3.Size = new System.Drawing.Size(97, 36);
            this.radioButtonMP3.TabIndex = 1;
            this.radioButtonMP3.TabStop = true;
            this.radioButtonMP3.Text = "MP3";
            this.radioButtonMP3.UseVisualStyleBackColor = true;
            this.radioButtonMP3.TextChanged += new System.EventHandler(this.radioButtonMP3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(521, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonMP4);
            this.Controls.Add(this.radioButtonMP3);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "YouTube İndirici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonMP4;
        private System.Windows.Forms.RadioButton radioButtonMP3;
    }
}

