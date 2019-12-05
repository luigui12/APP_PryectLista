namespace APP_PryectLista
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.listViewestudiantes = new System.Windows.Forms.ListView();
            this.nombre1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edad1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(109, 45);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(109, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Solter@",
            "Casasd@",
            "Viudo",
            "Divorciad@",
            "Union Libre"});
            this.comboBox2.Location = new System.Drawing.Point(109, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(109, 161);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(100, 20);
            this.edad.TabIndex = 7;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(270, 45);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(119, 23);
            this.agregar.TabIndex = 8;
            this.agregar.Text = "Agregar a la lista";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // listViewestudiantes
            // 
            this.listViewestudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre1,
            this.genero,
            this.estado,
            this.edad1});
            this.listViewestudiantes.HideSelection = false;
            this.listViewestudiantes.Location = new System.Drawing.Point(12, 202);
            this.listViewestudiantes.Name = "listViewestudiantes";
            this.listViewestudiantes.Size = new System.Drawing.Size(537, 148);
            this.listViewestudiantes.TabIndex = 9;
            this.listViewestudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewestudiantes.View = System.Windows.Forms.View.Details;
            // 
            // nombre1
            // 
            this.nombre1.Text = "Nombre Completo";
            this.nombre1.Width = 119;
            // 
            // genero
            // 
            this.genero.Text = "Género";
            // 
            // estado
            // 
            this.estado.Text = "Estado Civil";
            this.estado.Width = 88;
            // 
            // edad1
            // 
            this.edad1.Text = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 362);
            this.Controls.Add(this.listViewestudiantes);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Datos_Estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.ListView listViewestudiantes;
        private System.Windows.Forms.ColumnHeader nombre1;
        private System.Windows.Forms.ColumnHeader genero;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader edad1;
    }
}

