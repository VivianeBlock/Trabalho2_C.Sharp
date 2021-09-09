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

namespace TesteDeTrabalho02.View
{
    public partial class Texto : Form
    {

        public Texto()
        {
            InitializeComponent();
        }
       /// <summary>
       /// volta para o jogo ao clicar em voltar
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.FindForm().Hide();
            f.Show();
        }

        
    }
}
