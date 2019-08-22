namespace Resim_Hafiza_Oyunu
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_seviye = new System.Windows.Forms.ComboBox();
            this.cbx_resim_klasoru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_seviye
            // 
            this.cbx_seviye.FormattingEnabled = true;
            this.cbx_seviye.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cbx_seviye.Location = new System.Drawing.Point(57, 143);
            this.cbx_seviye.Name = "cbx_seviye";
            this.cbx_seviye.Size = new System.Drawing.Size(121, 21);
            this.cbx_seviye.TabIndex = 1;
            // 
            // cbx_resim_klasoru
            // 
            this.cbx_resim_klasoru.FormattingEnabled = true;
            this.cbx_resim_klasoru.Items.AddRange(new object[] {
            "Nature",
            "Objects",
            "Places",
            "Smiley",
            "Symbols"});
            this.cbx_resim_klasoru.Location = new System.Drawing.Point(290, 143);
            this.cbx_resim_klasoru.Name = "cbx_resim_klasoru";
            this.cbx_resim_klasoru.Size = new System.Drawing.Size(121, 21);
            this.cbx_resim_klasoru.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zorluk Seviyesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(290, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resim Klasörü";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Resim_Hafiza_Oyunu.Properties.Resources.xna_scrolling_bg_1;
            this.ClientSize = new System.Drawing.Size(502, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_resim_klasoru);
            this.Controls.Add(this.cbx_seviye);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_seviye;
        private System.Windows.Forms.ComboBox cbx_resim_klasoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}