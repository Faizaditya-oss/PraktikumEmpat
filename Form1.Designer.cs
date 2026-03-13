namespace PraktikumADO
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
            this.Connect = new System.Windows.Forms.Button();
            this.HitungMhs = new System.Windows.Forms.Button();
            this.HitungMK = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitungDosen = new System.Windows.Forms.Button();
            this.btnUpdateMK = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(255, 198);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(284, 35);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect\r\n";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // HitungMhs
            // 
            this.HitungMhs.Location = new System.Drawing.Point(154, 257);
            this.HitungMhs.Name = "HitungMhs";
            this.HitungMhs.Size = new System.Drawing.Size(103, 35);
            this.HitungMhs.TabIndex = 1;
            this.HitungMhs.Text = "Hitung Mhs";
            this.HitungMhs.UseVisualStyleBackColor = true;
            this.HitungMhs.Click += new System.EventHandler(this.HitungMhs_Click);
            // 
            // HitungMK
            // 
            this.HitungMK.Location = new System.Drawing.Point(357, 257);
            this.HitungMK.Name = "HitungMK";
            this.HitungMK.Size = new System.Drawing.Size(103, 35);
            this.HitungMK.TabIndex = 2;
            this.HitungMK.Text = "Hitung Mk";
            this.HitungMK.UseVisualStyleBackColor = true;
            this.HitungMK.Click += new System.EventHandler(this.HitungMK_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(533, 257);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(103, 35);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "HASIL";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(226, 121);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(341, 47);
            this.txtHasil.TabIndex = 5;
            // 
            // btnHitungDosen
            // 
            this.btnHitungDosen.Location = new System.Drawing.Point(357, 317);
            this.btnHitungDosen.Name = "btnHitungDosen";
            this.btnHitungDosen.Size = new System.Drawing.Size(103, 35);
            this.btnHitungDosen.TabIndex = 6;
            this.btnHitungDosen.Text = "HitungDosen\r\n";
            this.btnHitungDosen.UseVisualStyleBackColor = true;
            this.btnHitungDosen.Click += new System.EventHandler(this.btnHitungDosen_Click);
            // 
            // btnUpdateMK
            // 
            this.btnUpdateMK.Location = new System.Drawing.Point(154, 317);
            this.btnUpdateMK.Name = "btnUpdateMK";
            this.btnUpdateMK.Size = new System.Drawing.Size(103, 35);
            this.btnUpdateMK.TabIndex = 7;
            this.btnUpdateMK.Text = "Update MK";
            this.btnUpdateMK.UseVisualStyleBackColor = true;
            this.btnUpdateMK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(533, 317);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 35);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert Prodi";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 557);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdateMK);
            this.Controls.Add(this.btnHitungDosen);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.HitungMK);
            this.Controls.Add(this.HitungMhs);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button HitungMhs;
        private System.Windows.Forms.Button HitungMK;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitungDosen;
        private System.Windows.Forms.Button btnUpdateMK;
        private System.Windows.Forms.Button btnInsert;
    }
}

