using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriMadenciligi_KararDestekY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SADECE INT DEGER GIRME
        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_ejection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_sodyum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_sercreat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_platelets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_phosphokinase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Sonuç Butonu
        private void btn_sonuc_Click(object sender, EventArgs e)
        {
            //Boşluk gelmesi ihtimaline karşı error verme
            if (txt_day.Text == "" || txt_age.Text == "" || txt_platelets.Text == "" || txt_sercreat.Text == "" || txt_sodyum.Text == "" || txt_phosphokinase.Text == "" || txt_ejection.Text == "")
            {
                lbl_sonuc.Text = "Değerleri boş bırakmayınız!";
                lbl_sonuc.Visible = true;
            }

            else
            {
                //Textbox'a yazılanları int yapma
                int age = Convert.ToInt32(txt_age.Text);
                int day = Convert.ToInt32(txt_day.Text);
                int eject = Convert.ToInt32(txt_ejection.Text);
                int sodyum = Convert.ToInt32(txt_sodyum.Text);
                float sercreat = (float)Convert.ToDouble(txt_sercreat.Text);
                int platelets = Convert.ToInt32(txt_platelets.Text);
                int phosphokinase = Convert.ToInt32(txt_phosphokinase.Text);

                //KARAR AĞACI
                //Karar Ağacının sol tarafı
                if (day >= 74)
                {
                    if (platelets > 126500)
                    {
                        lbl_sonuc.Text = "Death Event: NO";
                        lbl_sonuc.ForeColor = Color.LimeGreen;
                        lbl_sonuc.Visible = true;
                    }
                    else
                    {
                        if (age >= 62)
                        {
                            lbl_sonuc.Text = "Death Event: NO";
                            lbl_sonuc.ForeColor = Color.LimeGreen;
                            lbl_sonuc.Visible = true;
                        }
                        else
                        {
                            lbl_sonuc.Text = "Death Event: YES";
                            lbl_sonuc.ForeColor = Color.Red;
                            lbl_sonuc.Visible = true;
                        }
                    }
                }
                //Karar Ağacının sağ tarafı
                else
                {
                    if (sodyum <= 134)
                    {
                        lbl_sonuc.Text = "Death Event: YES";
                        lbl_sonuc.ForeColor = Color.Red;
                        lbl_sonuc.Visible = true;
                    }
                    else
                    {
                        if (phosphokinase <= 85)
                        {
                            lbl_sonuc.Text = "Death Event: NO";
                            lbl_sonuc.ForeColor = Color.LimeGreen;
                            lbl_sonuc.Visible = true;
                        }
                        else
                        {
                            if (sercreat <= 0.85)
                            {
                                lbl_sonuc.Text = "Death Event: NO";
                                lbl_sonuc.ForeColor = Color.LimeGreen;
                                lbl_sonuc.Visible = true;
                            }
                            else
                            {
                                if (age >= 63)
                                {
                                    lbl_sonuc.Text = "Death Event: YES";
                                    lbl_sonuc.ForeColor = Color.Red;
                                    lbl_sonuc.Visible = true;
                                }
                                else
                                {
                                    if (day > 62)
                                    {
                                        lbl_sonuc.Text = "Death Event: NO";
                                        lbl_sonuc.ForeColor = Color.LimeGreen;
                                        lbl_sonuc.Visible = true;
                                    }
                                    else
                                    {
                                        if (eject >= 33)
                                        {
                                            lbl_sonuc.Text = "Death Event: YES";
                                            lbl_sonuc.ForeColor = Color.Red;
                                            lbl_sonuc.Visible = true;
                                        }
                                        else
                                        {
                                            if (chk_diyabet.Checked)
                                            {
                                                lbl_sonuc.Text = "Death Event: NO";
                                                lbl_sonuc.ForeColor = Color.LimeGreen;
                                                lbl_sonuc.Visible = true;
                                            }
                                            else
                                            {
                                                lbl_sonuc.Text = "Death Event: YES";
                                                lbl_sonuc.ForeColor = Color.Red;
                                                lbl_sonuc.Visible = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }

                }

            }
        }

        //Ekranı Temizle
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_age.Clear();
            txt_day.Clear();
            txt_ejection.Clear();
            txt_sodyum.Clear();
            txt_sercreat.Clear();
            txt_platelets.Clear();
            txt_phosphokinase.Clear();
            chk_diyabet.Checked = false;
        }
    }
}
