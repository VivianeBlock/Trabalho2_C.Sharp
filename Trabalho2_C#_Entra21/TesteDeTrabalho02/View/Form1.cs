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
            GerarBotoes();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
        }
        private void lbAB_Click(object sender, EventArgs e)
        {
            lbAB.Text = "";
        }
        /// <summary>
        /// Ao clicar encerra o jogos e mostra uma menssagem de agradecimento
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valeu a partida! Até a próxima :)");
            Environment.Exit(1);
        }
        /// <summary>
        /// Ao clicar limpa p data grid,limpa a text box e gera novos botões de letras.
        /// </summary>
        private void btnResetar_Click(object sender, EventArgs e)
        {
            GerarBotoes();
            txtLetras.Clear();
            dtgMostrarPontos.Rows.Clear();
        }
        /// <summary>
        /// ao clicar recebe a palavra inserida na text box e faz a conferencia e mostra no data grid a palavra e os pontos.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            MostraDataGrid();
        }


        private void txtLetras_TextChanged(object sender, EventArgs e)
        {
            lbAB.Text = txtLetras.Text.ToUpper();
        }

        /// <summary>
        /// ao dititar a tecla Enter recebe a palavra inserida na text box e faz a conferencia e mostra no data grid a palavra e os pontos.
        /// </summary>
        private void txtLetras_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MostraDataGrid();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Soma os todos os pontos e mostra o total na label
        /// </summary>
        private void SomaPonto(int ponto)
        {
            int aux = Convert.ToInt32(label5.Text);
            aux += ponto;
            label5.Text = Convert.ToString(aux);
        }
        /// <summary>
        /// Ao clicar exibe uma tela de ajuda interativa sobre o jogo.
        /// </summary>
        private void button11_Click(object sender, EventArgs e)
        {
            Texto f = new Texto();
            this.FindForm().Hide();
            f.Show();
        }
        /// <summary>
        /// Recebe as letras e preenche os os noves botõe. 
        /// </summary>
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

            lbAB.Text = " ";
        }
        /// <summary>
        /// Função ultilizada para formar o degradê da tela inicial.
        /// </summary>
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            //RGB vermelho verde azul
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(108, 226, 252), Color.FromArgb(255, 177, 235), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }
        /// <summary>
        /// Confere se recebe a palavra inserida e faz a conferencia e mostra no data grid  a palavra e os pontos.
        /// </summary>
            List<string> palavarasProntas = new List<string>();
        private void MostraDataGrid()
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
                                int pontos = Controllers.GerandoPonto(lbAB.Text);
                                SomaPonto(pontos);
                                dtgMostrarPontos.Rows.Add(lbAB.Text, pontos);
                                palavarasProntas.Add(lbAB.Text);


                            }
                        }
                    }

                }
            }
            txtLetras.Clear();
        }
    }

}

