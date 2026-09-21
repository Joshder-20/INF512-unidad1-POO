namespace MiAppWinforms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtNum1
            this.txtNum1.Location = new System.Drawing.Point(30, 30);
            this.txtNum1.Size = new System.Drawing.Size(100, 23);

            // txtNum2
            this.txtNum2.Location = new System.Drawing.Point(30, 70);
            this.txtNum2.Size = new System.Drawing.Size(100, 23);

            // btnSumar
            this.btnSumar.Location = new System.Drawing.Point(30, 110);
            this.btnSumar.Size = new System.Drawing.Size(100, 30);
            this.btnSumar.Text = "Sumar";
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(30, 160);
            this.lblResultado.Text = "Resultado: ";

            // Form1
            this.ClientSize = new System.Drawing.Size(200, 220);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lblResultado);
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}