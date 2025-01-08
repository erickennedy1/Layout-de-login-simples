using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;


namespace Sistema_de_Login_Simples
{
    
    public partial class Form1 : Form
    {
        private Image botaoAtivaImage;
        private Image botaoDesativaImage;
        private Image botaoHoverImage;
        private bool isButtonActive = false; 

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Button1.MouseEnter += Guna2Button1_MouseEnter;
            guna2Button1.MouseLeave += Guna2Button1_MouseLeave;
            guna2Button2.MouseEnter += Guna2Button2_MouseEnter;
            guna2Button2.MouseLeave += Guna2Button2_MouseLeave;

            try
            {
                botaoAtivaImage = Image.FromFile("C:\\Users\\Eric\\Documents\\Portfolio 2025\\Sistema de Login Simples\\Sistema de Login Simples\\Imagens\\botaoAtiva.png");
                botaoDesativaImage = Image.FromFile("C:\\Users\\Eric\\Documents\\Portfolio 2025\\Sistema de Login Simples\\Sistema de Login Simples\\Imagens\\botaoDesativa.png");
                botaoHoverImage = Image.FromFile("C:\\Users\\Eric\\Documents\\Portfolio 2025\\Sistema de Login Simples\\Sistema de Login Simples\\Imagens\\botaoHover.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as imagens: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Login.TextChanged += (s, ev) => UpdateImageButton();
            Password.TextChanged += (s, ev) => UpdateImageButton();

            ConfigureButtonHover();

            UpdateImageButton();
        }

        private void ConfigureButtonHover()
        {
            botaoEntrar.MouseEnter += (s, e) =>
            {
                if (isButtonActive)
                {
                    botaoEntrar.Image = botaoHoverImage; 
                }
            };


            botaoEntrar.MouseLeave += (s, e) =>
            {
                if (isButtonActive)
                {
                    botaoEntrar.Image = botaoAtivaImage; 
                }
            };
        }


        private void UpdateImageButton()
        {
            if (!string.IsNullOrWhiteSpace(Login.Text) && !string.IsNullOrWhiteSpace(Password.Text))
            {
                botaoEntrar.Image = botaoAtivaImage; 
                isButtonActive = true; 
            }
            else
            {
                botaoEntrar.Image = botaoDesativaImage; 
                isButtonActive = false;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateImageButton(); 
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateImageButton(); 
        }


        private void Login_Enter(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (textBox != null)
            {
                textBox.BorderThickness = 2; 
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (textBox != null)
            {
                textBox.BorderThickness = 0;
            }
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            string url = "https://accounts.google.com/o/oauth2/v2/auth/oauthchooseaccount?client_id=187685766663-ct6bdnthcq6jlllecpg1guhthoc7i8vv.apps.googleusercontent.com&redirect_uri=https%3A%2F%2Fauthenticate.riotgames.com%2Fredirects%2Fgoogle&state=f32774b3c892ea7e647e0f31e75ff738e4d126c5e9014c49dd7a6d43a0a4&response_type=code&access_type=online&prompt=select_account&scope=openid%20profile%20email&service=lso&o2v=2&ddm=1&flowName=GeneralOAuthFlow"; // Substitua pelo URL desejado

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o site: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            Form2 novaJanela = new Form2();

            novaJanela.UpdateLabelText("Agora só falta programar todo o jogo");

            novaJanela.ShowDialog(); 
        }


        private void guna2ImageButton7_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = "https://recovery.riotgames.com/pt-br?region=BR1"; 

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o site: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string url = "https://authenticate.riotgames.com/?client_id=prod-xsso-leagueoflegends&code_challenge=93cNLr0gjXQxfeqhptdOq8akh97CwXds1LjGjfGyxGg&method=riot_identity_signup&platform=web&redirect_uri=https%3A%2F%2Fauth.riotgames.com%2Fauthorize%3Fclient_id%3Dprod-xsso-leagueoflegends%26code_challenge%3D93cNLr0gjXQxfeqhptdOq8akh97CwXds1LjGjfGyxGg%26code_challenge_method%3DS256%26prompt%3Dsignup%26redirect_uri%3Dhttps%3A%2F%2Fxsso.leagueoflegends.com%2Fredirect%26response_type%3Dcode%26scope%3Dopenid%2520account%2520email%2520offline_access%26state%3De097ee063b627a12c00ccaaf9e%26uri%3Dhttps%3A%2F%2Fsignup.leagueoflegends.com%2Fpt%2Fsignup%2Fredownload"; // Substitua pelo URL desejado

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o site: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.ForeColor = Color.Black;
        }

        private void Guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.ForeColor = Color.Gray; 
        }

        private void Guna2Button2_MouseEnter(object sender, EventArgs e)
        {
            guna2Button2.ForeColor = Color.Black;
        }

        private void Guna2Button2_MouseLeave(object sender, EventArgs e)
        {
            guna2Button2.ForeColor = Color.Gray;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/privacy/consent/gdp/?params%5Bapp_id%5D=344190606773871&params%5Bkid_directed_site%5D=false&params%5Blogger_id%5D=%22f53798d8-a89e-4f4c-a296-0b5d876848b8%22&params%5Bnext%5D=%22read%22&params%5Bredirect_uri%5D=%22https%3A%5C%2F%5C%2Fauthenticate.riotgames.com%5C%2Fredirects%5C%2Ffacebook%22&params%5Breturn_scopes%5D=false&params%5Bscope%5D=%5B%22email%22%5D&params%5Bstate%5D=%2207d94017d9fbc6dddba5a7cdce8363a9858e7ece3a4152b3d4bf5231abeb%22&params%5Bsteps%5D=%7B%22read%22%3A%5B%22email%22%2C%22baseline%22%2C%22public_profile%22%5D%7D&params%5Btp%5D=%22unspecified%22&params%5Bcui_gk%5D=%22%5BPASS%5D%3A%22&params%5Bis_limited_login_shim%5D=false&source=gdp_delegated"; // Substitua pelo URL desejado

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o site: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
