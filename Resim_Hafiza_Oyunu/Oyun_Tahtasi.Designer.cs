namespace Resim_Hafiza_Oyunu
{
    partial class Oyun_Tahtasi
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
            this.components = new System.ComponentModel.Container();
            this.pnl_oyun_paneli = new System.Windows.Forms.Panel();
            this.tmrBekleme = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_oyun_paneli
            // 
            this.pnl_oyun_paneli.Location = new System.Drawing.Point(0, 0);
            this.pnl_oyun_paneli.Name = "pnl_oyun_paneli";
            this.pnl_oyun_paneli.Size = new System.Drawing.Size(750, 750);
            this.pnl_oyun_paneli.TabIndex = 0;
            // 
            // tmrBekleme
            // 
            this.tmrBekleme.Tick += new System.EventHandler(this.tmrBekleme_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(756, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(756, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 87);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Oyun_Tahtasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_oyun_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Oyun_Tahtasi";
            this.Text = "Oyun_Tahtasi";
            this.Load += new System.EventHandler(this.Oyun_Tahtasi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_oyun_paneli;
        private System.Windows.Forms.Timer tmrBekleme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}