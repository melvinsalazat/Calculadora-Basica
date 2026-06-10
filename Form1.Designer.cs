namespace Calculadora_Basica
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
            components = new System.ComponentModel.Container();
            Button btnDividir;
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            ErrorEncontrado = new ErrorProvider(components);
            btnDividir = new Button();
            ((System.ComponentModel.ISupportInitialize)ErrorEncontrado).BeginInit();
            SuspendLayout();
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(293, 218);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(100, 34);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "DIVIDIR";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click_1;
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(43, 65);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(142, 23);
            txtnum1.TabIndex = 0;
            txtnum1.TextChanged += txtnum1_TextChanged;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(43, 131);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(137, 23);
            txtnum2.TabIndex = 1;
            txtnum2.TextChanged += txtnum2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "1er. Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 113);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "2er. Número";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(293, 49);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(100, 39);
            btnSumar.TabIndex = 4;
            btnSumar.Text = "SUMAR";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click_1;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(293, 103);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(100, 40);
            btnRestar.TabIndex = 5;
            btnRestar.Text = "RESTAR";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click_1;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(293, 164);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(100, 38);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "MULTIPLICAR";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click_1;
            // 
            // ErrorEncontrado
            // 
            ErrorEncontrado.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 450);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ErrorEncontrado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum1;
        private TextBox txtnum2;
        private Label label1;
        private Label label2;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private ErrorProvider ErrorEncontrado;
    }
}
