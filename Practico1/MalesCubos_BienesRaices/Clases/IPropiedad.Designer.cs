
namespace MalesCubos_BienesRaices.Clases
{
    partial class IPropiedad
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
            this.tc = new System.Windows.Forms.TabControl();
            this.Datos = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDirP = new System.Windows.Forms.TextBox();
            this.cbDisponibleA = new System.Windows.Forms.CheckBox();
            this.cbDisponibleC = new System.Windows.Forms.CheckBox();
            this.cbAlquilada = new System.Windows.Forms.CheckBox();
            this.cbComprada = new System.Windows.Forms.CheckBox();
            this.tbNombreP = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Habitaciones = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDisp = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvHabs = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.TabPage();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSuperficie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Areaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc.SuspendLayout();
            this.Datos.SuspendLayout();
            this.Habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabs)).BeginInit();
            this.Area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperficie)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.Datos);
            this.tc.Controls.Add(this.Habitaciones);
            this.tc.Controls.Add(this.Area);
            this.tc.Location = new System.Drawing.Point(13, 13);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(291, 240);
            this.tc.TabIndex = 0;
            this.tc.SelectedIndexChanged += new System.EventHandler(this.tc_SelectedIndexChanged);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.label2);
            this.Datos.Controls.Add(this.label1);
            this.Datos.Controls.Add(this.tbDirP);
            this.Datos.Controls.Add(this.cbDisponibleA);
            this.Datos.Controls.Add(this.cbDisponibleC);
            this.Datos.Controls.Add(this.cbAlquilada);
            this.Datos.Controls.Add(this.cbComprada);
            this.Datos.Controls.Add(this.tbNombreP);
            this.Datos.Controls.Add(this.btnBorrar);
            this.Datos.Controls.Add(this.btnGuardar);
            this.Datos.Location = new System.Drawing.Point(4, 24);
            this.Datos.Name = "Datos";
            this.Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Datos.Size = new System.Drawing.Size(283, 212);
            this.Datos.TabIndex = 0;
            this.Datos.Text = "Datos";
            this.Datos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // tbDirP
            // 
            this.tbDirP.Location = new System.Drawing.Point(90, 58);
            this.tbDirP.Name = "tbDirP";
            this.tbDirP.Size = new System.Drawing.Size(164, 23);
            this.tbDirP.TabIndex = 21;
            // 
            // cbDisponibleA
            // 
            this.cbDisponibleA.AutoSize = true;
            this.cbDisponibleA.Location = new System.Drawing.Point(59, 146);
            this.cbDisponibleA.Name = "cbDisponibleA";
            this.cbDisponibleA.Size = new System.Drawing.Size(150, 19);
            this.cbDisponibleA.TabIndex = 20;
            this.cbDisponibleA.Text = "Disponible para alquilar";
            this.cbDisponibleA.UseVisualStyleBackColor = true;
            // 
            // cbDisponibleC
            // 
            this.cbDisponibleC.AutoSize = true;
            this.cbDisponibleC.Location = new System.Drawing.Point(59, 122);
            this.cbDisponibleC.Name = "cbDisponibleC";
            this.cbDisponibleC.Size = new System.Drawing.Size(156, 19);
            this.cbDisponibleC.TabIndex = 19;
            this.cbDisponibleC.Text = "Disponible para comprar";
            this.cbDisponibleC.UseVisualStyleBackColor = true;
            // 
            // cbAlquilada
            // 
            this.cbAlquilada.AutoSize = true;
            this.cbAlquilada.Location = new System.Drawing.Point(43, 97);
            this.cbAlquilada.Name = "cbAlquilada";
            this.cbAlquilada.Size = new System.Drawing.Size(76, 19);
            this.cbAlquilada.TabIndex = 18;
            this.cbAlquilada.Text = "Alquilada";
            this.cbAlquilada.UseVisualStyleBackColor = true;
            // 
            // cbComprada
            // 
            this.cbComprada.AutoSize = true;
            this.cbComprada.Location = new System.Drawing.Point(153, 97);
            this.cbComprada.Name = "cbComprada";
            this.cbComprada.Size = new System.Drawing.Size(82, 19);
            this.cbComprada.TabIndex = 17;
            this.cbComprada.Text = "Comprada";
            this.cbComprada.UseVisualStyleBackColor = true;
            // 
            // tbNombreP
            // 
            this.tbNombreP.Location = new System.Drawing.Point(90, 18);
            this.tbNombreP.Name = "tbNombreP";
            this.tbNombreP.Size = new System.Drawing.Size(164, 23);
            this.tbNombreP.TabIndex = 16;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(7, 183);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(202, 183);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Habitaciones
            // 
            this.Habitaciones.Controls.Add(this.label4);
            this.Habitaciones.Controls.Add(this.label3);
            this.Habitaciones.Controls.Add(this.dgvDisp);
            this.Habitaciones.Controls.Add(this.dgvHabs);
            this.Habitaciones.Controls.Add(this.btnQuitar);
            this.Habitaciones.Controls.Add(this.btnAñadir);
            this.Habitaciones.Location = new System.Drawing.Point(4, 24);
            this.Habitaciones.Name = "Habitaciones";
            this.Habitaciones.Padding = new System.Windows.Forms.Padding(3);
            this.Habitaciones.Size = new System.Drawing.Size(283, 212);
            this.Habitaciones.TabIndex = 1;
            this.Habitaciones.Text = "Habitaciones";
            this.Habitaciones.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actuales";
            // 
            // dgvDisp
            // 
            this.dgvDisp.AllowUserToAddRows = false;
            this.dgvDisp.AllowUserToDeleteRows = false;
            this.dgvDisp.AllowUserToResizeColumns = false;
            this.dgvDisp.AllowUserToResizeRows = false;
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.dgvDisp.Location = new System.Drawing.Point(146, 38);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.RowHeadersVisible = false;
            this.dgvDisp.RowTemplate.Height = 25;
            this.dgvDisp.Size = new System.Drawing.Size(131, 139);
            this.dgvDisp.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 159.3909F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.FillWeight = 40.60914F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dgvHabs
            // 
            this.dgvHabs.AllowUserToAddRows = false;
            this.dgvHabs.AllowUserToDeleteRows = false;
            this.dgvHabs.AllowUserToResizeColumns = false;
            this.dgvHabs.AllowUserToResizeRows = false;
            this.dgvHabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Check});
            this.dgvHabs.Location = new System.Drawing.Point(7, 38);
            this.dgvHabs.Name = "dgvHabs";
            this.dgvHabs.RowHeadersVisible = false;
            this.dgvHabs.RowTemplate.Height = 25;
            this.dgvHabs.Size = new System.Drawing.Size(133, 139);
            this.dgvHabs.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.FillWeight = 159.3909F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Check.FillWeight = 40.60914F;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(34, 183);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(178, 183);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // Area
            // 
            this.Area.Controls.Add(this.tbArea);
            this.Area.Controls.Add(this.label5);
            this.Area.Controls.Add(this.dgvSuperficie);
            this.Area.Location = new System.Drawing.Point(4, 24);
            this.Area.Name = "Area";
            this.Area.Padding = new System.Windows.Forms.Padding(3);
            this.Area.Size = new System.Drawing.Size(283, 212);
            this.Area.TabIndex = 2;
            this.Area.Text = "Superficie";
            this.Area.UseVisualStyleBackColor = true;
            // 
            // tbArea
            // 
            this.tbArea.Enabled = false;
            this.tbArea.Location = new System.Drawing.Point(185, 181);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(87, 23);
            this.tbArea.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area total:";
            // 
            // dgvSuperficie
            // 
            this.dgvSuperficie.AllowUserToAddRows = false;
            this.dgvSuperficie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuperficie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Areaa});
            this.dgvSuperficie.Location = new System.Drawing.Point(3, 6);
            this.dgvSuperficie.Name = "dgvSuperficie";
            this.dgvSuperficie.RowHeadersVisible = false;
            this.dgvSuperficie.RowTemplate.Height = 25;
            this.dgvSuperficie.Size = new System.Drawing.Size(274, 167);
            this.dgvSuperficie.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 159.3909F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre de habitacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Areaa
            // 
            this.Areaa.HeaderText = "Area";
            this.Areaa.Name = "Areaa";
            this.Areaa.ReadOnly = true;
            // 
            // IPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 265);
            this.Controls.Add(this.tc);
            this.Name = "IPropiedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Propiedad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IPropiedad_FormClosing);
            this.Load += new System.EventHandler(this.IPropiedad_Load);
            this.tc.ResumeLayout(false);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.Habitaciones.ResumeLayout(false);
            this.Habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabs)).EndInit();
            this.Area.ResumeLayout(false);
            this.Area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperficie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage Datos;
        private System.Windows.Forms.TabPage Habitaciones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dgvHabs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TabPage Area;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSuperficie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Areaa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDirP;
        private System.Windows.Forms.CheckBox cbDisponibleA;
        private System.Windows.Forms.CheckBox cbDisponibleC;
        private System.Windows.Forms.CheckBox cbAlquilada;
        private System.Windows.Forms.CheckBox cbComprada;
        private System.Windows.Forms.TextBox tbNombreP;
    }
}