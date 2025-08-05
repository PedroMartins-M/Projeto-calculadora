namespace Calculadora
{
    partial class Calculadora
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
            lblnumero1 = new Label();
            txtnumero1 = new TextBox();
            lblnumero2 = new Label();
            txtnumero2 = new TextBox();
            bpnsomar = new Button();
            bpnsubtrair = new Button();
            bpnmultiplicar = new Button();
            bpndividir = new Button();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // lblnumero1
            // 
            lblnumero1.AutoSize = true;
            lblnumero1.Location = new Point(33, 58);
            lblnumero1.Name = "lblnumero1";
            lblnumero1.Size = new Size(60, 15);
            lblnumero1.TabIndex = 0;
            lblnumero1.Text = "Número 1";
            // 
            // txtnumero1
            // 
            txtnumero1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnumero1.Location = new Point(33, 86);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(128, 26);
            txtnumero1.TabIndex = 1;
            // 
            // lblnumero2
            // 
            lblnumero2.AutoSize = true;
            lblnumero2.Location = new Point(287, 58);
            lblnumero2.Name = "lblnumero2";
            lblnumero2.Size = new Size(60, 15);
            lblnumero2.TabIndex = 2;
            lblnumero2.Text = "Número 2";
            lblnumero2.Click += lblnumero2_Click;
            // 
            // txtnumero2
            // 
            txtnumero2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnumero2.Location = new Point(287, 85);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(128, 29);
            txtnumero2.TabIndex = 3;
            // 
            // bpnsomar
            // 
            bpnsomar.Location = new Point(33, 170);
            bpnsomar.Name = "bpnsomar";
            bpnsomar.Size = new Size(75, 23);
            bpnsomar.TabIndex = 4;
            bpnsomar.Text = "Somar";
            bpnsomar.UseVisualStyleBackColor = true;
            bpnsomar.Click += bpnsomar_Click;
            // 
            // bpnsubtrair
            // 
            bpnsubtrair.Location = new Point(165, 170);
            bpnsubtrair.Name = "bpnsubtrair";
            bpnsubtrair.Size = new Size(75, 23);
            bpnsubtrair.TabIndex = 5;
            bpnsubtrair.Text = "Subtrair";
            bpnsubtrair.UseVisualStyleBackColor = true;
            // 
            // bpnmultiplicar
            // 
            bpnmultiplicar.Location = new Point(299, 170);
            bpnmultiplicar.Name = "bpnmultiplicar";
            bpnmultiplicar.Size = new Size(75, 23);
            bpnmultiplicar.TabIndex = 6;
            bpnmultiplicar.Text = "Multiplicar";
            bpnmultiplicar.UseVisualStyleBackColor = true;
            // 
            // bpndividir
            // 
            bpndividir.Location = new Point(428, 170);
            bpndividir.Name = "bpndividir";
            bpndividir.Size = new Size(75, 23);
            bpndividir.TabIndex = 7;
            bpndividir.Text = "Dividir";
            bpndividir.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(558, 93);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(19, 21);
            lblresultado.TabIndex = 8;
            lblresultado.Text = "0";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 215);
            Controls.Add(lblresultado);
            Controls.Add(bpndividir);
            Controls.Add(bpnmultiplicar);
            Controls.Add(bpnsubtrair);
            Controls.Add(bpnsomar);
            Controls.Add(txtnumero2);
            Controls.Add(lblnumero2);
            Controls.Add(txtnumero1);
            Controls.Add(lblnumero1);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero1;
        private TextBox txtnumero1;
        private Label lblnumero2;
        private TextBox txtnumero2;
        private Button bpnsomar;
        private Button bpnsubtrair;
        private Button bpnmultiplicar;
        private Button bpndividir;
        private Label lblresultado;
    }
}
