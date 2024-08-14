namespace practice_tests
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_baslik = new LinkLabel();
            comboBox_nick_or_mail = new ComboBox();
            label_imza = new Label();
            label_nick_or_mail = new Label();
            label_password = new Label();
            textBox_nick_or_mail = new TextBox();
            textBox_password = new TextBox();
            btn_giris = new Button();
            btn_register = new Button();
            label_login_check = new Label();
            label_login_options = new Label();
            btn_register_comp = new Button();
            comboBox_mail_types = new ComboBox();
            SuspendLayout();
            // 
            // label_baslik
            // 
            label_baslik.AutoSize = true;
            label_baslik.ForeColor = Color.Black;
            label_baslik.LinkColor = Color.Black;
            label_baslik.Location = new Point(190, 50);
            label_baslik.Name = "label_baslik";
            label_baslik.Size = new Size(121, 15);
            label_baslik.TabIndex = 0;
            label_baslik.TabStop = true;
            label_baslik.Text = "ÜYE GİRİŞ PROGRAMI";
            // 
            // comboBox_nick_or_mail
            // 
            comboBox_nick_or_mail.FormattingEnabled = true;
            comboBox_nick_or_mail.Items.AddRange(new object[] { "Kullanıcı adı ile giriş yapmak istiyorum.", "E-posta adresim ile giriş yapmak istiyorum." });
            comboBox_nick_or_mail.Location = new Point(160, 109);
            comboBox_nick_or_mail.Name = "comboBox_nick_or_mail";
            comboBox_nick_or_mail.Size = new Size(212, 23);
            comboBox_nick_or_mail.TabIndex = 1;
            comboBox_nick_or_mail.SelectedIndexChanged += comboBox_nick_or_mail_SelectedIndexChanged;
            // 
            // label_imza
            // 
            label_imza.AutoSize = true;
            label_imza.Location = new Point(166, 437);
            label_imza.Name = "label_imza";
            label_imza.Size = new Size(174, 15);
            label_imza.TabIndex = 2;
            label_imza.Text = "Designed by Efe Emirhan Çelebi";
            // 
            // label_nick_or_mail
            // 
            label_nick_or_mail.AutoSize = true;
            label_nick_or_mail.Location = new Point(62, 141);
            label_nick_or_mail.Name = "label_nick_or_mail";
            label_nick_or_mail.Size = new Size(10, 15);
            label_nick_or_mail.TabIndex = 3;
            label_nick_or_mail.Text = " ";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(62, 170);
            label_password.Name = "label_password";
            label_password.Size = new Size(10, 15);
            label_password.TabIndex = 4;
            label_password.Text = " ";
            // 
            // textBox_nick_or_mail
            // 
            textBox_nick_or_mail.Location = new Point(160, 138);
            textBox_nick_or_mail.Name = "textBox_nick_or_mail";
            textBox_nick_or_mail.Size = new Size(212, 23);
            textBox_nick_or_mail.TabIndex = 5;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(160, 167);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(212, 23);
            textBox_password.TabIndex = 6;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(160, 196);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(103, 42);
            btn_giris.TabIndex = 7;
            btn_giris.Text = "Giriş yapmak için tıklayın.";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(269, 196);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(103, 42);
            btn_register.TabIndex = 8;
            btn_register.Text = "Kayıt olmak için tıklayın.";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // label_login_check
            // 
            label_login_check.AutoSize = true;
            label_login_check.Location = new Point(160, 250);
            label_login_check.Name = "label_login_check";
            label_login_check.Size = new Size(10, 15);
            label_login_check.TabIndex = 9;
            label_login_check.Text = " ";
            // 
            // label_login_options
            // 
            label_login_options.AutoSize = true;
            label_login_options.Location = new Point(62, 112);
            label_login_options.Name = "label_login_options";
            label_login_options.Size = new Size(10, 15);
            label_login_options.TabIndex = 11;
            label_login_options.Text = " ";
            // 
            // btn_register_comp
            // 
            btn_register_comp.Location = new Point(160, 296);
            btn_register_comp.Name = "btn_register_comp";
            btn_register_comp.Size = new Size(212, 42);
            btn_register_comp.TabIndex = 12;
            btn_register_comp.Text = " ";
            btn_register_comp.UseVisualStyleBackColor = true;
            btn_register_comp.Click += button1_Click;
            // 
            // comboBox_mail_types
            // 
            comboBox_mail_types.FormattingEnabled = true;
            comboBox_mail_types.Items.AddRange(new object[] { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com", "@icloud.com" });
            comboBox_mail_types.Location = new Point(378, 138);
            comboBox_mail_types.Name = "comboBox_mail_types";
            comboBox_mail_types.Size = new Size(94, 23);
            comboBox_mail_types.TabIndex = 13;
            comboBox_mail_types.SelectedIndexChanged += comboBox_mail_types_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(comboBox_mail_types);
            Controls.Add(btn_register_comp);
            Controls.Add(label_baslik);
            Controls.Add(label_login_options);
            Controls.Add(label_login_check);
            Controls.Add(btn_register);
            Controls.Add(btn_giris);
            Controls.Add(textBox_password);
            Controls.Add(textBox_nick_or_mail);
            Controls.Add(label_password);
            Controls.Add(label_nick_or_mail);
            Controls.Add(label_imza);
            Controls.Add(comboBox_nick_or_mail);
            Name = "Form1";
            Text = "Üye Giriş Programı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel label_baslik;
        private ComboBox comboBox_nick_or_mail;
        private Label label_imza;
        private Label label_nick_or_mail;
        private Label label_password;
        private TextBox textBox_nick_or_mail;
        private TextBox textBox_password;
        private Button btn_giris;
        private Button btn_register;
        private Label label_login_check;
        private Label label_login_options;
        private Button btn_register_comp;
        private ComboBox comboBox_mail_types;
    }
}
