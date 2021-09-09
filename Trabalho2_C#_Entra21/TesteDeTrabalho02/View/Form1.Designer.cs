
namespace TesteDeTrabalho02
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
            this.btnAd = new System.Windows.Forms.Button();
            this.btnGiu = new System.Windows.Forms.Button();
            this.btnMOQ = new System.Windows.Forms.Button();
            this.btnEf = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnNtp = new System.Windows.Forms.Button();
            this.btnBc = new System.Windows.Forms.Button();
            this.btnKl = new System.Windows.Forms.Button();
            this.btnRsz = new System.Windows.Forms.Button();
            this.lbAB = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHJV = new System.Windows.Forms.Button();
            this.dtgMostrarPontos = new System.Windows.Forms.DataGridView();
            this.Palavrascoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pontoscoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarPontos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAd
            // 
            this.btnAd.BackColor = System.Drawing.Color.LightBlue;
            this.btnAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAd.Location = new System.Drawing.Point(99, 126);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(107, 54);
            this.btnAd.TabIndex = 0;
            this.btnAd.Text = "A ou D";
            this.btnAd.UseVisualStyleBackColor = false;
            this.btnAd.Click += new System.EventHandler(this.btnAB_Click);
            // 
            // btnGiu
            // 
            this.btnGiu.BackColor = System.Drawing.Color.LightBlue;
            this.btnGiu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiu.Location = new System.Drawing.Point(99, 175);
            this.btnGiu.Name = "btnGiu";
            this.btnGiu.Size = new System.Drawing.Size(107, 50);
            this.btnGiu.TabIndex = 1;
            this.btnGiu.Text = "G ou I ou U";
            this.btnGiu.UseVisualStyleBackColor = false;
            // 
            // btnMOQ
            // 
            this.btnMOQ.BackColor = System.Drawing.Color.LightBlue;
            this.btnMOQ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMOQ.Location = new System.Drawing.Point(99, 220);
            this.btnMOQ.Name = "btnMOQ";
            this.btnMOQ.Size = new System.Drawing.Size(107, 47);
            this.btnMOQ.TabIndex = 2;
            this.btnMOQ.Text = "M ou O ou Q";
            this.btnMOQ.UseVisualStyleBackColor = false;
            // 
            // btnEf
            // 
            this.btnEf.BackColor = System.Drawing.Color.LightBlue;
            this.btnEf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEf.Location = new System.Drawing.Point(195, 126);
            this.btnEf.Name = "btnEf";
            this.btnEf.Size = new System.Drawing.Size(109, 53);
            this.btnEf.TabIndex = 3;
            this.btnEf.Text = "E ou F";
            this.btnEf.UseVisualStyleBackColor = false;
            // 
            // btnResetar
            // 
            this.btnResetar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnResetar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetar.Location = new System.Drawing.Point(23, 12);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(195, 45);
            this.btnResetar.TabIndex = 19;
            this.btnResetar.Text = "Novo Caça-Palavras!";
            this.btnResetar.UseVisualStyleBackColor = false;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnNtp
            // 
            this.btnNtp.BackColor = System.Drawing.Color.LightBlue;
            this.btnNtp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNtp.Location = new System.Drawing.Point(195, 219);
            this.btnNtp.Name = "btnNtp";
            this.btnNtp.Size = new System.Drawing.Size(109, 48);
            this.btnNtp.TabIndex = 5;
            this.btnNtp.Text = "N ou T ou P";
            this.btnNtp.UseVisualStyleBackColor = false;
            // 
            // btnBc
            // 
            this.btnBc.BackColor = System.Drawing.Color.LightBlue;
            this.btnBc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBc.Location = new System.Drawing.Point(293, 126);
            this.btnBc.Name = "btnBc";
            this.btnBc.Size = new System.Drawing.Size(112, 53);
            this.btnBc.TabIndex = 6;
            this.btnBc.Text = "B ou C";
            this.btnBc.UseVisualStyleBackColor = false;
            // 
            // btnKl
            // 
            this.btnKl.BackColor = System.Drawing.Color.LightBlue;
            this.btnKl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKl.Location = new System.Drawing.Point(293, 174);
            this.btnKl.Name = "btnKl";
            this.btnKl.Size = new System.Drawing.Size(112, 50);
            this.btnKl.TabIndex = 7;
            this.btnKl.Text = "K ou L";
            this.btnKl.UseVisualStyleBackColor = false;
            // 
            // btnRsz
            // 
            this.btnRsz.BackColor = System.Drawing.Color.LightBlue;
            this.btnRsz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRsz.Location = new System.Drawing.Point(293, 219);
            this.btnRsz.Name = "btnRsz";
            this.btnRsz.Size = new System.Drawing.Size(112, 48);
            this.btnRsz.TabIndex = 8;
            this.btnRsz.Text = "R ou S ou Z";
            this.btnRsz.UseVisualStyleBackColor = false;
            // 
            // lbAB
            // 
            this.lbAB.AutoSize = true;
            this.lbAB.BackColor = System.Drawing.Color.Transparent;
            this.lbAB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAB.ForeColor = System.Drawing.Color.Black;
            this.lbAB.Location = new System.Drawing.Point(127, 336);
            this.lbAB.Name = "lbAB";
            this.lbAB.Size = new System.Drawing.Size(71, 30);
            this.lbAB.TabIndex = 10;
            this.lbAB.Text = "Letras";
            this.lbAB.Click += new System.EventHandler(this.lbAB_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.GhostWhite;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(302, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(195, 45);
            this.button11.TabIndex = 12;
            this.button11.Text = "Como Jogar?";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(143, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Escreva a sua palavra:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(198, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Caçar a palavra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(394, 676);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 34);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Encerrar ";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHJV
            // 
            this.btnHJV.BackColor = System.Drawing.Color.LightBlue;
            this.btnHJV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHJV.Location = new System.Drawing.Point(195, 175);
            this.btnHJV.Name = "btnHJV";
            this.btnHJV.Size = new System.Drawing.Size(109, 50);
            this.btnHJV.TabIndex = 4;
            this.btnHJV.Text = "H ou J ou V";
            this.btnHJV.UseVisualStyleBackColor = false;
            // 
            // dtgMostrarPontos
            // 
            this.dtgMostrarPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostrarPontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Palavrascoll,
            this.Pontoscoll});
            this.dtgMostrarPontos.Location = new System.Drawing.Point(127, 509);
            this.dtgMostrarPontos.Name = "dtgMostrarPontos";
            this.dtgMostrarPontos.RowTemplate.Height = 25;
            this.dtgMostrarPontos.Size = new System.Drawing.Size(240, 170);
            this.dtgMostrarPontos.TabIndex = 21;
            // 
            // Palavrascoll
            // 
            this.Palavrascoll.HeaderText = "Palavras";
            this.Palavrascoll.Name = "Palavrascoll";
            // 
            // Pontoscoll
            // 
            this.Pontoscoll.HeaderText = "Pontos";
            this.Pontoscoll.Name = "Pontoscoll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(127, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Historico:";
            // 
            // txtLetras
            // 
            this.txtLetras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetras.Location = new System.Drawing.Point(127, 378);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(240, 23);
            this.txtLetras.TabIndex = 24;
            this.txtLetras.TextChanged += new System.EventHandler(this.txtLetras_TextChanged);
            this.txtLetras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLetras_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(99, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pontos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(186, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(186, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 722);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgMostrarPontos);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.lbAB);
            this.Controls.Add(this.btnRsz);
            this.Controls.Add(this.btnKl);
            this.Controls.Add(this.btnBc);
            this.Controls.Add(this.btnNtp);
            this.Controls.Add(this.btnHJV);
            this.Controls.Add(this.btnEf);
            this.Controls.Add(this.btnMOQ);
            this.Controls.Add(this.btnGiu);
            this.Controls.Add(this.btnAd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarPontos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.Button btnGiu;
        private System.Windows.Forms.Button btnMOQ;
        private System.Windows.Forms.Button btnEf;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnNtp;
        private System.Windows.Forms.Button btnBc;
        private System.Windows.Forms.Button btnKl;
        private System.Windows.Forms.Button btnRsz;
        private System.Windows.Forms.Label lbAB;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHJV;
        private System.Windows.Forms.DataGridView dtgMostrarPontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Palavrascoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pontoscoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

