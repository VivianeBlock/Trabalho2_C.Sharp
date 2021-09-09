using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteDeTrabalho02.View;

namespace TesteDeTrabalho02
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GerarListaPalavras();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void btnAB_Click(object sender, EventArgs e)
        {

            lbAB.Text += btnAd.Text;
            btnAd.Enabled = false;
            btnAd.BackColor = Color.Red;

        }
        private void lbAB_Click(object sender, EventArgs e)
        {
            lbAB.Text = "";
        }



        private void GerarBotoes()
        {

            List<string> let = Controllers.ListaBotoes();
            btnAd.Text = let[0].ToString();
            btnEf.Text = let[1].ToString();
            btnBc.Text = let[2].ToString();
            btnGiu.Text = let[3].ToString();
            btnHJV.Text = let[4].ToString();
            btnKl.Text = let[5].ToString();
            btnMOQ.Text = let[6].ToString();
            btnNtp.Text = let[7].ToString();
            btnRsz.Text = let[8].ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valeu a partida! Até a próxima :)");
            Environment.Exit(1);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbAB.Text);
        }

        private void btnMostrarrr_Click(object sender, EventArgs e)
        {


        }

        private void btnResetar_Click(object sender, EventArgs e)
        {

            GerarListaPalavras();
            GerarBotoes();
            txtLetras.Clear();
            dtgMostrarPontos.Rows.Clear();
        }
        private void GerarListaPalavras()
        {


            lbAB.Text = " ";

            GerarBotoes();

            btnAd.BackColor = Color.LightBlue;
            btnRsz.BackColor = Color.LightBlue;
            btnNtp.BackColor = Color.LightBlue;
            btnMOQ.BackColor = Color.LightBlue;
            btnKl.BackColor = Color.LightBlue;
            btnHJV.BackColor = Color.LightBlue;
            btnBc.BackColor = Color.LightBlue;
            btnEf.BackColor = Color.LightBlue;
            btnGiu.BackColor = Color.LightBlue;

            btnAd.Enabled = true;
            btnRsz.Enabled = true;
            btnNtp.Enabled = true;
            btnMOQ.Enabled = true;
            btnKl.Enabled = true;
            btnHJV.Enabled = true;
            btnBc.Enabled = true;
            btnEf.Enabled = true;
            btnGiu.Enabled = true;
        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            //RGB vermelho verde azul
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(108, 226, 252), Color.FromArgb(255, 177, 235), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            char[] conf = lbAB.Text.ToCharArray();
            List<string> vetorPalavras = new List<string>();
            foreach (var item in conf)
            {
                vetorPalavras.Add(item.ToString());
            }

            string pala = lbAB.Text;

            List<string> palavarasProntas = new List<string>();
            palavarasProntas.Add(pala);
            foreach (var item in palavarasProntas)
            {
                dtgMostrarPontos.Rows.Add(item);
            }

            txtLetras.Clear();

        }


        private void txtLetras_TextChanged(object sender, EventArgs e)
        {
            lbAB.Text = txtLetras.Text.ToUpper();
        }


        List<string> palavarasProntas = new List<string>(); 
        private void txtLetras_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                char[] conf = lbAB.Text.ToCharArray();
                List<string> temp = new List<string>();
                foreach (var item in conf)
                {
                    temp.Add(item.ToString());
                }
                bool cond = false;
                if (txtLetras.Text != "")
                {
                    cond = Controllers.LetraExiste(lbAB.Text);
                    if (cond)
                    {
                        MessageBox.Show("Essa Letra não vale");
                        temp.Remove(lbAB.Text);
                    }
                    else
                    {
                        cond = Controllers.ConferindoLetras(lbAB.Text);// confere se tem letras repetidas na palavra
                        if (cond)
                        {
                            MessageBox.Show("Palavra com letras repetidas! isso não vale!");
                            temp.Remove(lbAB.Text);
                        }
                        else
                        {
                            cond = Controllers.BuscandoNaLista(palavarasProntas, lbAB.Text);
                            if (cond)
                            {
                                MessageBox.Show("Essa Palavra já foi encontrada! Tente outra...");
                                temp.Remove(lbAB.Text);
                            }
                            else
                            {
                                cond = Controllers.LetrasPermitidas(lbAB.Text);
                                if (cond)
                                {
                                    MessageBox.Show("As letras devem ser vizinhas!!!");
                                    temp.Remove(lbAB.Text);
                                }
                                else
                                {
                                    int pontos = Controllers.GerandoPonto(txtLetras.Text);
                                    SomaPonto(pontos);
                                    dtgMostrarPontos.Rows.Add(txtLetras.Text, pontos);
                                    palavarasProntas.Add(txtLetras.Text);
                                    

                                }
                            }
                        }

                    }
                }
                txtLetras.Clear();
            }
        }


        private void  SomaPonto(int ponto)
        {
           int aux = Convert.ToInt32(label5.Text);
            aux += ponto;
            label5.Text = Convert.ToString(aux);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            Texto f = new Texto();
            this.FindForm().Hide();
            f.Show();
        }

        
    }
}