namespace Cafeteira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.pcbIMG_fundo = new System.Windows.Forms.PictureBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnRetirarSaldo = new System.Windows.Forms.Button();
            this.btnInserirMoedas = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn10Cent = new System.Windows.Forms.Button();
            this.btn25Cent = new System.Windows.Forms.Button();
            this.btn50Cent = new System.Windows.Forms.Button();
            this.btn5Cent = new System.Windows.Forms.Button();
            this.btn1real = new System.Windows.Forms.Button();
            this.btnComum = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnCapuccino = new System.Windows.Forms.Button();
            this.btnChocolate = new System.Windows.Forms.Button();
            this.btnBaunilha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNivelAcu = new System.Windows.Forms.Label();
            this.btnAcu_Mais = new System.Windows.Forms.Button();
            this.fundoNivel = new System.Windows.Forms.Panel();
            this.btnAcu_Menos = new System.Windows.Forms.Button();
            this.grbMoedas = new System.Windows.Forms.Panel();
            this.gifCaneca = new System.Windows.Forms.PictureBox();
            this.lblVisor = new System.Windows.Forms.Label();
            this.btnCaneca = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.fundoSemCaneca = new System.Windows.Forms.PictureBox();
            this.lblTempoGif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTempoGIF_Menos = new System.Windows.Forms.Label();
            this.btnTempoGIF_Mais = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIMG_fundo)).BeginInit();
            this.fundoNivel.SuspendLayout();
            this.grbMoedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifCaneca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoSemCaneca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLigar.FlatAppearance.BorderSize = 0;
            this.btnLigar.Location = new System.Drawing.Point(63, 317);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(38, 16);
            this.btnLigar.TabIndex = 0;
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackColor = System.Drawing.Color.Red;
            this.btnDesligar.Location = new System.Drawing.Point(102, 317);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(38, 16);
            this.btnDesligar.TabIndex = 5;
            this.btnDesligar.UseVisualStyleBackColor = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // pcbIMG_fundo
            // 
            this.pcbIMG_fundo.Image = ((System.Drawing.Image)(resources.GetObject("pcbIMG_fundo.Image")));
            this.pcbIMG_fundo.Location = new System.Drawing.Point(148, 74);
            this.pcbIMG_fundo.Name = "pcbIMG_fundo";
            this.pcbIMG_fundo.Size = new System.Drawing.Size(148, 256);
            this.pcbIMG_fundo.TabIndex = 6;
            this.pcbIMG_fundo.TabStop = false;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Black;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSaldo.Location = new System.Drawing.Point(315, 249);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(74, 20);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "R$ 99,99";
            this.lblSaldo.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRetirarSaldo
            // 
            this.btnRetirarSaldo.BackColor = System.Drawing.Color.Transparent;
            this.btnRetirarSaldo.FlatAppearance.BorderSize = 0;
            this.btnRetirarSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRetirarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirarSaldo.Location = new System.Drawing.Point(313, 317);
            this.btnRetirarSaldo.Name = "btnRetirarSaldo";
            this.btnRetirarSaldo.Size = new System.Drawing.Size(36, 8);
            this.btnRetirarSaldo.TabIndex = 9;
            this.btnRetirarSaldo.UseVisualStyleBackColor = false;
            this.btnRetirarSaldo.Click += new System.EventHandler(this.btnRetirarSaldo_Click);
            // 
            // btnInserirMoedas
            // 
            this.btnInserirMoedas.BackColor = System.Drawing.Color.Transparent;
            this.btnInserirMoedas.FlatAppearance.BorderSize = 0;
            this.btnInserirMoedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirMoedas.Location = new System.Drawing.Point(350, 317);
            this.btnInserirMoedas.Name = "btnInserirMoedas";
            this.btnInserirMoedas.Size = new System.Drawing.Size(36, 8);
            this.btnInserirMoedas.TabIndex = 10;
            this.btnInserirMoedas.UseVisualStyleBackColor = false;
            this.btnInserirMoedas.Click += new System.EventHandler(this.btnInserirMoedas_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.Location = new System.Drawing.Point(66, 68);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btn10Cent
            // 
            this.btn10Cent.BackColor = System.Drawing.Color.Gainsboro;
            this.btn10Cent.Location = new System.Drawing.Point(66, 39);
            this.btn10Cent.Name = "btn10Cent";
            this.btn10Cent.Size = new System.Drawing.Size(53, 23);
            this.btn10Cent.TabIndex = 4;
            this.btn10Cent.Text = "0.10";
            this.btn10Cent.UseVisualStyleBackColor = false;
            this.btn10Cent.Click += new System.EventHandler(this.adicionaMoedas);
            // 
            // btn25Cent
            // 
            this.btn25Cent.BackColor = System.Drawing.Color.Gainsboro;
            this.btn25Cent.Location = new System.Drawing.Point(6, 39);
            this.btn25Cent.Name = "btn25Cent";
            this.btn25Cent.Size = new System.Drawing.Size(53, 23);
            this.btn25Cent.TabIndex = 3;
            this.btn25Cent.Text = "0.25";
            this.btn25Cent.UseVisualStyleBackColor = false;
            this.btn25Cent.Click += new System.EventHandler(this.adicionaMoedas);
            // 
            // btn50Cent
            // 
            this.btn50Cent.BackColor = System.Drawing.Color.Gainsboro;
            this.btn50Cent.Location = new System.Drawing.Point(65, 9);
            this.btn50Cent.Name = "btn50Cent";
            this.btn50Cent.Size = new System.Drawing.Size(53, 23);
            this.btn50Cent.TabIndex = 2;
            this.btn50Cent.Text = "0.50";
            this.btn50Cent.UseVisualStyleBackColor = false;
            this.btn50Cent.Click += new System.EventHandler(this.adicionaMoedas);
            // 
            // btn5Cent
            // 
            this.btn5Cent.BackColor = System.Drawing.Color.Gainsboro;
            this.btn5Cent.Location = new System.Drawing.Point(6, 68);
            this.btn5Cent.Name = "btn5Cent";
            this.btn5Cent.Size = new System.Drawing.Size(53, 23);
            this.btn5Cent.TabIndex = 1;
            this.btn5Cent.Text = "0.05";
            this.btn5Cent.UseVisualStyleBackColor = false;
            this.btn5Cent.Click += new System.EventHandler(this.adicionaMoedas);
            // 
            // btn1real
            // 
            this.btn1real.BackColor = System.Drawing.Color.Gainsboro;
            this.btn1real.Location = new System.Drawing.Point(6, 9);
            this.btn1real.Name = "btn1real";
            this.btn1real.Size = new System.Drawing.Size(53, 23);
            this.btn1real.TabIndex = 0;
            this.btn1real.Text = "1.00";
            this.btn1real.UseVisualStyleBackColor = false;
            this.btn1real.Click += new System.EventHandler(this.adicionaMoedas);
            // 
            // btnComum
            // 
            this.btnComum.BackColor = System.Drawing.Color.Transparent;
            this.btnComum.FlatAppearance.BorderSize = 0;
            this.btnComum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnComum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComum.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComum.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnComum.Location = new System.Drawing.Point(153, 81);
            this.btnComum.Name = "btnComum";
            this.btnComum.Size = new System.Drawing.Size(18, 20);
            this.btnComum.TabIndex = 12;
            this.btnComum.Text = "1";
            this.btnComum.UseVisualStyleBackColor = false;
            this.btnComum.Click += new System.EventHandler(this.cafeEscolhido);
            this.btnComum.MouseEnter += new System.EventHandler(this.mouseEnterButtons);
            this.btnComum.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.Transparent;
            this.btnDouble.FlatAppearance.BorderSize = 0;
            this.btnDouble.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDouble.Location = new System.Drawing.Point(153, 137);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(20, 20);
            this.btnDouble.TabIndex = 13;
            this.btnDouble.Text = "2";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.cafeEscolhido);
            this.btnDouble.MouseEnter += new System.EventHandler(this.mouseEnterButtons);
            this.btnDouble.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            // 
            // btnCapuccino
            // 
            this.btnCapuccino.BackColor = System.Drawing.Color.Transparent;
            this.btnCapuccino.FlatAppearance.BorderSize = 0;
            this.btnCapuccino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCapuccino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapuccino.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCapuccino.Location = new System.Drawing.Point(153, 193);
            this.btnCapuccino.Name = "btnCapuccino";
            this.btnCapuccino.Size = new System.Drawing.Size(20, 20);
            this.btnCapuccino.TabIndex = 14;
            this.btnCapuccino.Text = "3";
            this.btnCapuccino.UseVisualStyleBackColor = false;
            this.btnCapuccino.Click += new System.EventHandler(this.cafeEscolhido);
            this.btnCapuccino.MouseEnter += new System.EventHandler(this.mouseEnterButtons);
            this.btnCapuccino.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            // 
            // btnChocolate
            // 
            this.btnChocolate.BackColor = System.Drawing.Color.Transparent;
            this.btnChocolate.FlatAppearance.BorderSize = 0;
            this.btnChocolate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnChocolate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChocolate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnChocolate.Location = new System.Drawing.Point(153, 249);
            this.btnChocolate.Name = "btnChocolate";
            this.btnChocolate.Size = new System.Drawing.Size(20, 20);
            this.btnChocolate.TabIndex = 15;
            this.btnChocolate.Text = "4";
            this.btnChocolate.UseVisualStyleBackColor = false;
            this.btnChocolate.Click += new System.EventHandler(this.cafeEscolhido);
            this.btnChocolate.MouseEnter += new System.EventHandler(this.mouseEnterButtons);
            this.btnChocolate.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            // 
            // btnBaunilha
            // 
            this.btnBaunilha.BackColor = System.Drawing.Color.Transparent;
            this.btnBaunilha.FlatAppearance.BorderSize = 0;
            this.btnBaunilha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBaunilha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaunilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaunilha.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBaunilha.Location = new System.Drawing.Point(153, 305);
            this.btnBaunilha.Name = "btnBaunilha";
            this.btnBaunilha.Size = new System.Drawing.Size(20, 20);
            this.btnBaunilha.TabIndex = 16;
            this.btnBaunilha.Text = "5";
            this.btnBaunilha.UseVisualStyleBackColor = false;
            this.btnBaunilha.Click += new System.EventHandler(this.cafeEscolhido);
            this.btnBaunilha.MouseEnter += new System.EventHandler(this.mouseEnterButtons);
            this.btnBaunilha.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(37, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Açucar";
            // 
            // lblNivelAcu
            // 
            this.lblNivelAcu.AutoSize = true;
            this.lblNivelAcu.BackColor = System.Drawing.Color.Transparent;
            this.lblNivelAcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcu.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNivelAcu.Location = new System.Drawing.Point(3, 1);
            this.lblNivelAcu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.lblNivelAcu.Name = "lblNivelAcu";
            this.lblNivelAcu.Size = new System.Drawing.Size(44, 16);
            this.lblNivelAcu.TabIndex = 29;
            this.lblNivelAcu.Text = "||| ||| ||| ";
            // 
            // btnAcu_Mais
            // 
            this.btnAcu_Mais.BackColor = System.Drawing.Color.Transparent;
            this.btnAcu_Mais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcu_Mais.BackgroundImage")));
            this.btnAcu_Mais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAcu_Mais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcu_Mais.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcu_Mais.ForeColor = System.Drawing.Color.Black;
            this.btnAcu_Mais.Location = new System.Drawing.Point(123, 249);
            this.btnAcu_Mais.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcu_Mais.Name = "btnAcu_Mais";
            this.btnAcu_Mais.Size = new System.Drawing.Size(17, 21);
            this.btnAcu_Mais.TabIndex = 27;
            this.btnAcu_Mais.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAcu_Mais.UseVisualStyleBackColor = false;
            this.btnAcu_Mais.Click += new System.EventHandler(this.btnAcu_Mais_Click);
            this.btnAcu_Mais.MouseEnter += new System.EventHandler(this.mouseEnterButtons);
            this.btnAcu_Mais.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            // 
            // fundoNivel
            // 
            this.fundoNivel.BackColor = System.Drawing.Color.Black;
            this.fundoNivel.Controls.Add(this.lblNivelAcu);
            this.fundoNivel.Location = new System.Drawing.Point(31, 249);
            this.fundoNivel.Margin = new System.Windows.Forms.Padding(0);
            this.fundoNivel.Name = "fundoNivel";
            this.fundoNivel.Size = new System.Drawing.Size(82, 22);
            this.fundoNivel.TabIndex = 33;
            // 
            // btnAcu_Menos
            // 
            this.btnAcu_Menos.BackColor = System.Drawing.Color.Transparent;
            this.btnAcu_Menos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcu_Menos.BackgroundImage")));
            this.btnAcu_Menos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAcu_Menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcu_Menos.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcu_Menos.ForeColor = System.Drawing.Color.Black;
            this.btnAcu_Menos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcu_Menos.Location = new System.Drawing.Point(10, 249);
            this.btnAcu_Menos.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcu_Menos.Name = "btnAcu_Menos";
            this.btnAcu_Menos.Size = new System.Drawing.Size(17, 21);
            this.btnAcu_Menos.TabIndex = 34;
            this.btnAcu_Menos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAcu_Menos.UseVisualStyleBackColor = false;
            this.btnAcu_Menos.Click += new System.EventHandler(this.btnAcu_Menos_Click);
            this.btnAcu_Menos.MouseEnter += new System.EventHandler(this.btnAssuMenosEnter);
            this.btnAcu_Menos.MouseLeave += new System.EventHandler(this.btnAssuMenosLeave);
            // 
            // grbMoedas
            // 
            this.grbMoedas.BackColor = System.Drawing.Color.DimGray;
            this.grbMoedas.Controls.Add(this.btnOK);
            this.grbMoedas.Controls.Add(this.btn1real);
            this.grbMoedas.Controls.Add(this.btn10Cent);
            this.grbMoedas.Controls.Add(this.btn5Cent);
            this.grbMoedas.Controls.Add(this.btn25Cent);
            this.grbMoedas.Controls.Add(this.btn50Cent);
            this.grbMoedas.Location = new System.Drawing.Point(313, 116);
            this.grbMoedas.Margin = new System.Windows.Forms.Padding(0);
            this.grbMoedas.Name = "grbMoedas";
            this.grbMoedas.Size = new System.Drawing.Size(122, 97);
            this.grbMoedas.TabIndex = 34;
            // 
            // gifCaneca
            // 
            this.gifCaneca.Image = ((System.Drawing.Image)(resources.GetObject("gifCaneca.Image")));
            this.gifCaneca.Location = new System.Drawing.Point(59, 349);
            this.gifCaneca.Name = "gifCaneca";
            this.gifCaneca.Size = new System.Drawing.Size(335, 185);
            this.gifCaneca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gifCaneca.TabIndex = 35;
            this.gifCaneca.TabStop = false;
            this.gifCaneca.Visible = false;
            // 
            // lblVisor
            // 
            this.lblVisor.AutoSize = true;
            this.lblVisor.BackColor = System.Drawing.Color.Black;
            this.lblVisor.Font = new System.Drawing.Font("fm3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVisor.Location = new System.Drawing.Point(167, 537);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(122, 23);
            this.lblVisor.TabIndex = 37;
            this.lblVisor.Text = "cafe pronto";
            this.lblVisor.Visible = false;
            // 
            // btnCaneca
            // 
            this.btnCaneca.BackColor = System.Drawing.Color.Transparent;
            this.btnCaneca.Enabled = false;
            this.btnCaneca.Location = new System.Drawing.Point(184, 456);
            this.btnCaneca.Margin = new System.Windows.Forms.Padding(0);
            this.btnCaneca.Name = "btnCaneca";
            this.btnCaneca.Size = new System.Drawing.Size(105, 78);
            this.btnCaneca.TabIndex = 39;
            this.btnCaneca.Click += new System.EventHandler(this.btnCaneca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(317, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 33);
            this.label2.TabIndex = 40;
            this.label2.Text = "Saldo";
            // 
            // fundoSemCaneca
            // 
            this.fundoSemCaneca.Enabled = false;
            this.fundoSemCaneca.Image = ((System.Drawing.Image)(resources.GetObject("fundoSemCaneca.Image")));
            this.fundoSemCaneca.Location = new System.Drawing.Point(59, 349);
            this.fundoSemCaneca.Name = "fundoSemCaneca";
            this.fundoSemCaneca.Size = new System.Drawing.Size(335, 185);
            this.fundoSemCaneca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fundoSemCaneca.TabIndex = 41;
            this.fundoSemCaneca.TabStop = false;
            this.fundoSemCaneca.Visible = false;
            this.fundoSemCaneca.Click += new System.EventHandler(this.fundoSemCaneca_Click);
            // 
            // lblTempoGif
            // 
            this.lblTempoGif.AutoSize = true;
            this.lblTempoGif.BackColor = System.Drawing.Color.Transparent;
            this.lblTempoGif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoGif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTempoGif.Location = new System.Drawing.Point(13, 62);
            this.lblTempoGif.Name = "lblTempoGif";
            this.lblTempoGif.Size = new System.Drawing.Size(21, 20);
            this.lblTempoGif.TabIndex = 44;
            this.lblTempoGif.Text = "   ";
            this.lblTempoGif.Visible = false;
            this.lblTempoGif.Click += new System.EventHandler(this.lblTempoGif_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(318, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = " ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnTempoGIF_Menos
            // 
            this.btnTempoGIF_Menos.AutoSize = true;
            this.btnTempoGIF_Menos.BackColor = System.Drawing.Color.Transparent;
            this.btnTempoGIF_Menos.Enabled = false;
            this.btnTempoGIF_Menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempoGIF_Menos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTempoGIF_Menos.Location = new System.Drawing.Point(20, 14);
            this.btnTempoGIF_Menos.Name = "btnTempoGIF_Menos";
            this.btnTempoGIF_Menos.Size = new System.Drawing.Size(29, 20);
            this.btnTempoGIF_Menos.TabIndex = 48;
            this.btnTempoGIF_Menos.Text = "     ";
            this.btnTempoGIF_Menos.Click += new System.EventHandler(this.btnTempoGIF_Menos_Click);
            // 
            // btnTempoGIF_Mais
            // 
            this.btnTempoGIF_Mais.AutoSize = true;
            this.btnTempoGIF_Mais.BackColor = System.Drawing.Color.Transparent;
            this.btnTempoGIF_Mais.Enabled = false;
            this.btnTempoGIF_Mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempoGIF_Mais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTempoGIF_Mais.Location = new System.Drawing.Point(404, 18);
            this.btnTempoGIF_Mais.Name = "btnTempoGIF_Mais";
            this.btnTempoGIF_Mais.Size = new System.Drawing.Size(29, 20);
            this.btnTempoGIF_Mais.TabIndex = 49;
            this.btnTempoGIF_Mais.Text = "     ";
            this.btnTempoGIF_Mais.Click += new System.EventHandler(this.btnTempoGIF_Mais_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(119, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = " ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(448, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTempoGIF_Mais);
            this.Controls.Add(this.btnTempoGIF_Menos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTempoGif);
            this.Controls.Add(this.fundoSemCaneca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCaneca);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.gifCaneca);
            this.Controls.Add(this.grbMoedas);
            this.Controls.Add(this.btnAcu_Menos);
            this.Controls.Add(this.fundoNivel);
            this.Controls.Add(this.btnAcu_Mais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaunilha);
            this.Controls.Add(this.btnChocolate);
            this.Controls.Add(this.btnCapuccino);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnComum);
            this.Controls.Add(this.btnInserirMoedas);
            this.Controls.Add(this.btnRetirarSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.pcbIMG_fundo);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Café Mineiro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btnOK_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIMG_fundo)).EndInit();
            this.fundoNivel.ResumeLayout(false);
            this.fundoNivel.PerformLayout();
            this.grbMoedas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gifCaneca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoSemCaneca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.PictureBox pcbIMG_fundo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnRetirarSaldo;
        private System.Windows.Forms.Button btnInserirMoedas;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn10Cent;
        private System.Windows.Forms.Button btn25Cent;
        private System.Windows.Forms.Button btn50Cent;
        private System.Windows.Forms.Button btn5Cent;
        private System.Windows.Forms.Button btn1real;
        private System.Windows.Forms.Button btnComum;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnCapuccino;
        private System.Windows.Forms.Button btnChocolate;
        private System.Windows.Forms.Button btnBaunilha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNivelAcu;
        private System.Windows.Forms.Button btnAcu_Mais;
        private System.Windows.Forms.Panel fundoNivel;
        private System.Windows.Forms.Button btnAcu_Menos;
        private System.Windows.Forms.Panel grbMoedas;
        private System.Windows.Forms.PictureBox gifCaneca;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Panel btnCaneca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fundoSemCaneca;
        private System.Windows.Forms.Label lblTempoGif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnTempoGIF_Menos;
        private System.Windows.Forms.Label btnTempoGIF_Mais;
        private System.Windows.Forms.Label label4;
    }
}

