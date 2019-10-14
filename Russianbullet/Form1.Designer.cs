namespace Russianbullet
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.AimBtn = new System.Windows.Forms.Button();
            this.FireBtn = new System.Windows.Forms.Button();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShAwayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadBtn.Location = new System.Drawing.Point(12, 352);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(86, 31);
            this.LoadBtn.TabIndex = 2;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SpinBtn
            // 
            this.SpinBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpinBtn.Enabled = false;
            this.SpinBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpinBtn.Location = new System.Drawing.Point(12, 398);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(86, 31);
            this.SpinBtn.TabIndex = 3;
            this.SpinBtn.Text = "Spin";
            this.SpinBtn.UseVisualStyleBackColor = false;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // AimBtn
            // 
            this.AimBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AimBtn.Enabled = false;
            this.AimBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AimBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AimBtn.Location = new System.Drawing.Point(136, 352);
            this.AimBtn.Name = "AimBtn";
            this.AimBtn.Size = new System.Drawing.Size(86, 31);
            this.AimBtn.TabIndex = 4;
            this.AimBtn.Text = "Aim";
            this.AimBtn.UseVisualStyleBackColor = false;
            this.AimBtn.Click += new System.EventHandler(this.AimBtn_Click);
            // 
            // FireBtn
            // 
            this.FireBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FireBtn.Enabled = false;
            this.FireBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FireBtn.Location = new System.Drawing.Point(136, 398);
            this.FireBtn.Name = "FireBtn";
            this.FireBtn.Size = new System.Drawing.Size(86, 31);
            this.FireBtn.TabIndex = 5;
            this.FireBtn.Text = "Fire";
            this.FireBtn.UseVisualStyleBackColor = false;
            this.FireBtn.Click += new System.EventHandler(this.FireBtn_Click);
            // 
            // PicBox1
            // 
            this.PicBox1.BackgroundImage = global::Russianbullet.Resource1.bg_pic;
            this.PicBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBox1.Location = new System.Drawing.Point(0, 0);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(803, 452);
            this.PicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox1.TabIndex = 6;
            this.PicBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 10;
            // 
            // ShAwayBtn
            // 
            this.ShAwayBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShAwayBtn.Enabled = false;
            this.ShAwayBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShAwayBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShAwayBtn.Location = new System.Drawing.Point(262, 398);
            this.ShAwayBtn.Name = "ShAwayBtn";
            this.ShAwayBtn.Size = new System.Drawing.Size(119, 31);
            this.ShAwayBtn.TabIndex = 11;
            this.ShAwayBtn.Text = "Fire Away";
            this.ShAwayBtn.UseVisualStyleBackColor = false;
            this.ShAwayBtn.Click += new System.EventHandler(this.ShAwayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShAwayBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FireBtn);
            this.Controls.Add(this.AimBtn);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.PicBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.Button AimBtn;
        private System.Windows.Forms.Button FireBtn;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShAwayBtn;
    }
}

