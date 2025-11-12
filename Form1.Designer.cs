
namespace Exemplo
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
            inputTextX = new TextBox();
            btnSoma = new Button();
            labelTitle = new Label();
            labelOutput = new Label();
            inputTextY = new TextBox();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnXaoq = new Button();
            btnRaiz = new Button();
            btnPorcentagem = new Button();
            btnXelevy = new Button();
            labelResult = new Label();
            label1 = new Label();
            btnBinario = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.BackColor = SystemColors.HotTrack;
            inputTextX.ForeColor = Color.White;
            inputTextX.Location = new Point(11, 41);
            inputTextX.Margin = new Padding(2);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(135, 23);
            inputTextX.TabIndex = 1;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.Blue;
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSoma.ForeColor = SystemColors.ButtonFace;
            btnSoma.ImageAlign = ContentAlignment.TopCenter;
            btnSoma.Location = new Point(11, 103);
            btnSoma.Margin = new Padding(2);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(42, 26);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Blue;
            labelTitle.Location = new Point(11, 3);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.MaximumSize = new Size(240, 39);
            labelTitle.MinimumSize = new Size(220, 39);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(222, 39);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculadora do Cabuloso";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.White;
            labelOutput.ForeColor = Color.Blue;
            labelOutput.Location = new Point(276, 9);
            labelOutput.Margin = new Padding(2, 0, 2, 0);
            labelOutput.MaximumSize = new Size(280, 210);
            labelOutput.MinimumSize = new Size(280, 210);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(7, 6, 7, 6);
            labelOutput.Size = new Size(280, 210);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "0";
            labelOutput.TextAlign = ContentAlignment.TopRight;
            labelOutput.Click += labelOutput_Click;
            // 
            // inputTextY
            // 
            inputTextY.BackColor = SystemColors.HotTrack;
            inputTextY.ForeColor = Color.White;
            inputTextY.Location = new Point(11, 68);
            inputTextY.Margin = new Padding(2);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(135, 23);
            inputTextY.TabIndex = 2;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.Blue;
            btnSubtracao.Cursor = Cursors.Hand;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubtracao.ForeColor = SystemColors.ButtonFace;
            btnSubtracao.Location = new Point(57, 103);
            btnSubtracao.Margin = new Padding(2);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(42, 26);
            btnSubtracao.TabIndex = 5;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.Blue;
            btnMultiplicacao.Cursor = Cursors.Hand;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = SystemColors.ButtonFace;
            btnMultiplicacao.Location = new Point(104, 103);
            btnMultiplicacao.Margin = new Padding(2);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(42, 26);
            btnMultiplicacao.TabIndex = 6;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.Blue;
            btnDivisao.Cursor = Cursors.Hand;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDivisao.ForeColor = SystemColors.ButtonFace;
            btnDivisao.Location = new Point(11, 146);
            btnDivisao.Margin = new Padding(2);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(42, 26);
            btnDivisao.TabIndex = 7;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnXaoq
            // 
            btnXaoq.BackColor = Color.Blue;
            btnXaoq.Cursor = Cursors.Hand;
            btnXaoq.FlatStyle = FlatStyle.Flat;
            btnXaoq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXaoq.ForeColor = SystemColors.ButtonFace;
            btnXaoq.Location = new Point(57, 146);
            btnXaoq.Margin = new Padding(2);
            btnXaoq.Name = "btnXaoq";
            btnXaoq.Size = new Size(42, 26);
            btnXaoq.TabIndex = 12;
            btnXaoq.Text = "X²";
            btnXaoq.UseVisualStyleBackColor = false;
            btnXaoq.Click += btnAoQ_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.Blue;
            btnRaiz.Cursor = Cursors.Hand;
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRaiz.ForeColor = SystemColors.ButtonFace;
            btnRaiz.Location = new Point(104, 146);
            btnRaiz.Margin = new Padding(2);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(42, 26);
            btnRaiz.TabIndex = 13;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.Blue;
            btnPorcentagem.Cursor = Cursors.Hand;
            btnPorcentagem.FlatStyle = FlatStyle.Flat;
            btnPorcentagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPorcentagem.ForeColor = SystemColors.ButtonFace;
            btnPorcentagem.Location = new Point(11, 193);
            btnPorcentagem.Margin = new Padding(2);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(42, 26);
            btnPorcentagem.TabIndex = 14;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btnXelevy
            // 
            btnXelevy.BackColor = Color.Blue;
            btnXelevy.Cursor = Cursors.Hand;
            btnXelevy.FlatStyle = FlatStyle.Flat;
            btnXelevy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXelevy.ForeColor = SystemColors.ButtonFace;
            btnXelevy.Location = new Point(104, 193);
            btnXelevy.Margin = new Padding(2);
            btnXelevy.Name = "btnXelevy";
            btnXelevy.Size = new Size(42, 26);
            btnXelevy.TabIndex = 16;
            btnXelevy.Text = "x^y";
            btnXelevy.UseVisualStyleBackColor = false;
            btnXelevy.Click += btnXelevy_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.White;
            labelResult.Font = new Font("Segoe UI", 15F);
            labelResult.ForeColor = Color.Blue;
            labelResult.Location = new Point(276, 87);
            labelResult.Margin = new Padding(2, 0, 2, 0);
            labelResult.MaximumSize = new Size(280, 42);
            labelResult.MinimumSize = new Size(280, 42);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(280, 42);
            labelResult.TabIndex = 17;
            labelResult.Text = "0";
            labelResult.TextAlign = ContentAlignment.MiddleRight;
            labelResult.Click += labelResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Image = Properties.Resources._5;
            label1.Location = new Point(136, 42);
            label1.MaximumSize = new Size(150, 150);
            label1.MinimumSize = new Size(150, 200);
            label1.Name = "label1";
            label1.Size = new Size(150, 200);
            label1.TabIndex = 18;
            label1.Click += label1_Click;
            // 
            // btnBinario
            // 
            btnBinario.BackColor = Color.Blue;
            btnBinario.Cursor = Cursors.Hand;
            btnBinario.FlatStyle = FlatStyle.Flat;
            btnBinario.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            btnBinario.ForeColor = SystemColors.ButtonFace;
            btnBinario.Location = new Point(57, 193);
            btnBinario.Margin = new Padding(2);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(42, 26);
            btnBinario.TabIndex = 15;
            btnBinario.Text = "010101";
            btnBinario.UseVisualStyleBackColor = false;
            btnBinario.Click += btnBinario_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(57, 233);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(42, 26);
            button1.TabIndex = 19;
            button1.Text = "RESET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 270);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(btnXelevy);
            Controls.Add(btnBinario);
            Controls.Add(btnPorcentagem);
            Controls.Add(btnRaiz);
            Controls.Add(btnXaoq);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(inputTextY);
            Controls.Add(labelOutput);
            Controls.Add(labelTitle);
            Controls.Add(btnSoma);
            Controls.Add(inputTextX);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox inputTextX;
        private Button btnSoma;
        private Label labelTitle;
        private Label labelOutput;
        private TextBox inputTextY;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnXaoq;
        private Button btnRaiz;
        private Button btnPorcentagem;
        private Button btnXelevy;
        private Label labelResult;
        private Label label1;
        private Button btnBinario;
        private Button button1;
    }
}
