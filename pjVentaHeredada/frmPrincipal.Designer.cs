namespace pjVentaHeredada
{
    partial class frmPrincipal
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
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnContado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(12, 112);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(108, 23);
            this.btnCredito.TabIndex = 0;
            this.btnCredito.Text = "Venta al Credito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnContado
            // 
            this.btnContado.Location = new System.Drawing.Point(180, 112);
            this.btnContado.Name = "btnContado";
            this.btnContado.Size = new System.Drawing.Size(118, 23);
            this.btnContado.TabIndex = 1;
            this.btnContado.Text = "Venta al Contado";
            this.btnContado.UseVisualStyleBackColor = true;
            this.btnContado.Click += new System.EventHandler(this.btnContado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Venta de Productos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContado);
            this.Controls.Add(this.btnCredito);
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCredito;
        private Button btnContado;
        private Label label1;
    }
}