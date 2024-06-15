namespace Ej1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSecuencial = new System.Windows.Forms.RadioButton();
            this.rbBinaria = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbNumBusc = new System.Windows.Forms.TextBox();
            this.btnModalAddNum = new System.Windows.Forms.Button();
            this.btnModalPromedio = new System.Windows.Forms.Button();
            this.btnModalListado = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Chartreuse;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.tbNumBusc);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 193);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese un numero";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.rbSecuencial);
            this.groupBox4.Controls.Add(this.rbBinaria);
            this.groupBox4.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox4.Location = new System.Drawing.Point(19, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 79);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Metodo de busqueda";
            // 
            // rbSecuencial
            // 
            this.rbSecuencial.AutoSize = true;
            this.rbSecuencial.ForeColor = System.Drawing.Color.Chartreuse;
            this.rbSecuencial.Location = new System.Drawing.Point(15, 48);
            this.rbSecuencial.Name = "rbSecuencial";
            this.rbSecuencial.Size = new System.Drawing.Size(78, 17);
            this.rbSecuencial.TabIndex = 1;
            this.rbSecuencial.TabStop = true;
            this.rbSecuencial.Text = "Secuencial";
            this.rbSecuencial.UseVisualStyleBackColor = true;
            this.rbSecuencial.CheckedChanged += new System.EventHandler(this.rbSecuencial_CheckedChanged);
            // 
            // rbBinaria
            // 
            this.rbBinaria.AutoSize = true;
            this.rbBinaria.ForeColor = System.Drawing.Color.Chartreuse;
            this.rbBinaria.Location = new System.Drawing.Point(15, 25);
            this.rbBinaria.Name = "rbBinaria";
            this.rbBinaria.Size = new System.Drawing.Size(57, 17);
            this.rbBinaria.TabIndex = 0;
            this.rbBinaria.TabStop = true;
            this.rbBinaria.Text = "Binaria";
            this.rbBinaria.UseVisualStyleBackColor = true;
            this.rbBinaria.CheckedChanged += new System.EventHandler(this.rbBinaria_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(19, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(224, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbNumBusc
            // 
            this.tbNumBusc.Location = new System.Drawing.Point(118, 28);
            this.tbNumBusc.Name = "tbNumBusc";
            this.tbNumBusc.Size = new System.Drawing.Size(125, 20);
            this.tbNumBusc.TabIndex = 1;
            // 
            // btnModalAddNum
            // 
            this.btnModalAddNum.Location = new System.Drawing.Point(12, 211);
            this.btnModalAddNum.Name = "btnModalAddNum";
            this.btnModalAddNum.Size = new System.Drawing.Size(128, 50);
            this.btnModalAddNum.TabIndex = 5;
            this.btnModalAddNum.Text = "Agregar numero";
            this.btnModalAddNum.UseVisualStyleBackColor = true;
            this.btnModalAddNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModalPromedio
            // 
            this.btnModalPromedio.Location = new System.Drawing.Point(146, 211);
            this.btnModalPromedio.Name = "btnModalPromedio";
            this.btnModalPromedio.Size = new System.Drawing.Size(128, 50);
            this.btnModalPromedio.TabIndex = 6;
            this.btnModalPromedio.Text = "Ver Promedio";
            this.btnModalPromedio.UseVisualStyleBackColor = true;
            this.btnModalPromedio.Click += new System.EventHandler(this.btnModalPromedio_Click);
            // 
            // btnModalListado
            // 
            this.btnModalListado.Location = new System.Drawing.Point(12, 267);
            this.btnModalListado.Name = "btnModalListado";
            this.btnModalListado.Size = new System.Drawing.Size(262, 50);
            this.btnModalListado.TabIndex = 7;
            this.btnModalListado.Text = "Ver listado";
            this.btnModalListado.UseVisualStyleBackColor = true;
            this.btnModalListado.Click += new System.EventHandler(this.btnModalListado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.btnModalListado);
            this.Controls.Add(this.btnModalPromedio);
            this.Controls.Add(this.btnModalAddNum);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSecuencial;
        private System.Windows.Forms.RadioButton rbBinaria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbNumBusc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModalAddNum;
        private System.Windows.Forms.Button btnModalPromedio;
        private System.Windows.Forms.Button btnModalListado;
    }
}

