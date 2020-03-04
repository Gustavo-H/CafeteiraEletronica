using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Cafeteira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            configurarInicio();            
        }

        string pasta_imagens = Application.StartupPath + @"\midia\imagens\";
        string pasta_sons    = Application.StartupPath + @"\midia\sons\";

        Image img_CafeButtons, img_CafeButtonsNada, img_botaoL_on;
        Image img_botaoL_off, img_botaoR_off, img_transparent;

        SoundPlayer canecaEnchendo, moeda, fazendoCafe, somOnOff, moedaSaindo;            

        float saldo = 0;
        int nivel = 3; 
        int a = 0;
        int tempoGIF;

        bool retirarCafe = false;
        bool temCopo = true;

        public void ligar()
        {            
            alterar_Enabled_buttons(1);
            btnLigar.Enabled = false;            
            
            pcbIMG_fundo.Visible = false;
            lblSaldo.ForeColor = Color.LimeGreen;
            btnDesligar.BackColor = Color.Black;            
            btnLigar.BackColor = Color.LimeGreen;           

            btnAcu_Mais.BackgroundImage = img_botaoR_off;
            btnAcu_Menos.BackgroundImage = img_botaoL_off;
                        
            lblNivelAcu.Visible = true;            
            fundoNivel.Enabled = true;

            btnComum.Visible = true;
            btnBaunilha.Visible = true;
            btnCapuccino.Visible = true;
            btnChocolate.Visible = true;
            btnDouble.Visible = true;
            btnCaneca.Enabled = true;
            
            if (saldo < 10)
                lblSaldo.Text = saldo.ToString("C") + " ";
            else
                lblSaldo.Text = saldo.ToString("C");            
        }

        public void desligar(int p)
        {
            if (p == 1 && saldo > 0)            
                retirarSaldo(p);  
            
            else if(p == 1 && saldo == 0)
                somOnOff.Play();
                     
            lblSaldo.ForeColor = Color.Black;           
            alterar_Enabled_buttons(0);
            btnLigar.Enabled = true;
            btnLigar.BackColor = Color.Black;
            btnDesligar.BackColor = Color.Red;

            btnAcu_Mais.BackgroundImage = img_transparent;
            btnAcu_Menos.BackgroundImage = img_transparent;
                        
            lblNivelAcu.Visible  = false;          
            pcbIMG_fundo.Visible = true;            
            fundoNivel.Enabled   = false;
            grbMoedas.Visible    = false;
            pcbIMG_fundo.Visible = true;
            
            btnComum.Visible     = false;
            btnDouble.Visible    = false;
            btnBaunilha.Visible  = false;
            btnCapuccino.Visible = false;
            btnChocolate.Visible = false;
                           
            btnCaneca.Enabled = true;            

            configurarNivelCafe(3);
            saldo = 0;
            a = 0;
            btnLigar.Focus();
        }
        
        public void configurarInicio()
        {         
            img_CafeButtons = Image.FromFile(pasta_imagens + "botaoOn.gif");
            img_botaoL_on   = Image.FromFile(pasta_imagens + "botaoLOn.gif");
            img_transparent = Image.FromFile(pasta_imagens + "transparent.gif");
            img_botaoL_off  = Image.FromFile(pasta_imagens + "botaoL_off.gif");
            img_botaoR_off  = Image.FromFile(pasta_imagens + "botaoR_off.gif");

            canecaEnchendo  = new SoundPlayer(pasta_sons + "canecaEnchendo.wav");
            moeda           = new SoundPlayer(pasta_sons + "moeda.wav");
            fazendoCafe     = new SoundPlayer(pasta_sons + "cafeSendoFeito.wav");            
            somOnOff        = new SoundPlayer(pasta_sons + "somClique.wav");
            moedaSaindo     = new SoundPlayer(pasta_sons + "moedaSaindo.wav");

            tempoGIF = 3100;
            lblTempoGif.Text = tempoGIF.ToString();
            
            desligar(0);
        }
        
        public void retirarSaldo(int p)
        {           
            grbMoedas.Visible = false;
            a = 0;

            if (saldo > 0)
            {
                if (MessageBox.Show("Você Deseja Retirar Seu Saldo?", "ATENÇÂO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString().ToUpper() == "YES")
                {

                    int[] moedas = new int[5];
                    string[] moedasText = new string[5];

                    float troco = saldo;
                    string quaisMoedas;
                    
                    for (int i = 0; i < 5; i++)
                    {
                        moedas[i] = 0;
                        moedasText[i] = string.Empty;
                    }
                    
                    while (saldo > 0.99)
                    {
                        moedas[0]++;
                        saldo--;
                    }
                    
                    while (saldo > 0.49)
                    {
                        moedas[1]++;
                        saldo -= 0.50f;
                    }
                    
                    while (saldo > 0.24f)
                    {
                        moedas[2]++;
                        saldo -= 0.25f;
                    }
                    
                    while (saldo > 0.09f)
                    {
                        moedas[3]++;
                        saldo -= 0.10f;
                    }
                    
                    while (saldo > 0.04f)
                    {
                        moedas[4]++;
                        saldo -= 0.05f;
                    }
                    
                    if (moedas[0] != 0)
                    {
                        if (moedas[0] == 1)
                            moedasText[0] = "1  Moeda  de 1  Real\n";
                        else if (moedas[0] > 1 && moedas[0] < 10)
                            moedasText[0] = moedas[0].ToString() + "  Moedas de 1  Real\n";
                        else
                            moedasText[0] = moedas[0].ToString() + " Moedas de 1  Real\n";
                    }

                    if (moedas[1] != 0)
                    {
                        if (moedas[1] == 1)
                            moedasText[1] = "1  Moeda  de 50 Centavos\n";
                        else
                            moedasText[1] = moedas[1].ToString() + " Moedas de 50 Centavos\n";
                    }

                    if (moedas[2] != 0)
                    {
                        if (moedas[2] == 1)
                            moedasText[2] = "1  Moeda  de 25 Centavos\n";
                        else
                            moedasText[2] = moedas[2].ToString() + " Moedas de 25 Centavos\n";
                    }

                    if (moedas[3] != 0)
                    {
                        if (moedas[3] == 1)
                            moedasText[3] = "1  Moeda  de 10 Centavos\n";
                        else
                            moedasText[3] = moedas[3].ToString() + " Moedas de 10 Centavos\n";
                    }

                    if (moedas[4] != 0)
                    {
                        if (moedas[4] == 1)
                            moedasText[4] = "1  Moeda  de 5  Centavos\n";
                        else
                            moedasText[4] = moedas[4].ToString() + " Moedas de 5  Centavos\n";
                    }
                    
                    quaisMoedas = moedasText[0] + moedasText[1] + moedasText[2] + moedasText[3] + moedasText[4];
                    
                    saldo = 0;
                    lblSaldo.Text = saldo.ToString("C") + " ";
                    moedaSaindo.Play();
                    MessageBox.Show("Saldo Retirado Com Sucesso!\n\n" + quaisMoedas +
                    "\nTotalizando " + troco.ToString("c") + " de Troco", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }            
            }
            else
            {                
                MessageBox.Show("Você Não Possui Saldo", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            if (p == 1) somOnOff.Play();
        }
        
        public async void mudarCorBotoes()
        {
            btnCaneca.Enabled = false;
            alterar_Enabled_buttons(0);
            fazendoCafe.Play();
            for (int i = 0; i < 2; i++)
            {
                btnComum.BackgroundImage     = img_CafeButtons;
                await Task.Delay(500);
                btnComum.BackgroundImage     = img_transparent;
                btnDouble.BackgroundImage    = img_CafeButtons;
                await Task.Delay(500);
                btnDouble.BackgroundImage    = img_transparent;
                btnCapuccino.BackgroundImage = img_CafeButtons;
                await Task.Delay(500);
                btnCapuccino.BackgroundImage = img_transparent;
                btnChocolate.BackgroundImage = img_CafeButtons;
                await Task.Delay(500);
                btnChocolate.BackgroundImage = img_transparent;
                btnBaunilha.BackgroundImage  = img_CafeButtons;
                await Task.Delay(500);
                btnBaunilha.BackgroundImage  = img_transparent;
            }           
            
            for (int i = 0; i < 5; i++)
            {
                btnComum.BackgroundImage     = img_CafeButtons;
                btnDouble.BackgroundImage    = img_CafeButtons;
                btnCapuccino.BackgroundImage = img_CafeButtons;
                btnChocolate.BackgroundImage = img_CafeButtons;
                btnBaunilha.BackgroundImage  = img_CafeButtons;

                await Task.Delay(400);

                btnComum.BackgroundImage     = img_transparent;
                btnDouble.BackgroundImage    = img_transparent;
                btnCapuccino.BackgroundImage = img_transparent;
                btnChocolate.BackgroundImage = img_transparent;
                btnBaunilha.BackgroundImage  = img_transparent;
                await Task.Delay(400);

                if(i==0)  fazendoCafe.Stop();                
            }           
        }
        
        public void configurarNivelCafe(int p)
        {
            grbMoedas.Visible = false;
            a = 0;
            switch (p)
            {
                case 1:
                    if (nivel < 6)
                    {
                        lblNivelAcu.Text += "||| ";
                        nivel++;
                    }
                    break;

                case 2:
                    if (nivel >= 1)
                    {
                        nivel--;
                        lblNivelAcu.Text = string.Empty;

                        for (int i = 0; i < nivel; i++)
                        {
                            lblNivelAcu.Text += "||| ";
                        }
                    }
                    break;

                case 3:
                    nivel = 3;
                    lblNivelAcu.Text = string.Empty;
                    lblNivelAcu.Text = "||| ||| ||| ";
                    break;
            }
        }        
        
        public void alterar_Enabled_buttons(int t)
        {
            if (t == 0)
            {
                btnComum.Enabled = false;
                btnDouble.Enabled = false;
                btnCapuccino.Enabled = false;
                btnChocolate.Enabled = false;
                btnBaunilha.Enabled = false;

                btnLigar.Enabled = false;
                btnDesligar.Enabled = false;
                btnInserirMoedas.Enabled = false;
                btnRetirarSaldo.Enabled = false;
                btnAcu_Mais.Enabled = false;
                btnAcu_Menos.Enabled = false;
            }
            else
            {
                btnComum.Enabled = true;
                btnDouble.Enabled = true;
                btnCapuccino.Enabled = true;
                btnChocolate.Enabled = true;
                btnBaunilha.Enabled = true;

                btnLigar.Enabled = true;
                btnDesligar.Enabled = true;
                btnInserirMoedas.Enabled = true;
                btnRetirarSaldo.Enabled = true;
                btnAcu_Mais.Enabled = true;
                btnAcu_Menos.Enabled = true;
            }
            
            if (btnDesligar.Enabled == true)
                btnLigar.Enabled = false;
        }         
        
        public async void fazerCafe(int qualCafe, float valorCafe)
        {
            grbMoedas.Visible = false;
            a = 0;
            
            if (saldo < valorCafe)
            {
                MessageBox.Show("Adicione " + (valorCafe - saldo).ToString("C") + "\nPara Prosseguir", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnInserirMoedas.Focus();                                
            }
            else
            {
                alterar_Enabled_buttons(0);

                while (!temCopo)
                {
                    switch (qualCafe)
                    {
                        case 1:
                            btnComum.BackgroundImage = img_CafeButtons;
                            break;
                        case 2:
                            btnDouble.BackgroundImage = img_CafeButtons;
                            break;
                        case 3:
                            btnCapuccino.BackgroundImage = img_CafeButtons;
                            break;
                        case 4:
                            btnChocolate.BackgroundImage = img_CafeButtons;
                            break;
                        case 5:
                            btnBaunilha.BackgroundImage = img_CafeButtons;
                            break;
                    } 

                    lblVisor.Visible = true;
                    
                    await Task.Delay(400);

                    switch (qualCafe)
                    {
                        case 1:
                            btnComum.BackgroundImage = img_CafeButtons;
                            break;
                        case 2:
                            btnDouble.BackgroundImage = img_CafeButtons;
                            break;
                        case 3:
                            btnCapuccino.BackgroundImage = img_CafeButtons;
                            break;
                        case 4:
                            btnChocolate.BackgroundImage = img_CafeButtons;
                            break;
                        case 5:
                            btnBaunilha.BackgroundImage = img_CafeButtons;
                            break;
                    }
                   
                    lblVisor.Visible = false;
                    
                    await Task.Delay(400);
                }

                btnComum.BackgroundImage     = img_transparent;
                btnDouble.BackgroundImage    = img_transparent;
                btnBaunilha.BackgroundImage  = img_transparent;
                btnCapuccino.BackgroundImage = img_transparent;
                btnChocolate.BackgroundImage = img_transparent;                

                saldo -= valorCafe;
                
                if (saldo < 10)
                    lblSaldo.Text = saldo.ToString("C") + " ";
                else
                    lblSaldo.Text = saldo.ToString("C");
                
                mudarCorBotoes();                
                await Task.Delay(5800);
                                
                gifCaneca.Enabled = true;
                gifCaneca.Visible = true;

                await Task.Delay(400);
                canecaEnchendo.Play();

                await Task.Delay(tempoGIF);  //3100            

                canecaEnchendo.Stop();
                gifCaneca.Enabled = false;
                                
                btnCaneca.Enabled = true;
                lblVisor.Visible  = true;

                while (!retirarCafe)
                {
                    lblVisor.Visible = true;
                    switch (qualCafe)
                    {
                        case 1:
                            btnComum.BackgroundImage = img_CafeButtons;
                            break;

                        case 2:
                            btnDouble.BackgroundImage = img_CafeButtons;
                            break;

                        case 3:
                            btnCapuccino.BackgroundImage = img_CafeButtons;
                            break;

                        case 4:
                            btnChocolate.BackgroundImage = img_CafeButtons;
                            break;

                        case 5:
                            btnBaunilha.BackgroundImage = img_CafeButtons;
                            break;
                    }
                    await Task.Delay(400);                    
                    switch (qualCafe)
                    {
                        case 1:
                            btnComum.BackgroundImage = img_transparent;
                            break;

                        case 2:
                            btnDouble.BackgroundImage = img_transparent;
                            break;

                        case 3:
                            btnCapuccino.BackgroundImage = img_transparent;
                            break;

                        case 4:
                            btnChocolate.BackgroundImage = img_transparent;
                            break;

                        case 5:
                            btnBaunilha.BackgroundImage = img_transparent;
                            break;
                    }

                    lblVisor.Visible = false;
                    await Task.Delay(400);
                }                  
                
                if (nivel != 3) configurarNivelCafe(3);

                gifCaneca.Visible = false;

                btnComum.BackgroundImage     = img_transparent;
                btnDouble.BackgroundImage    = img_transparent;
                btnBaunilha.BackgroundImage  = img_transparent;
                btnCapuccino.BackgroundImage = img_transparent;
                btnChocolate.BackgroundImage = img_transparent;

                alterar_Enabled_buttons(1);
            }
        }

        
         ///----------------------------------------------------------------------------------------------------///
        ///----------------------------------------------------------------------------------------------------///

        private void btnLigar_Click(object sender, EventArgs e)
        {
            somOnOff.Play();
            ligar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay  = 500;
                        
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.btnBaunilha,      "Café Baunilha R$ 2,00");
            toolTip1.SetToolTip(this.btnComum,         "Café Comum R$ 1,00");
            toolTip1.SetToolTip(this.btnDouble,        "Café Double R$ 1,50");
            toolTip1.SetToolTip(this.btnChocolate,     "Café Chocolate R$ 2,00");
            toolTip1.SetToolTip(this.btnCapuccino,     "Café Capuccino R$ 2,00");
            toolTip1.SetToolTip(this.btnLigar,         "Clique Para Ligar");
            toolTip1.SetToolTip(this.btnDesligar,      "Clique Para Desligar");
            toolTip1.SetToolTip(this.btnRetirarSaldo,  "Clique Para Retirar Saldo");
            toolTip1.SetToolTip(this.btnInserirMoedas, "Clique Para Inserir Saldo");
            toolTip1.SetToolTip(this.grbMoedas,        "Clique No Valor Correspondete\nA Moeda que Deseja Adicionar");
            toolTip1.SetToolTip(this.btnDesligar,      "Clique Para Desligar");
            toolTip1.SetToolTip(this.btnAcu_Mais,      "Clique Para Aumentar a \nQuantidade de Açucar"); 
            toolTip1.SetToolTip(this.btnAcu_Menos,     "Clique Para Diminuir a \nQuantidade de Açucar");
            toolTip1.SetToolTip(this.btnCaneca,        "Clique na Caneca\nPara Retirá-la");
            toolTip1.SetToolTip(this.fundoSemCaneca,   "Clique Aqui Para\nColocar Um Copo");
            toolTip1.SetToolTip(this.fundoNivel,       "Nivel ------- Açucar\n    0    <==> 0 Gramas\n    1    <==> 5 Gramas\n    2    <==> 10 Gramas\n    3    <==> 15 Gramas\n    4    <==> 20 Gramas\n    5    <==> 25 Gramas\n    6    <==> 30 Gramas");
            toolTip1.SetToolTip(this.lblNivelAcu,      "Nivel ------- Açucar\n    0    <==> 0 Gramas\n    1    <==> 5 Gramas\n    2    <==> 10 Gramas\n    3    <==> 15 Gramas\n    4    <==> 20 Gramas\n    5    <==> 25 Gramas\n    6    <==> 30 Gramas");            
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {           
            desligar(1);
        }

        private void btnInserirMoedas_Click(object sender, EventArgs e)
        {
            if (a % 2 == 0) grbMoedas.Visible = true;

            else grbMoedas.Visible = false;
            a++;
        }

        private void btnRetirarSaldo_Click(object sender, EventArgs e)
        {            
            retirarSaldo(0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            grbMoedas.Visible = false;
            a = 0;
        }        

        private void cafeEscolhido(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "1":
                    fazerCafe(1,1.0f);                    
                    break;

                case "2":                    
                    fazerCafe(2, 1.5f);
                    break;

                case "3":
                    fazerCafe(3, 2.0f);
                    break;

                case "4":
                    fazerCafe(4, 2.0f);
                    break;

                case "5":
                    fazerCafe(5, 2.0f);
                    break;
            }            
        }

        private void adicionaMoedas(object sender, EventArgs e)
        {
            if (saldo <= 98.95)
            {
                moeda.Play();
                saldo += (float.Parse((sender as Button).Text));
                if (saldo < 10)
                    lblSaldo.Text = saldo.ToString("C") + " ";
                else
                    lblSaldo.Text = saldo.ToString("C");
            }
            else
            {
                MessageBox.Show("Capacidade Máxima\nDe Saldo Atingida\nValor Máximo = " + saldo.ToString("C"), "ATENÇÂO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }                                                 

        private void mouseEnterButtons(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Black;
            img_CafeButtonsNada = (sender as Button).BackgroundImage;
            (sender as Button).BackgroundImage = img_CafeButtons;
        }

        private void mouseLeaveButtons(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
            (sender as Button).BackgroundImage = img_CafeButtonsNada;
        }

        private void btnAcu_Mais_Click(object sender, EventArgs e)
        {
            configurarNivelCafe(1);
        }

        private void btnAcu_Menos_Click(object sender, EventArgs e)
        {
            configurarNivelCafe(2);
        }

        private void btnAssuMenosEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Black;
            img_CafeButtonsNada = (sender as Button).BackgroundImage;
            (sender as Button).BackgroundImage = img_botaoL_on;
        }

        private void btnAssuMenosLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
            (sender as Button).BackgroundImage = img_CafeButtonsNada;
        }

        private void btnCaneca_Click(object sender, EventArgs e)
        {
            lblVisor.Visible = false;
            retirarCafe = true;
            fundoSemCaneca.Visible = true;
            fundoSemCaneca.Enabled = true;
            temCopo = false;
            lblVisor.Left = 147;
            lblVisor.Text = "Coloque Um Copo";                       
        }

        private void fundoSemCaneca_Click(object sender, EventArgs e)
        {
            temCopo = true;
            retirarCafe = false;
            fundoSemCaneca.Visible = false;
            fundoSemCaneca.Enabled = false;
            lblVisor.Left = 159;
            lblVisor.Text = "Cafe Pronto";                                    
        }

        private void btnTempoGIF_Menos_Click(object sender, EventArgs e)
        {
            tempoGIF -= 50;
            lblTempoGif.Text = tempoGIF.ToString();
            lblTempoGif.Visible = true;
        }

        private void btnTempoGIF_Mais_Click(object sender, EventArgs e)
        {
            tempoGIF += 50;
            lblTempoGif.Text = tempoGIF.ToString();
            lblTempoGif.Visible = true;
        }

        private void lblTempoGif_Click(object sender, EventArgs e)
        {
            lblTempoGif.Visible = false;
            btnTempoGIF_Menos.Enabled = false;
            btnTempoGIF_Mais.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            btnTempoGIF_Menos.Enabled = true;
            btnTempoGIF_Mais.Enabled = true;            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Palmeiras Não Tem Mundial ! ! !");//Onde Esta O Mundial ?");
        }        
    }
}


