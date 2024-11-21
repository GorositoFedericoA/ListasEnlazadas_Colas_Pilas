namespace ListaEnlazada_Pila_Colas
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
            this.btnAgregarListaEnalazada = new System.Windows.Forms.Button();
            this.lstBoxListaEnlazada = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxPila = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBoxCola = new System.Windows.Forms.ListBox();
            this.btnEliminarListaEnlazada = new System.Windows.Forms.Button();
            this.btnEliminarPila = new System.Windows.Forms.Button();
            this.btnAgregarPila = new System.Windows.Forms.Button();
            this.btnEliminarCola = new System.Windows.Forms.Button();
            this.btnAgregarCola = new System.Windows.Forms.Button();
            this.txtBoxListaEnlazada = new System.Windows.Forms.TextBox();
            this.txtBoxPila = new System.Windows.Forms.TextBox();
            this.txtBoxCola = new System.Windows.Forms.TextBox();
            this.btnAgregarAlFinal = new System.Windows.Forms.Button();
            this.btnEliminarAlFinal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarListaEnalazada
            // 
            this.btnAgregarListaEnalazada.Location = new System.Drawing.Point(33, 368);
            this.btnAgregarListaEnalazada.Name = "btnAgregarListaEnalazada";
            this.btnAgregarListaEnalazada.Size = new System.Drawing.Size(92, 36);
            this.btnAgregarListaEnalazada.TabIndex = 0;
            this.btnAgregarListaEnalazada.Text = "AgregarP";
            this.btnAgregarListaEnalazada.UseVisualStyleBackColor = true;
            this.btnAgregarListaEnalazada.Click += new System.EventHandler(this.btnAgregarListaEnalazada_Click);
            // 
            // lstBoxListaEnlazada
            // 
            this.lstBoxListaEnlazada.FormattingEnabled = true;
            this.lstBoxListaEnlazada.ItemHeight = 16;
            this.lstBoxListaEnlazada.Location = new System.Drawing.Point(33, 118);
            this.lstBoxListaEnlazada.Name = "lstBoxListaEnlazada";
            this.lstBoxListaEnlazada.Size = new System.Drawing.Size(196, 244);
            this.lstBoxListaEnlazada.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista Enlazada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Píla";
            // 
            // lstBoxPila
            // 
            this.lstBoxPila.FormattingEnabled = true;
            this.lstBoxPila.ItemHeight = 16;
            this.lstBoxPila.Location = new System.Drawing.Point(305, 118);
            this.lstBoxPila.Name = "lstBoxPila";
            this.lstBoxPila.Size = new System.Drawing.Size(196, 244);
            this.lstBoxPila.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cola";
            // 
            // lstBoxCola
            // 
            this.lstBoxCola.FormattingEnabled = true;
            this.lstBoxCola.ItemHeight = 16;
            this.lstBoxCola.Location = new System.Drawing.Point(566, 118);
            this.lstBoxCola.Name = "lstBoxCola";
            this.lstBoxCola.Size = new System.Drawing.Size(196, 244);
            this.lstBoxCola.TabIndex = 13;
            // 
            // btnEliminarListaEnlazada
            // 
            this.btnEliminarListaEnlazada.Location = new System.Drawing.Point(131, 368);
            this.btnEliminarListaEnlazada.Name = "btnEliminarListaEnlazada";
            this.btnEliminarListaEnlazada.Size = new System.Drawing.Size(98, 36);
            this.btnEliminarListaEnlazada.TabIndex = 15;
            this.btnEliminarListaEnlazada.Text = "EliminarP";
            this.btnEliminarListaEnlazada.UseVisualStyleBackColor = true;
            this.btnEliminarListaEnlazada.Click += new System.EventHandler(this.btnEliminarListaEnlazada_Click);
            // 
            // btnEliminarPila
            // 
            this.btnEliminarPila.Location = new System.Drawing.Point(417, 378);
            this.btnEliminarPila.Name = "btnEliminarPila";
            this.btnEliminarPila.Size = new System.Drawing.Size(75, 36);
            this.btnEliminarPila.TabIndex = 17;
            this.btnEliminarPila.Text = "Eliminar";
            this.btnEliminarPila.UseVisualStyleBackColor = true;
            this.btnEliminarPila.Click += new System.EventHandler(this.btnEliminarPila_Click);
            // 
            // btnAgregarPila
            // 
            this.btnAgregarPila.Location = new System.Drawing.Point(310, 378);
            this.btnAgregarPila.Name = "btnAgregarPila";
            this.btnAgregarPila.Size = new System.Drawing.Size(75, 36);
            this.btnAgregarPila.TabIndex = 16;
            this.btnAgregarPila.Text = "Agregar";
            this.btnAgregarPila.UseVisualStyleBackColor = true;
            this.btnAgregarPila.Click += new System.EventHandler(this.btnAgregarPila_Click);
            // 
            // btnEliminarCola
            // 
            this.btnEliminarCola.Location = new System.Drawing.Point(678, 378);
            this.btnEliminarCola.Name = "btnEliminarCola";
            this.btnEliminarCola.Size = new System.Drawing.Size(75, 36);
            this.btnEliminarCola.TabIndex = 19;
            this.btnEliminarCola.Text = "Eliminar";
            this.btnEliminarCola.UseVisualStyleBackColor = true;
            this.btnEliminarCola.Click += new System.EventHandler(this.btnEliminarCola_Click);
            // 
            // btnAgregarCola
            // 
            this.btnAgregarCola.Location = new System.Drawing.Point(571, 378);
            this.btnAgregarCola.Name = "btnAgregarCola";
            this.btnAgregarCola.Size = new System.Drawing.Size(75, 36);
            this.btnAgregarCola.TabIndex = 18;
            this.btnAgregarCola.Text = "Agregar";
            this.btnAgregarCola.UseVisualStyleBackColor = true;
            this.btnAgregarCola.Click += new System.EventHandler(this.btnAgregarCola_Click);
            // 
            // txtBoxListaEnlazada
            // 
            this.txtBoxListaEnlazada.Location = new System.Drawing.Point(33, 73);
            this.txtBoxListaEnlazada.Name = "txtBoxListaEnlazada";
            this.txtBoxListaEnlazada.Size = new System.Drawing.Size(196, 22);
            this.txtBoxListaEnlazada.TabIndex = 20;
            // 
            // txtBoxPila
            // 
            this.txtBoxPila.Location = new System.Drawing.Point(305, 73);
            this.txtBoxPila.Name = "txtBoxPila";
            this.txtBoxPila.Size = new System.Drawing.Size(196, 22);
            this.txtBoxPila.TabIndex = 21;
            // 
            // txtBoxCola
            // 
            this.txtBoxCola.Location = new System.Drawing.Point(566, 73);
            this.txtBoxCola.Name = "txtBoxCola";
            this.txtBoxCola.Size = new System.Drawing.Size(196, 22);
            this.txtBoxCola.TabIndex = 22;
            // 
            // btnAgregarAlFinal
            // 
            this.btnAgregarAlFinal.Location = new System.Drawing.Point(33, 410);
            this.btnAgregarAlFinal.Name = "btnAgregarAlFinal";
            this.btnAgregarAlFinal.Size = new System.Drawing.Size(92, 36);
            this.btnAgregarAlFinal.TabIndex = 23;
            this.btnAgregarAlFinal.Text = "AgregarF";
            this.btnAgregarAlFinal.UseVisualStyleBackColor = true;
            this.btnAgregarAlFinal.Click += new System.EventHandler(this.btnAgregarAlFinal_Click);
            // 
            // btnEliminarAlFinal
            // 
            this.btnEliminarAlFinal.Location = new System.Drawing.Point(131, 410);
            this.btnEliminarAlFinal.Name = "btnEliminarAlFinal";
            this.btnEliminarAlFinal.Size = new System.Drawing.Size(98, 36);
            this.btnEliminarAlFinal.TabIndex = 24;
            this.btnEliminarAlFinal.Text = "EliminarF";
            this.btnEliminarAlFinal.UseVisualStyleBackColor = true;
            this.btnEliminarAlFinal.Click += new System.EventHandler(this.btnEliminarAlFinal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(687, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEliminarAlFinal);
            this.Controls.Add(this.btnAgregarAlFinal);
            this.Controls.Add(this.txtBoxCola);
            this.Controls.Add(this.txtBoxPila);
            this.Controls.Add(this.txtBoxListaEnlazada);
            this.Controls.Add(this.btnEliminarCola);
            this.Controls.Add(this.btnAgregarCola);
            this.Controls.Add(this.btnEliminarPila);
            this.Controls.Add(this.btnAgregarPila);
            this.Controls.Add(this.btnEliminarListaEnlazada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBoxCola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBoxPila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxListaEnlazada);
            this.Controls.Add(this.btnAgregarListaEnalazada);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarListaEnalazada;
        private System.Windows.Forms.ListBox lstBoxListaEnlazada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxPila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBoxCola;
        private System.Windows.Forms.Button btnEliminarListaEnlazada;
        private System.Windows.Forms.Button btnEliminarPila;
        private System.Windows.Forms.Button btnAgregarPila;
        private System.Windows.Forms.Button btnEliminarCola;
        private System.Windows.Forms.Button btnAgregarCola;
        private System.Windows.Forms.TextBox txtBoxListaEnlazada;
        private System.Windows.Forms.TextBox txtBoxPila;
        private System.Windows.Forms.TextBox txtBoxCola;
        private System.Windows.Forms.Button btnAgregarAlFinal;
        private System.Windows.Forms.Button btnEliminarAlFinal;
        private System.Windows.Forms.Button btnClose;
    }
}

