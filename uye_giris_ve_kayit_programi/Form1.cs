namespace practice_tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_mail_types.Text = "Mail kalıpları.";
            label_login_options.Text = "Giriş Seçenekleri:";
            int secilen_index = comboBox_nick_or_mail.SelectedIndex;
            btn_register_comp.Visible = false;
            btn_register_comp.Text = "Kayıt işlemini tamamlamak için tıklayın.";
            comboBox_mail_types.Visible = false;
        }

        private void comboBox_nick_or_mail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_nick_or_mail.SelectedIndex == 0)
            {
                label_nick_or_mail.Text = "Kullanıcı adınız:";
                label_password.Text = "Şifreniz:";
            }
            else if (comboBox_nick_or_mail.SelectedIndex == 1)
            {
                comboBox_mail_types.Visible = true;
                label_nick_or_mail.Text = "E-posta adresiniz:";
                label_password.Text = "Şifreniz:";
            }
            else
            {
                label_nick_or_mail.Text = "";
                label_password.Text = "";
            }


        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (comboBox_nick_or_mail.SelectedIndex == 0)
            {
                if (textBox_nick_or_mail.Text == "admin" && textBox_password.Text == "admin")
                {
                    label_login_check.Text = "Giriş Başarılı!";
                }

                else if (textBox_nick_or_mail.Text == "" || textBox_password.Text == "")
                {
                    label_login_check.Text = "Giriş Başarısız. Kutucuklar boş olamaz.";
                    textBox_nick_or_mail.Text = "";
                    textBox_password.Text = "";
                }

                else
                {
                    label_login_check.Text = "Giriş başarısız. Kullanıcı adı veya şifre hatalı.";
                    textBox_nick_or_mail.Text = "";
                    textBox_password.Text = " ";
                }
            }
            else if (comboBox_nick_or_mail.SelectedIndex == 1)
            {
                if (textBox_nick_or_mail.Text == "info@admin.com" && textBox_password.Text == "admin")
                {
                    label_login_check.Text = "Giriş Başarılı!";
                }

                else if (textBox_nick_or_mail.Text == "" || textBox_password.Text == "")
                {
                    label_login_check.Text = "Giriş Başarısız. Kutucuklar boş olamaz.";
                    textBox_nick_or_mail.Text = "";
                    textBox_password.Text = "";
                }

                else
                {
                    label_login_check.Text = "Giriş başarısız. Kullanıcı adı veya şifre hatalı.";
                    textBox_nick_or_mail.Text = "";
                    textBox_password.Text = "";
                }
            }
            else if (textBox_nick_or_mail.Text == "" || textBox_password.Text == "")
            {
                label_login_check.Text = "Giriş Başarısız. Kutucuklar boş olamaz.";
                textBox_nick_or_mail.Text = "";
                textBox_password.Text = "";
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            comboBox_mail_types.Visible = false;
            btn_register_comp.Visible = true;
            btn_giris.Visible = false;
            btn_register.Visible = false;
            btn_register_comp.Location = new Point(160, 196);
            btn_register_comp.Size = new Size(212, 42);
            comboBox_nick_or_mail.Text = "";
            label_login_options.Text = "";
            label_login_options.Text = "Kayıt seçenekleri:";
            comboBox_nick_or_mail.Items.Clear();
            comboBox_nick_or_mail.Items.Add("Kullanıcı adı ile kayıt olmak istiyorum.");
            comboBox_nick_or_mail.Items.Add("E-posta adresi ile kayıt olmak istiyorum.");

            if (comboBox_nick_or_mail.SelectedIndex == 0)
            {
                comboBox_mail_types.Visible=false;
                label_nick_or_mail.Text = "Kullanıcı adınız:";
                label_password.Text = "Şifreniz:";
            }
            else if (comboBox_nick_or_mail.SelectedIndex == 1)
            {
                comboBox_mail_types.Visible = true;
                label_nick_or_mail.Text = "E-posta adresiniz:";
                label_password.Text = "Şifreniz:";
            }
            else
            {
                label_nick_or_mail.Text = "";
                label_password.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_nick_or_mail.Text == "" || textBox_password.Text == "")
            {
                label_login_check.Text = "Giriş Başarısız. Kutucuklar boş olamaz.";
                textBox_nick_or_mail.Text = "";
                textBox_password.Text = "";
            }
            else
            {
                label_login_check.Text = "Kayıt işlemi başarıyla tamamlandı. \nLütfen sisteme giriş yapınız.";
            }
        }

        private void comboBox_mail_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilen_mail_tipi = comboBox_mail_types.SelectedIndex;
            if (comboBox_mail_types.SelectedIndex == 0)
            {
                textBox_nick_or_mail.Text = "";
                textBox_nick_or_mail.Text += comboBox_mail_types.SelectedItem;
            }
            else if (comboBox_mail_types.SelectedIndex == 1)
            {
                textBox_nick_or_mail.Text = "";
                textBox_nick_or_mail.Text += comboBox_mail_types.SelectedItem;
            }
            else if (comboBox_mail_types.SelectedIndex == 2)
            {
                textBox_nick_or_mail.Text = "";
                textBox_nick_or_mail.Text += comboBox_mail_types.SelectedItem;
            }
            else if (comboBox_mail_types.SelectedIndex == 3)
            {
                textBox_nick_or_mail.Text = "";
                textBox_nick_or_mail.Text += comboBox_mail_types.SelectedItem;
            }
            else
            {
                textBox_nick_or_mail.Text = "";
                textBox_nick_or_mail.Text += comboBox_mail_types.SelectedItem;
            }
        }
    }
}