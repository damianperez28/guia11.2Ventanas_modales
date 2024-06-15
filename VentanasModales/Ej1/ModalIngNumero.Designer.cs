namespace Ej1
{
    partial class ModalIngNumero
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
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.tbNumIng = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarNumero.Location = new System.Drawing.Point(131, 16);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(62, 42);
            this.btnAgregarNumero.TabIndex = 1;
            this.btnAgregarNumero.Text = "Agregar numero";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // tbNumIng
            // 
            this.tbNumIng.Location = new System.Drawing.Point(15, 29);
            this.tbNumIng.Name = "tbNumIng";
            this.tbNumIng.Size = new System.Drawing.Size(107, 20);
            this.tbNumIng.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.groupBox1.Controls.Add(this.btnAgregarNumero);
            this.groupBox1.Controls.Add(this.tbNumIng);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar numero";
            // 
            // ModalIngNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(226, 94);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModalIngNumero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalIngNumero";
            this.Load += new System.EventHandler(this.ModalIngNumero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbNumIng;
    }
}