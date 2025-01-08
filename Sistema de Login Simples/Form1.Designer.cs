namespace Sistema_de_Login_Simples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.botaoEntrar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.BorderColor = System.Drawing.Color.Black;
            this.Login.BorderRadius = 5;
            this.Login.BorderThickness = 0;
            this.Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login.DefaultText = "";
            this.Login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login.FillColor = System.Drawing.Color.Gainsboro;
            this.Login.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.Login.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(49, 158);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login.Name = "Login";
            this.Login.PasswordChar = '\0';
            this.Login.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Login.PlaceholderText = "NOME DE USUÁRIO";
            this.Login.SelectedText = "";
            this.Login.Size = new System.Drawing.Size(236, 42);
            this.Login.TabIndex = 0;
            this.Login.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Password
            // 
            this.Password.BorderColor = System.Drawing.Color.Black;
            this.Password.BorderRadius = 5;
            this.Password.BorderThickness = 0;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FillColor = System.Drawing.Color.Gainsboro;
            this.Password.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(49, 216);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Password.PlaceholderText = "SENHA";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(236, 42);
            this.Password.TabIndex = 1;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Enter += new System.EventHandler(this.Login_Enter);
            this.Password.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2CheckBox1.Location = new System.Drawing.Point(49, 317);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(84, 17);
            this.guna2CheckBox1.TabIndex = 4;
            this.guna2CheckBox1.Text = "Manter login";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(128, 128);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(128, 128);
            this.guna2ImageButton1.Location = new System.Drawing.Point(101, -1);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(128, 128);
            this.guna2ImageButton1.Size = new System.Drawing.Size(128, 83);
            this.guna2ImageButton1.TabIndex = 7;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.FocusedColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(88, 562);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.Size = new System.Drawing.Size(180, 21);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Não consegue fazer login?";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.FocusedColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(88, 589);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.White;
            this.guna2Button2.Size = new System.Drawing.Size(180, 21);
            this.guna2Button2.TabIndex = 9;
            this.guna2Button2.Text = "Criar conta";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton2.Location = new System.Drawing.Point(49, 274);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton2.Size = new System.Drawing.Size(32, 28);
            this.guna2ImageButton2.TabIndex = 10;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton3.Location = new System.Drawing.Point(101, 274);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton3.Size = new System.Drawing.Size(32, 28);
            this.guna2ImageButton3.TabIndex = 11;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.Image")));
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton4.Location = new System.Drawing.Point(152, 274);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton4.Size = new System.Drawing.Size(32, 28);
            this.guna2ImageButton4.TabIndex = 12;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton5.Image")));
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.Location = new System.Drawing.Point(205, 274);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.Size = new System.Drawing.Size(32, 28);
            this.guna2ImageButton5.TabIndex = 13;
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton6.Image")));
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton6.Location = new System.Drawing.Point(253, 274);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton6.Size = new System.Drawing.Size(32, 28);
            this.guna2ImageButton6.TabIndex = 14;
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.BackColor = System.Drawing.Color.Transparent;
            this.botaoEntrar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.botaoEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEntrar.HoverState.ImageSize = new System.Drawing.Size(80, 80);
            this.botaoEntrar.Image = ((System.Drawing.Image)(resources.GetObject("botaoEntrar.Image")));
            this.botaoEntrar.ImageOffset = new System.Drawing.Point(0, 0);
            this.botaoEntrar.ImageRotate = 0F;
            this.botaoEntrar.ImageSize = new System.Drawing.Size(80, 80);
            this.botaoEntrar.Location = new System.Drawing.Point(140, 413);
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.PressedState.ImageSize = new System.Drawing.Size(80, 80);
            this.botaoEntrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botaoEntrar.Size = new System.Drawing.Size(64, 64);
            this.botaoEntrar.TabIndex = 15;
            this.botaoEntrar.Click += new System.EventHandler(this.guna2ImageButton7_Click);
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton7.HoverState.ImageSize = new System.Drawing.Size(1080, 760);
            this.guna2ImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton7.Image")));
            this.guna2ImageButton7.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.ImageRotate = 0F;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(1080, 760);
            this.guna2ImageButton7.Location = new System.Drawing.Point(342, -1);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.PressedState.ImageSize = new System.Drawing.Size(1080, 760);
            this.guna2ImageButton7.Size = new System.Drawing.Size(752, 659);
            this.guna2ImageButton7.TabIndex = 16;
            this.guna2ImageButton7.Click += new System.EventHandler(this.guna2ImageButton7_Click_1);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 650);
            this.Controls.Add(this.guna2ImageButton7);
            this.Controls.Add(this.botaoEntrar);
            this.Controls.Add(this.guna2ImageButton6);
            this.Controls.Add(this.guna2ImageButton5);
            this.Controls.Add(this.guna2ImageButton4);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2TextBox Login;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2ImageButton botaoEntrar;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
    }
}

