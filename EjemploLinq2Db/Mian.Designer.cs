namespace EjemploLinq2Db
{
    partial class Mian
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
            this.grdAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.GpAlumnos = new System.Windows.Forms.GroupBox();
            this.GpCursos = new System.Windows.Forms.GroupBox();
            this.btnCursoBuscar = new System.Windows.Forms.Button();
            this.btnCursoModificar = new System.Windows.Forms.Button();
            this.btnCursoCreate = new System.Windows.Forms.Button();
            this.btnCursoBorrar = new System.Windows.Forms.Button();
            this.grdCursos = new System.Windows.Forms.DataGridView();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).BeginInit();
            this.GpAlumnos.SuspendLayout();
            this.GpCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAlumnos
            // 
            this.grdAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlumnos.Location = new System.Drawing.Point(6, 57);
            this.grdAlumnos.Name = "grdAlumnos";
            this.grdAlumnos.Size = new System.Drawing.Size(435, 378);
            this.grdAlumnos.TabIndex = 0;
            this.grdAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlumnos_CellClick);
            this.grdAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlumnos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(122, 31);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(110, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(315, 11);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(60, 20);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(381, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 20);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(381, 31);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(60, 20);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(315, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 20);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GpAlumnos
            // 
            this.GpAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpAlumnos.Controls.Add(this.grdAlumnos);
            this.GpAlumnos.Controls.Add(this.btnBuscar);
            this.GpAlumnos.Controls.Add(this.btnModificar);
            this.GpAlumnos.Controls.Add(this.btnCreate);
            this.GpAlumnos.Controls.Add(this.btnBorrar);
            this.GpAlumnos.Controls.Add(this.txtName);
            this.GpAlumnos.Controls.Add(this.label1);
            this.GpAlumnos.Controls.Add(this.label2);
            this.GpAlumnos.Controls.Add(this.txtLastName);
            this.GpAlumnos.Location = new System.Drawing.Point(5, 5);
            this.GpAlumnos.Name = "GpAlumnos";
            this.GpAlumnos.Size = new System.Drawing.Size(447, 441);
            this.GpAlumnos.TabIndex = 11;
            this.GpAlumnos.TabStop = false;
            this.GpAlumnos.Text = "Alumnos";
            // 
            // GpCursos
            // 
            this.GpCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpCursos.Controls.Add(this.btnCursoBuscar);
            this.GpCursos.Controls.Add(this.btnCursoModificar);
            this.GpCursos.Controls.Add(this.btnCursoCreate);
            this.GpCursos.Controls.Add(this.btnCursoBorrar);
            this.GpCursos.Controls.Add(this.grdCursos);
            this.GpCursos.Controls.Add(this.txtCurso);
            this.GpCursos.Controls.Add(this.label3);
            this.GpCursos.Enabled = false;
            this.GpCursos.Location = new System.Drawing.Point(458, 5);
            this.GpCursos.Name = "GpCursos";
            this.GpCursos.Size = new System.Drawing.Size(338, 441);
            this.GpCursos.TabIndex = 12;
            this.GpCursos.TabStop = false;
            this.GpCursos.Text = "Cursos del Alumno";
            // 
            // btnCursoBuscar
            // 
            this.btnCursoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCursoBuscar.Location = new System.Drawing.Point(204, 31);
            this.btnCursoBuscar.Name = "btnCursoBuscar";
            this.btnCursoBuscar.Size = new System.Drawing.Size(60, 20);
            this.btnCursoBuscar.TabIndex = 14;
            this.btnCursoBuscar.Text = "Buscar";
            this.btnCursoBuscar.UseVisualStyleBackColor = true;
            this.btnCursoBuscar.Click += new System.EventHandler(this.btnCursoBuscar_Click);
            // 
            // btnCursoModificar
            // 
            this.btnCursoModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCursoModificar.Enabled = false;
            this.btnCursoModificar.Location = new System.Drawing.Point(270, 11);
            this.btnCursoModificar.Name = "btnCursoModificar";
            this.btnCursoModificar.Size = new System.Drawing.Size(60, 20);
            this.btnCursoModificar.TabIndex = 12;
            this.btnCursoModificar.Text = "Modificar";
            this.btnCursoModificar.UseVisualStyleBackColor = true;
            this.btnCursoModificar.Click += new System.EventHandler(this.btnCursoModificar_Click);
            // 
            // btnCursoCreate
            // 
            this.btnCursoCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCursoCreate.Location = new System.Drawing.Point(204, 11);
            this.btnCursoCreate.Name = "btnCursoCreate";
            this.btnCursoCreate.Size = new System.Drawing.Size(60, 20);
            this.btnCursoCreate.TabIndex = 11;
            this.btnCursoCreate.Text = "Crear";
            this.btnCursoCreate.UseVisualStyleBackColor = true;
            this.btnCursoCreate.Click += new System.EventHandler(this.btnCursoCreate_Click);
            // 
            // btnCursoBorrar
            // 
            this.btnCursoBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCursoBorrar.Enabled = false;
            this.btnCursoBorrar.Location = new System.Drawing.Point(270, 31);
            this.btnCursoBorrar.Name = "btnCursoBorrar";
            this.btnCursoBorrar.Size = new System.Drawing.Size(60, 20);
            this.btnCursoBorrar.TabIndex = 13;
            this.btnCursoBorrar.Text = "Borrar";
            this.btnCursoBorrar.UseVisualStyleBackColor = true;
            this.btnCursoBorrar.Click += new System.EventHandler(this.btnCursoBorrar_Click);
            // 
            // grdCursos
            // 
            this.grdCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCursos.Location = new System.Drawing.Point(6, 59);
            this.grdCursos.Name = "grdCursos";
            this.grdCursos.Size = new System.Drawing.Size(324, 374);
            this.grdCursos.TabIndex = 3;
            this.grdCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCursos_CellClick);
            this.grdCursos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCursos_CellDoubleClick);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(6, 31);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(110, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Curso";
            // 
            // Mian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GpCursos);
            this.Controls.Add(this.GpAlumnos);
            this.Name = "Mian";
            this.Text = "Coneccion a base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).EndInit();
            this.GpAlumnos.ResumeLayout(false);
            this.GpAlumnos.PerformLayout();
            this.GpCursos.ResumeLayout(false);
            this.GpCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox GpAlumnos;
        private System.Windows.Forms.GroupBox GpCursos;
        private System.Windows.Forms.Button btnCursoBuscar;
        private System.Windows.Forms.Button btnCursoModificar;
        private System.Windows.Forms.Button btnCursoCreate;
        private System.Windows.Forms.Button btnCursoBorrar;
        private System.Windows.Forms.DataGridView grdCursos;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label3;
    }
}

