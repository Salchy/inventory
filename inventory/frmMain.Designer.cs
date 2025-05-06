namespace inventory
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnVerEmpresas = new System.Windows.Forms.Button();
            this.btnVerStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerEmpresas
            // 
            this.btnVerEmpresas.Location = new System.Drawing.Point(145, 113);
            this.btnVerEmpresas.Name = "btnVerEmpresas";
            this.btnVerEmpresas.Size = new System.Drawing.Size(115, 25);
            this.btnVerEmpresas.TabIndex = 0;
            this.btnVerEmpresas.Text = "VER EMPRESAS";
            this.btnVerEmpresas.UseVisualStyleBackColor = true;
            // 
            // btnVerStock
            // 
            this.btnVerStock.Location = new System.Drawing.Point(145, 165);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(115, 25);
            this.btnVerStock.TabIndex = 0;
            this.btnVerStock.Text = "VER STOCK";
            this.btnVerStock.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.btnVerStock);
            this.Controls.Add(this.btnVerEmpresas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerEmpresas;
        private System.Windows.Forms.Button btnVerStock;
    }
}

