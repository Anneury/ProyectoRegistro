
namespace ProyectoRegistro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Guardar = new System.Windows.Forms.Button();
            this.Listar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IdNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RolesComboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.Location = new System.Drawing.Point(158, 306);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(118, 62);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Listar
            // 
            this.Listar.Image = ((System.Drawing.Image)(resources.GetObject("Listar.Image")));
            this.Listar.Location = new System.Drawing.Point(300, 306);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(114, 62);
            this.Listar.TabIndex = 1;
            this.Listar.Text = "Listar";
            this.Listar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(613, 188);
            this.dataGridView1.TabIndex = 2;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(102, 88);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(229, 27);
            this.textNombre.TabIndex = 3;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(102, 170);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(144, 27);
            this.textTelefono.TabIndex = 4;
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(102, 127);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(174, 27);
            this.textCedula.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion:";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(102, 213);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(202, 27);
            this.textDireccion.TabIndex = 10;
            // 
            // Nuevo
            // 
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.Location = new System.Drawing.Point(28, 306);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(111, 61);
            this.Nuevo.TabIndex = 11;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // IdNumericUpDown1
            // 
            this.IdNumericUpDown1.Location = new System.Drawing.Point(102, 28);
            this.IdNumericUpDown1.Name = "IdNumericUpDown1";
            this.IdNumericUpDown1.Size = new System.Drawing.Size(66, 27);
            this.IdNumericUpDown1.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.Location = new System.Drawing.Point(192, 25);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(47, 46);
            this.Buscar.TabIndex = 14;
            this.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Location = new System.Drawing.Point(245, 25);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(144, 46);
            this.Eliminar.TabIndex = 15;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 136);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // RolesComboBox1
            // 
            this.RolesComboBox1.FormattingEnabled = true;
            this.RolesComboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Estudiante",
            "Conserje",
            "Profesor"});
            this.RolesComboBox1.Location = new System.Drawing.Point(438, 257);
            this.RolesComboBox1.Name = "RolesComboBox1";
            this.RolesComboBox1.Size = new System.Drawing.Size(151, 28);
            this.RolesComboBox1.TabIndex = 17;
            this.RolesComboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RolesComboBox1_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 27);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Rol desempeñado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 566);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RolesComboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.IdNumericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.Guardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown IdNumericUpDown1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox RolesComboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
    }
}

