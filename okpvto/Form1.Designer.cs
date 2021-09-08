
namespace okpvto
{
    partial class Form1
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
            this.richTextBoxresultst = new System.Windows.Forms.RichTextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnpremio = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // richTextBoxresultst
            // 
            this.richTextBoxresultst.Location = new System.Drawing.Point(12, 61);
            this.richTextBoxresultst.Name = "richTextBoxresultst";
            this.richTextBoxresultst.Size = new System.Drawing.Size(658, 390);
            this.richTextBoxresultst.TabIndex = 0;
            this.richTextBoxresultst.Text = "";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(595, 22);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 33);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "*Salir*";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(381, 22);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(46, 32);
            this.panelColor.TabIndex = 2;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            this.panelColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnpremio
            // 
            this.btnpremio.Location = new System.Drawing.Point(514, 21);
            this.btnpremio.Name = "btnpremio";
            this.btnpremio.Size = new System.Drawing.Size(75, 34);
            this.btnpremio.TabIndex = 3;
            this.btnpremio.Text = "*Premio*";
            this.btnpremio.UseVisualStyleBackColor = true;
            this.btnpremio.Click += new System.EventHandler(this.btnpremio_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(433, 21);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 34);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "*Enviar*";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "txtValue";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(17, 0);
            this.linkLabel1.Location = new System.Drawing.Point(22, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.Text = " *Panel de Mensajes";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 463);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnpremio);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.richTextBoxresultst);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holi putos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxresultst;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnpremio;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

