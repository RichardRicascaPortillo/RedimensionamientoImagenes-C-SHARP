
namespace imagenProporcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txOrigen = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txEntrada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.anchoNuevo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.altoNuevo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txDestino = new System.Windows.Forms.TextBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta de la Imagen";
            // 
            // txOrigen
            // 
            this.txOrigen.Location = new System.Drawing.Point(141, 4);
            this.txOrigen.Name = "txOrigen";
            this.txOrigen.Size = new System.Drawing.Size(518, 22);
            this.txOrigen.TabIndex = 1;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(681, 4);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(107, 31);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar ...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 72);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(578, 366);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alto";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlto.Location = new System.Drawing.Point(704, 143);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(18, 20);
            this.lblAlto.TabIndex = 5;
            this.lblAlto.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ancho";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.Location = new System.Drawing.Point(704, 103);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(18, 20);
            this.lblAncho.TabIndex = 7;
            this.lblAncho.Text = "0";
            // 
            // txEntrada
            // 
            this.txEntrada.Location = new System.Drawing.Point(599, 240);
            this.txEntrada.Name = "txEntrada";
            this.txEntrada.Size = new System.Drawing.Size(100, 22);
            this.txEntrada.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nueva dimension (Ancho)";
            // 
            // anchoNuevo
            // 
            this.anchoNuevo.AutoSize = true;
            this.anchoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchoNuevo.Location = new System.Drawing.Point(711, 282);
            this.anchoNuevo.Name = "anchoNuevo";
            this.anchoNuevo.Size = new System.Drawing.Size(18, 20);
            this.anchoNuevo.TabIndex = 14;
            this.anchoNuevo.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ancho (new)";
            // 
            // altoNuevo
            // 
            this.altoNuevo.AutoSize = true;
            this.altoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoNuevo.Location = new System.Drawing.Point(711, 325);
            this.altoNuevo.Name = "altoNuevo";
            this.altoNuevo.Size = new System.Drawing.Size(18, 20);
            this.altoNuevo.TabIndex = 12;
            this.altoNuevo.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(596, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Alto (new)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ruta Destino";
            // 
            // txDestino
            // 
            this.txDestino.Location = new System.Drawing.Point(141, 44);
            this.txDestino.Name = "txDestino";
            this.txDestino.Size = new System.Drawing.Size(518, 22);
            this.txDestino.TabIndex = 16;
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(681, 54);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(107, 31);
            this.btnDestino.TabIndex = 18;
            this.btnDestino.Text = "Ruta Destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(664, 390);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 48);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Redimensionar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.txDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anchoNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.altoNuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txEntrada);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txOrigen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txOrigen;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label anchoNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label altoNuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txDestino;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnGuardar;
    }
}

