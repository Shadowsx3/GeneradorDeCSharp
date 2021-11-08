
namespace MalesCubos_BienesRaices
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
            this.tc = new System.Windows.Forms.TabControl();
            this.Busqueda = new System.Windows.Forms.TabPage();
            this.dgvPB = new System.Windows.Forms.DataGridView();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBDAlquiler = new System.Windows.Forms.CheckBox();
            this.cbBDCompra = new System.Windows.Forms.CheckBox();
            this.cbBAlquilada = new System.Windows.Forms.CheckBox();
            this.cbBComprada = new System.Windows.Forms.CheckBox();
            this.tbNombreBP = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nuAreaH = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreH = new System.Windows.Forms.TextBox();
            this.btnAH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDirP = new System.Windows.Forms.TextBox();
            this.cbDisponibleA = new System.Windows.Forms.CheckBox();
            this.cbDisponibleC = new System.Windows.Forms.CheckBox();
            this.cbAlquilada = new System.Windows.Forms.CheckBox();
            this.cbComprada = new System.Windows.Forms.CheckBox();
            this.tbNombreP = new System.Windows.Forms.TextBox();
            this.btnAP = new System.Windows.Forms.Button();
            this.Superficies = new System.Windows.Forms.TabPage();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbAreaTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSuperficie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Areaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc.SuspendLayout();
            this.Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).BeginInit();
            this.Agregar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAreaH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Superficies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperficie)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc.Controls.Add(this.Busqueda);
            this.tc.Controls.Add(this.Agregar);
            this.tc.Controls.Add(this.Superficies);
            this.tc.Location = new System.Drawing.Point(12, 12);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(394, 291);
            this.tc.TabIndex = 1;
            this.tc.SelectedIndexChanged += new System.EventHandler(this.tc_SelectedIndexChanged);
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.dgvPB);
            this.Busqueda.Controls.Add(this.btnBuscarP);
            this.Busqueda.Controls.Add(this.label1);
            this.Busqueda.Controls.Add(this.cbBDAlquiler);
            this.Busqueda.Controls.Add(this.cbBDCompra);
            this.Busqueda.Controls.Add(this.cbBAlquilada);
            this.Busqueda.Controls.Add(this.cbBComprada);
            this.Busqueda.Controls.Add(this.tbNombreBP);
            this.Busqueda.Location = new System.Drawing.Point(4, 24);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Padding = new System.Windows.Forms.Padding(3);
            this.Busqueda.Size = new System.Drawing.Size(386, 263);
            this.Busqueda.TabIndex = 0;
            this.Busqueda.Text = "Busqueda";
            this.Busqueda.UseVisualStyleBackColor = true;
            // 
            // dgvPB
            // 
            this.dgvPB.AllowUserToAddRows = false;
            this.dgvPB.AllowUserToDeleteRows = false;
            this.dgvPB.AllowUserToResizeColumns = false;
            this.dgvPB.AllowUserToResizeRows = false;
            this.dgvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvPB.Location = new System.Drawing.Point(6, 107);
            this.dgvPB.MultiSelect = false;
            this.dgvPB.Name = "dgvPB";
            this.dgvPB.RowHeadersVisible = false;
            this.dgvPB.RowTemplate.Height = 25;
            this.dgvPB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPB.Size = new System.Drawing.Size(374, 150);
            this.dgvPB.TabIndex = 9;
            this.dgvPB.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPB_CellContentDoubleClick);
            this.dgvPB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPB_CellDoubleClick);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(296, 70);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarP.TabIndex = 8;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // cbBDAlquiler
            // 
            this.cbBDAlquiler.AutoSize = true;
            this.cbBDAlquiler.Location = new System.Drawing.Point(208, 42);
            this.cbBDAlquiler.Name = "cbBDAlquiler";
            this.cbBDAlquiler.Size = new System.Drawing.Size(150, 19);
            this.cbBDAlquiler.TabIndex = 4;
            this.cbBDAlquiler.Text = "Disponible para alquilar";
            this.cbBDAlquiler.ThreeState = true;
            this.cbBDAlquiler.UseVisualStyleBackColor = true;
            // 
            // cbBDCompra
            // 
            this.cbBDCompra.AutoSize = true;
            this.cbBDCompra.Location = new System.Drawing.Point(208, 15);
            this.cbBDCompra.Name = "cbBDCompra";
            this.cbBDCompra.Size = new System.Drawing.Size(156, 19);
            this.cbBDCompra.TabIndex = 3;
            this.cbBDCompra.Text = "Disponible para comprar";
            this.cbBDCompra.ThreeState = true;
            this.cbBDCompra.UseVisualStyleBackColor = true;
            // 
            // cbBAlquilada
            // 
            this.cbBAlquilada.AutoSize = true;
            this.cbBAlquilada.Location = new System.Drawing.Point(20, 42);
            this.cbBAlquilada.Name = "cbBAlquilada";
            this.cbBAlquilada.Size = new System.Drawing.Size(76, 19);
            this.cbBAlquilada.TabIndex = 2;
            this.cbBAlquilada.Text = "Alquilada";
            this.cbBAlquilada.ThreeState = true;
            this.cbBAlquilada.UseVisualStyleBackColor = true;
            // 
            // cbBComprada
            // 
            this.cbBComprada.AutoSize = true;
            this.cbBComprada.Location = new System.Drawing.Point(108, 42);
            this.cbBComprada.Name = "cbBComprada";
            this.cbBComprada.Size = new System.Drawing.Size(82, 19);
            this.cbBComprada.TabIndex = 1;
            this.cbBComprada.Text = "Comprada";
            this.cbBComprada.ThreeState = true;
            this.cbBComprada.UseVisualStyleBackColor = true;
            // 
            // tbNombreBP
            // 
            this.tbNombreBP.Location = new System.Drawing.Point(74, 13);
            this.tbNombreBP.Name = "tbNombreBP";
            this.tbNombreBP.Size = new System.Drawing.Size(116, 23);
            this.tbNombreBP.TabIndex = 0;
            // 
            // Agregar
            // 
            this.Agregar.Controls.Add(this.groupBox2);
            this.Agregar.Controls.Add(this.groupBox1);
            this.Agregar.Location = new System.Drawing.Point(4, 24);
            this.Agregar.Name = "Agregar";
            this.Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.Agregar.Size = new System.Drawing.Size(386, 263);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.nuAreaH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbNombreH);
            this.groupBox2.Controls.Add(this.btnAH);
            this.groupBox2.Location = new System.Drawing.Point(202, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habitacion";
            // 
            // nuAreaH
            // 
            this.nuAreaH.DecimalPlaces = 3;
            this.nuAreaH.Location = new System.Drawing.Point(9, 138);
            this.nuAreaH.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuAreaH.Name = "nuAreaH";
            this.nuAreaH.Size = new System.Drawing.Size(159, 23);
            this.nuAreaH.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre";
            // 
            // tbNombreH
            // 
            this.tbNombreH.Location = new System.Drawing.Point(9, 67);
            this.tbNombreH.Name = "tbNombreH";
            this.tbNombreH.Size = new System.Drawing.Size(159, 23);
            this.tbNombreH.TabIndex = 15;
            // 
            // btnAH
            // 
            this.btnAH.Location = new System.Drawing.Point(56, 228);
            this.btnAH.Name = "btnAH";
            this.btnAH.Size = new System.Drawing.Size(75, 23);
            this.btnAH.TabIndex = 1;
            this.btnAH.Text = "Agregar";
            this.btnAH.UseVisualStyleBackColor = true;
            this.btnAH.Click += new System.EventHandler(this.btnAH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDirP);
            this.groupBox1.Controls.Add(this.cbDisponibleA);
            this.groupBox1.Controls.Add(this.cbDisponibleC);
            this.groupBox1.Controls.Add(this.cbAlquilada);
            this.groupBox1.Controls.Add(this.cbComprada);
            this.groupBox1.Controls.Add(this.tbNombreP);
            this.groupBox1.Controls.Add(this.btnAP);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre";
            // 
            // tbDirP
            // 
            this.tbDirP.Location = new System.Drawing.Point(12, 88);
            this.tbDirP.Name = "tbDirP";
            this.tbDirP.Size = new System.Drawing.Size(164, 23);
            this.tbDirP.TabIndex = 13;
            // 
            // cbDisponibleA
            // 
            this.cbDisponibleA.AutoSize = true;
            this.cbDisponibleA.Location = new System.Drawing.Point(12, 182);
            this.cbDisponibleA.Name = "cbDisponibleA";
            this.cbDisponibleA.Size = new System.Drawing.Size(150, 19);
            this.cbDisponibleA.TabIndex = 12;
            this.cbDisponibleA.Text = "Disponible para alquilar";
            this.cbDisponibleA.UseVisualStyleBackColor = true;
            // 
            // cbDisponibleC
            // 
            this.cbDisponibleC.AutoSize = true;
            this.cbDisponibleC.Location = new System.Drawing.Point(12, 155);
            this.cbDisponibleC.Name = "cbDisponibleC";
            this.cbDisponibleC.Size = new System.Drawing.Size(156, 19);
            this.cbDisponibleC.TabIndex = 11;
            this.cbDisponibleC.Text = "Disponible para comprar";
            this.cbDisponibleC.UseVisualStyleBackColor = true;
            // 
            // cbAlquilada
            // 
            this.cbAlquilada.AutoSize = true;
            this.cbAlquilada.Location = new System.Drawing.Point(13, 127);
            this.cbAlquilada.Name = "cbAlquilada";
            this.cbAlquilada.Size = new System.Drawing.Size(76, 19);
            this.cbAlquilada.TabIndex = 10;
            this.cbAlquilada.Text = "Alquilada";
            this.cbAlquilada.UseVisualStyleBackColor = true;
            // 
            // cbComprada
            // 
            this.cbComprada.AutoSize = true;
            this.cbComprada.Location = new System.Drawing.Point(94, 127);
            this.cbComprada.Name = "cbComprada";
            this.cbComprada.Size = new System.Drawing.Size(82, 19);
            this.cbComprada.TabIndex = 9;
            this.cbComprada.Text = "Comprada";
            this.cbComprada.UseVisualStyleBackColor = true;
            // 
            // tbNombreP
            // 
            this.tbNombreP.Location = new System.Drawing.Point(12, 37);
            this.tbNombreP.Name = "tbNombreP";
            this.tbNombreP.Size = new System.Drawing.Size(164, 23);
            this.tbNombreP.TabIndex = 8;
            // 
            // btnAP
            // 
            this.btnAP.Location = new System.Drawing.Point(44, 222);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(75, 23);
            this.btnAP.TabIndex = 0;
            this.btnAP.Text = "Agregar";
            this.btnAP.UseVisualStyleBackColor = true;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // Superficies
            // 
            this.Superficies.Controls.Add(this.btnCalcular);
            this.Superficies.Controls.Add(this.tbAreaTotal);
            this.Superficies.Controls.Add(this.label5);
            this.Superficies.Controls.Add(this.dgvSuperficie);
            this.Superficies.Location = new System.Drawing.Point(4, 24);
            this.Superficies.Name = "Superficies";
            this.Superficies.Padding = new System.Windows.Forms.Padding(3);
            this.Superficies.Size = new System.Drawing.Size(386, 263);
            this.Superficies.TabIndex = 2;
            this.Superficies.Text = "Superficies";
            this.Superficies.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(302, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(78, 25);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbAreaTotal
            // 
            this.tbAreaTotal.Enabled = false;
            this.tbAreaTotal.Location = new System.Drawing.Point(203, 234);
            this.tbAreaTotal.Name = "tbAreaTotal";
            this.tbAreaTotal.Size = new System.Drawing.Size(93, 23);
            this.tbAreaTotal.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area total:";
            // 
            // dgvSuperficie
            // 
            this.dgvSuperficie.AllowUserToAddRows = false;
            this.dgvSuperficie.AllowUserToDeleteRows = false;
            this.dgvSuperficie.AllowUserToResizeColumns = false;
            this.dgvSuperficie.AllowUserToResizeRows = false;
            this.dgvSuperficie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuperficie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.NombreH,
            this.NombreP,
            this.Areaa,
            this.Check});
            this.dgvSuperficie.Location = new System.Drawing.Point(3, 6);
            this.dgvSuperficie.Name = "dgvSuperficie";
            this.dgvSuperficie.RowHeadersVisible = false;
            this.dgvSuperficie.RowTemplate.Height = 25;
            this.dgvSuperficie.Size = new System.Drawing.Size(377, 222);
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
            // NombreH
            // 
            this.NombreH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreH.FillWeight = 120F;
            this.NombreH.HeaderText = "Nombre habitacion";
            this.NombreH.Name = "NombreH";
            this.NombreH.ReadOnly = true;
            // 
            // NombreP
            // 
            this.NombreP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreP.FillWeight = 120F;
            this.NombreP.HeaderText = "Nombre propiedad";
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            // 
            // Areaa
            // 
            this.Areaa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Areaa.FillWeight = 50F;
            this.Areaa.HeaderText = "Area";
            this.Areaa.Name = "Areaa";
            this.Areaa.ReadOnly = true;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Check.FillWeight = 40F;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 23;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 159.3909F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 305);
            this.Controls.Add(this.tc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de propiedades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc.ResumeLayout(false);
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).EndInit();
            this.Agregar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAreaH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Superficies.ResumeLayout(false);
            this.Superficies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperficie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage Busqueda;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbBDAlquiler;
        private System.Windows.Forms.CheckBox cbBDCompra;
        private System.Windows.Forms.CheckBox cbBAlquilada;
        private System.Windows.Forms.CheckBox cbBComprada;
        private System.Windows.Forms.TextBox tbNombreBP;
        private System.Windows.Forms.TabPage Agregar;
        private System.Windows.Forms.TabPage Superficies;
        private System.Windows.Forms.TextBox tbAreaTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSuperficie;
        private System.Windows.Forms.DataGridView dgvPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAH;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDirP;
        private System.Windows.Forms.CheckBox cbDisponibleA;
        private System.Windows.Forms.CheckBox cbDisponibleC;
        private System.Windows.Forms.CheckBox cbAlquilada;
        private System.Windows.Forms.CheckBox cbComprada;
        private System.Windows.Forms.TextBox tbNombreP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreH;
        private System.Windows.Forms.NumericUpDown nuAreaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Areaa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

