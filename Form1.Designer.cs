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
            labelTitle = new Label();
            inputTextY = new TextBox();
            btnClick1 = new Button();
            labelOutput = new Label();
            inputTextX = new TextBox();
            button3 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelOutput2 = new Label();
            button9 = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(12, 24);
            labelTitle.MaximumSize = new Size(300, 65);
            labelTitle.MinimumSize = new Size(300, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Digite abaixo, os valores para Y e X para calcular:";
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(58, 176);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(223, 31);
            inputTextY.TabIndex = 4;
            // 
            // btnClick1
            // 
            btnClick1.BackColor = Color.FromArgb(255, 127, 84);
            btnClick1.Cursor = Cursors.Hand;
            btnClick1.FlatAppearance.BorderColor = Color.White;
            btnClick1.FlatAppearance.BorderSize = 3;
            btnClick1.FlatStyle = FlatStyle.Flat;
            btnClick1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClick1.ForeColor = SystemColors.ButtonFace;
            btnClick1.Location = new Point(12, 243);
            btnClick1.Name = "btnClick1";
            btnClick1.Size = new Size(95, 61);
            btnClick1.TabIndex = 5;
            btnClick1.Text = "+";
            btnClick1.UseVisualStyleBackColor = false;
            btnClick1.Click += onBtnSoma_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.Font = new Font("Segoe UI", 18F);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(371, 88);
            labelOutput.MaximumSize = new Size(400, 250);
            labelOutput.MinimumSize = new Size(400, 250);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 250);
            labelOutput.TabIndex = 15;
            labelOutput.Visible = false;
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(58, 114);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(223, 31);
            inputTextX.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 127, 84);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(12, 310);
            button3.Name = "button3";
            button3.Size = new Size(95, 61);
            button3.TabIndex = 8;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = false;
            button3.Click += onBtnDivisao_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 127, 84);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.BorderSize = 3;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(12, 377);
            button6.Name = "button6";
            button6.Size = new Size(95, 61);
            button6.TabIndex = 11;
            button6.Text = "%";
            button6.UseVisualStyleBackColor = false;
            button6.Click += onBtnPorcentagem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 127, 84);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(113, 243);
            button1.Name = "button1";
            button1.Size = new Size(95, 61);
            button1.TabIndex = 6;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += onBtnSubtracao_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 127, 84);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(113, 310);
            button2.Name = "button2";
            button2.Size = new Size(95, 61);
            button2.TabIndex = 9;
            button2.Text = "x²";
            button2.UseVisualStyleBackColor = false;
            button2.Click += onBtnvalorQuadrado_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 127, 84);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(113, 377);
            button4.Name = "button4";
            button4.Size = new Size(95, 61);
            button4.TabIndex = 12;
            button4.Text = "010101";
            button4.UseVisualStyleBackColor = false;
            button4.Click += onBtnBinario_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 127, 84);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(214, 243);
            button5.Name = "button5";
            button5.Size = new Size(95, 61);
            button5.TabIndex = 7;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = false;
            button5.Click += onBtnMultiplicacao_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 127, 84);
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(214, 310);
            button7.Name = "button7";
            button7.Size = new Size(95, 61);
            button7.TabIndex = 10;
            button7.Text = "√x";
            button7.UseVisualStyleBackColor = false;
            button7.Click += onBtnraizQuadrada_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 127, 84);
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatAppearance.BorderSize = 3;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(214, 377);
            button8.Name = "button8";
            button8.Size = new Size(95, 61);
            button8.TabIndex = 13;
            button8.Text = "x^​y";
            button8.UseVisualStyleBackColor = false;
            button8.Click += onBtnRaizY_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(371, 9);
            label1.MaximumSize = new Size(400, 65);
            label1.MinimumSize = new Size(400, 65);
            label1.Name = "label1";
            label1.Size = new Size(400, 65);
            label1.TabIndex = 14;
            label1.Text = "RESULTADO";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(12, 111);
            label2.MaximumSize = new Size(40, 40);
            label2.MinimumSize = new Size(40, 40);
            label2.Name = "label2";
            label2.Size = new Size(40, 40);
            label2.TabIndex = 1;
            label2.Text = "X:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(12, 173);
            label3.MaximumSize = new Size(40, 40);
            label3.MinimumSize = new Size(40, 40);
            label3.Name = "label3";
            label3.Size = new Size(40, 40);
            label3.TabIndex = 3;
            label3.Text = "Y:";
            // 
            // labelOutput2
            // 
            labelOutput2.AutoSize = true;
            labelOutput2.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput2.Font = new Font("Segoe UI", 20F);
            labelOutput2.ForeColor = Color.FromArgb(255, 127, 84);
            labelOutput2.Location = new Point(481, 214);
            labelOutput2.MaximumSize = new Size(190, 90);
            labelOutput2.MinimumSize = new Size(190, 90);
            labelOutput2.Name = "labelOutput2";
            labelOutput2.Padding = new Padding(10);
            labelOutput2.Size = new Size(190, 90);
            labelOutput2.TabIndex = 16;
            labelOutput2.Visible = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 127, 84);
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.White;
            button9.FlatAppearance.BorderSize = 3;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(398, 363);
            button9.MaximumSize = new Size(350, 60);
            button9.MinimumSize = new Size(350, 60);
            button9.Name = "button9";
            button9.Size = new Size(350, 60);
            button9.TabIndex = 17;
            button9.Text = "APAGAR";
            button9.UseVisualStyleBackColor = false;
            button9.Click += onBtnApagar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(labelOutput2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(inputTextX);
            Controls.Add(labelOutput);
            Controls.Add(btnClick1);
            Controls.Add(inputTextY);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox inputTextY;
        private Button btnClick1;
        private Label labelOutput;
        private TextBox inputTextX;
        private Button button3;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelOutput2;
        private Button button9;
    }
}