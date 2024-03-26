namespace AlmacenamientosDatos
{
    partial class frmDatos
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
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnRTF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(160, 90);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(134, 76);
            this.btnTxt.TabIndex = 0;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(481, 90);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(134, 76);
            this.btnCsv.TabIndex = 1;
            this.btnCsv.Text = "CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(160, 267);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(134, 76);
            this.btnXml.TabIndex = 2;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnRTF
            // 
            this.btnRTF.Location = new System.Drawing.Point(481, 267);
            this.btnRTF.Name = "btnRTF";
            this.btnRTF.Size = new System.Drawing.Size(134, 76);
            this.btnRTF.TabIndex = 3;
            this.btnRTF.Text = "RTF";
            this.btnRTF.UseVisualStyleBackColor = true;
            this.btnRTF.Click += new System.EventHandler(this.btnRTF_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRTF);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnTxt);
            this.Name = "frmDatos";
            this.Text = "Almacenamiento de Datos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnRTF;
    }
}

