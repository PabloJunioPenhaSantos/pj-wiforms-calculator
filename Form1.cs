using Exemplo.Classes;

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
            op.setYFromInput(double.Parse(inputTextY.Text));
        }

        public void setInputX()
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
        }

        public void printResult(double x, double y, string operacao, double result)
        {
            string formatosaida = x + " " + operacao + " " + y + " = ";

            labelOutput.Visible = true;
            labelOutput.Text = formatosaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();


        }



        private void btnSoma_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getX(), "+", op.soma());

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getY(), "-", op.sub());
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getY(), "x", op.mult());
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getY(), "/", op.div());
        }

        public void printxaoq(double x, double result)
        {
            string formatosaida = x + "² = ";


            labelOutput.Visible = true;
            labelOutput.Text = formatosaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();

        }
        private void btnAoQ_Click(object sender, EventArgs e)
        {
            setInputX();
            printxaoq(op.getX(), op.xaoq());

        }

        public void printraiz(double x, double result)
        {
            string formatosaida = "√" + x + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatosaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            setInputX();
            printraiz(op.getX(), op.raizx());

        }

        public void printPorcentagem(double x, double y, double result)
        {
            string formatosaida = x + "% de " + y + " = ";

            labelOutput.Visible = true;
            labelOutput.Text = formatosaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            setInputs();
            printPorcentagem(op.getX(), op.getY(), op.porcentagem());

        }

        public void printXelevy(double x, double y, double result)
        {
            string formatosaida = x + "^" + y + "=";

            labelOutput.Visible = true;
            labelOutput.Text = formatosaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }
        private void btnXelevy_Click(object sender, EventArgs e)
        {
            setInputs();
            printXelevy(op.getX(), op.getY(), op.xelevy());
        }

        public void printResultBin(double x, string operacao, string result)
        {
            result = op.binario(x);
            string format = x + operacao + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = format;
            labelResult.Visible = true;
            labelResult.Text = result;

        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            setInputX();
            printResultBin(op.getX(), " em binário", op.binario(op.getX()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputTextX.Text = "";
            inputTextY.Text = "";

            labelOutput.Text = "0";
            labelResult.Text = "0";
            
        }
    }
}