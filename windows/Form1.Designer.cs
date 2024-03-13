namespace windows
{
    partial class Teste
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btCalcular = new Button();
            numAltura = new NumericUpDown();
            numPeso = new NumericUpDown();
            pnlResultado = new Panel();
            classificacaoText = new Label();
            calculoText = new Label();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            pnlResultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 20);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Peso (Kg): ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(180, 57);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Altura (m): ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 9);
            label3.Name = "label3";
            label3.Size = new Size(327, 25);
            label3.TabIndex = 2;
            label3.Text = "=-=-=-=-=-= Resultados =-=-=-=-=-= ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 55);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 3;
            label4.Text = "Cálculo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 89);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 4;
            label5.Text = "Classificação:";
            // 
            // btCalcular
            // 
            btCalcular.Enabled = false;
            btCalcular.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btCalcular.Location = new Point(241, 90);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(100, 38);
            btCalcular.TabIndex = 6;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += calcular_Click;
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Location = new Point(280, 61);
            numAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(120, 23);
            numAltura.TabIndex = 7;
            numAltura.ValueChanged += numAltura_ValueChanged;
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 1;
            numPeso.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numPeso.Location = new Point(280, 24);
            numPeso.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(120, 23);
            numPeso.TabIndex = 8;
            // 
            // pnlResultado
            // 
            pnlResultado.Controls.Add(classificacaoText);
            pnlResultado.Controls.Add(calculoText);
            pnlResultado.Controls.Add(label3);
            pnlResultado.Controls.Add(label4);
            pnlResultado.Controls.Add(label5);
            pnlResultado.Location = new Point(69, 134);
            pnlResultado.Name = "pnlResultado";
            pnlResultado.Size = new Size(469, 124);
            pnlResultado.TabIndex = 10;
            pnlResultado.Visible = false;
            // 
            // classificacaoText
            // 
            classificacaoText.AutoSize = true;
            classificacaoText.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            classificacaoText.Location = new Point(124, 89);
            classificacaoText.Name = "classificacaoText";
            classificacaoText.Size = new Size(17, 25);
            classificacaoText.TabIndex = 12;
            classificacaoText.Text = " ";
            // 
            // calculoText
            // 
            calculoText.AutoSize = true;
            calculoText.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            calculoText.Location = new Point(82, 55);
            calculoText.Name = "calculoText";
            calculoText.Size = new Size(17, 25);
            calculoText.TabIndex = 11;
            calculoText.Text = " ";
            calculoText.UseWaitCursor = true;
            // 
            // Teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 333);
            Controls.Add(pnlResultado);
            Controls.Add(numPeso);
            Controls.Add(numAltura);
            Controls.Add(btCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Teste";
            Text = "Teste";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            pnlResultado.ResumeLayout(false);
            pnlResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btCalcular;
        private NumericUpDown numAltura;
        private NumericUpDown numPeso;
        private Panel pnlResultado;
        private Label classificacaoText;
        private Label calculoText;
    }
}
