namespace VeriMadenciligi_KararDestekY
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_ejection = new System.Windows.Forms.TextBox();
            this.txt_platelets = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_sonuc = new System.Windows.Forms.Button();
            this.chk_diyabet = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sodyum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phosphokinase = new System.Windows.Forms.TextBox();
            this.txt_sercreat = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.txt_ejection);
            this.groupBox1.Controls.Add(this.txt_platelets);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_sonuc);
            this.groupBox1.Controls.Add(this.btn_sonuc);
            this.groupBox1.Controls.Add(this.chk_diyabet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sodyum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_phosphokinase);
            this.groupBox1.Controls.Add(this.txt_sercreat);
            this.groupBox1.Controls.Add(this.txt_day);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 373);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Tıbbi Değerleri";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(95, 49);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 22);
            this.txt_age.TabIndex = 1;
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_age_KeyPress);
            // 
            // txt_ejection
            // 
            this.txt_ejection.Location = new System.Drawing.Point(234, 116);
            this.txt_ejection.Name = "txt_ejection";
            this.txt_ejection.Size = new System.Drawing.Size(100, 22);
            this.txt_ejection.TabIndex = 3;
            this.txt_ejection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ejection_KeyPress);
            // 
            // txt_platelets
            // 
            this.txt_platelets.Location = new System.Drawing.Point(234, 210);
            this.txt_platelets.Name = "txt_platelets";
            this.txt_platelets.Size = new System.Drawing.Size(100, 22);
            this.txt_platelets.TabIndex = 6;
            this.txt_platelets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_platelets_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Platelets(kiloplatelets/mL):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yaş:";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.ForeColor = System.Drawing.Color.Black;
            this.lbl_sonuc.Location = new System.Drawing.Point(230, 325);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(61, 20);
            this.lbl_sonuc.TabIndex = 13;
            this.lbl_sonuc.Text = "Sonuç";
            this.lbl_sonuc.Visible = false;
            // 
            // btn_sonuc
            // 
            this.btn_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sonuc.ForeColor = System.Drawing.Color.Blue;
            this.btn_sonuc.Location = new System.Drawing.Point(9, 311);
            this.btn_sonuc.Name = "btn_sonuc";
            this.btn_sonuc.Size = new System.Drawing.Size(105, 50);
            this.btn_sonuc.TabIndex = 9;
            this.btn_sonuc.Text = "Sonucu Gör";
            this.btn_sonuc.UseVisualStyleBackColor = true;
            this.btn_sonuc.Click += new System.EventHandler(this.btn_sonuc_Click);
            // 
            // chk_diyabet
            // 
            this.chk_diyabet.AutoSize = true;
            this.chk_diyabet.Location = new System.Drawing.Point(114, 276);
            this.chk_diyabet.Name = "chk_diyabet";
            this.chk_diyabet.Size = new System.Drawing.Size(18, 17);
            this.chk_diyabet.TabIndex = 8;
            this.chk_diyabet.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Diyabet var mı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ejection Fraction(%):";
            // 
            // txt_sodyum
            // 
            this.txt_sodyum.Location = new System.Drawing.Point(234, 147);
            this.txt_sodyum.Name = "txt_sodyum";
            this.txt_sodyum.Size = new System.Drawing.Size(100, 22);
            this.txt_sodyum.TabIndex = 4;
            this.txt_sodyum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sodyum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Creatinine phosphokinase(mcg/L):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serum Sodium(mEq/L):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serum Creatinine(mg/dL):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Süreç(gün):";
            // 
            // txt_phosphokinase
            // 
            this.txt_phosphokinase.Location = new System.Drawing.Point(234, 244);
            this.txt_phosphokinase.Name = "txt_phosphokinase";
            this.txt_phosphokinase.Size = new System.Drawing.Size(100, 22);
            this.txt_phosphokinase.TabIndex = 7;
            this.txt_phosphokinase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phosphokinase_KeyPress);
            // 
            // txt_sercreat
            // 
            this.txt_sercreat.Location = new System.Drawing.Point(233, 180);
            this.txt_sercreat.Name = "txt_sercreat";
            this.txt_sercreat.Size = new System.Drawing.Size(100, 22);
            this.txt_sercreat.TabIndex = 5;
            this.txt_sercreat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sercreat_KeyPress);
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(95, 84);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(100, 22);
            this.txt_day.TabIndex = 2;
            this.txt_day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_day_KeyPress);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(119, 311);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(105, 50);
            this.btn_temizle.TabIndex = 10;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 397);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Survival of Patients with Heart Failure";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_sonuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_diyabet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_ejection;
        private System.Windows.Forms.TextBox txt_platelets;
        private System.Windows.Forms.TextBox txt_sodyum;
        private System.Windows.Forms.TextBox txt_phosphokinase;
        private System.Windows.Forms.TextBox txt_sercreat;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Button btn_temizle;
    }
}

