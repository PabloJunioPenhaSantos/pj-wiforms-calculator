using Exemplo.Classes;
using System.Configuration;
using System.Runtime.Intrinsics.Arm;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        Operacoes op;
        public Form1()
        {
            InitializeComponent();
            op = new Operacoes();

        }


        public void setInputs()
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
            if (String.IsNullOrWhiteSpace(inputTextY.Text))
            {
                op.setYFromInput(0);
            }
            else
            {
                op.setYFromInput(double.Parse(inputTextY.Text));
            }



        }

        public void printResult1(double x, double y, string operacao, double result)
        {
            string formatoSaida = " " + x + operacao + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;

            string resultado = "" + result + "";
            labelOutput2.Visible = true;
            labelOutput2.Text = resultado;
        }

        public void printResult2(double x, double y, string operacao, double result)
        {
            string formatoSaida = " " + x + operacao + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;

            string resultado = "" + result + "";
            labelOutput2.Visible = true;
            labelOutput2.Text = resultado;

        }

        public void printResult3(double x, double y, string operacao, double result)
        {
            string formatoSaida = " " + operacao + x + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;

            string resultado = "" + result + "";
            labelOutput2.Visible = true;
            labelOutput2.Text = resultado;

        }
        public void printResult6(string operacao)
        {
            string formatoSaida = " ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;

            string resultado = "";
            labelOutput2.Visible = true;
            labelOutput2.Text = resultado;

            string vazio = " ";
            inputTextX.Visible = true;
            inputTextX.Text = vazio;


            inputTextY.Visible = true;
            inputTextY.Text = vazio;


        }
        public void printResult(double x, double y, string operacao, double result)
        {
            string formatoSaida = "" + x + operacao + y + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;

            string resultado = "" + result + "";
            labelOutput2.Visible = true;
            labelOutput2.Text = resultado;
        }

        public void printResult4(double x, double y, string operacao, double result)
        {
            string formatoSaida = "" + y + operacao + x + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;

            string resultado = "" + result + "";
            labelOutput2.Visible = true;
            labelOutput2.Text = resultado;
        }
        public void onBtnSoma_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.soma();
            printResult(op.getX(), op.getY(), " + ", result);
        }

        public void onBtnSubtracao_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.subtracao();
            printResult(op.getX(), op.getY(), " - ", result);
        }

        public void onBtnMultiplicacao_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.multiplicacao();
            printResult(op.getX(), op.getY(), " x ", result);
        }

        public void onBtnDivisao_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.divisao();
            printResult(op.getX(), op.getY(), " / ", result);
        }

        public void onBtnvalorQuadrado_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.valorQuadrado();
            printResult1(op.getX(), op.getX(), "^�", result);
        }

        public void onBtnraizQuadrada_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.raizQuadrada();
            printResult3(op.getX(), op.getX(), " Raiz quadrada de ", result);
        }

        public void onBtnPorcentagem_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.porcentagem();
            printResult4(op.getX(), op.getY(), "% de ", result);
        }

        public void onBtnBinario_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.binario();
            printResult1(op.getX(), op.getY(), " em binario � ", result);
        }

        public void onBtnRaizY_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.raizY();
            printResult(op.getX(), op.getY(), " elevado � ", result);
        }

        public void onBtnApagar_Click(object sender, EventArgs e)
        {
            setInputs();
            string result = op.apagar();
            printResult6(" ");

        }

        
    }

}