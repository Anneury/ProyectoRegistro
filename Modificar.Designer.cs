
namespace ProyectoRegistro
{
    partial class Modificar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(146, 66);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(184, 27);
            this.textNombre.TabIndex = 0;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(146, 219);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(150, 27);
            this.textTelefono.TabIndex = 1;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(146, 170);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(169, 27);
            this.textDireccion.TabIndex = 2;
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(146, 118);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(150, 27);
            this.textCedula.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono:";
            // 
            // Guardar
            // 
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.Location = new System.Drawing.Point(65, 324);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(106, 84);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar Cambios";
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.Location = new System.Drawing.Point(242, 324);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(102, 86);
            this.Cancelar.TabIndex = 9;
            this.Cancelar.Text = "Eliminar Cambios";
            this.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Editando una persona.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // IdNumericUpDown1
            // 
            this.IdNumericUpDown1.Location = new System.Drawing.Point(354, 24);
            this.IdNumericUpDown1.Name = "IdNumericUpDown1";
            this.IdNumericUpDown1.Size = new System.Drawing.Size(83, 27);
            this.IdNumericUpDown1.TabIndex = 11;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 443);
            this.Controls.Add(this.IdNumericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textNombre);
            this.Name = "Modificar";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown1;
    }
}