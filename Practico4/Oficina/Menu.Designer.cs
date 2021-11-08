
namespace Oficina
{
    partial class Menu
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
            this.tc1 = new System.Windows.Forms.TabControl();
            this.Inicio = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPuntosP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realizada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRealizarTarea = new System.Windows.Forms.Button();
            this.Tienda = new System.Windows.Forms.TabPage();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.dgvTienda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPuntos = new System.Windows.Forms.TextBox();
            this.Inventario = new System.Windows.Forms.TabPage();
            this.lblSel = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.Objetos = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nuT = new System.Windows.Forms.NumericUpDown();
            this.bgnAgregarT = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNombreT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuO = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarO = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAñadido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreO = new System.Windows.Forms.TextBox();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvContador = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sbTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tc1.SuspendLayout();
            this.Inicio.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.Tienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).BeginInit();
            this.Inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.Objetos.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuT)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuO)).BeginInit();
            this.Usuarios.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContador)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc1
            // 
            this.tc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc1.Controls.Add(this.Inicio);
            this.tc1.Controls.Add(this.Tienda);
            this.tc1.Controls.Add(this.Inventario);
            this.tc1.Controls.Add(this.Objetos);
            this.tc1.Controls.Add(this.Usuarios);
            this.tc1.Location = new System.Drawing.Point(12, 12);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(292, 384);
            this.tc1.TabIndex = 0;
            this.tc1.SelectedIndexChanged += new System.EventHandler(this.tc1_SelectedIndexChanged);
            // 
            // Inicio
            // 
            this.Inicio.Controls.Add(this.groupBox3);
            this.Inicio.Controls.Add(this.groupBox2);
            this.Inicio.Location = new System.Drawing.Point(4, 24);
            this.Inicio.Name = "Inicio";
            this.Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.Inicio.Size = new System.Drawing.Size(284, 356);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbPuntosP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbNombreP);
            this.groupBox3.Location = new System.Drawing.Point(11, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 109);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puntos";
            // 
            // tbPuntosP
            // 
            this.tbPuntosP.Enabled = false;
            this.tbPuntosP.Location = new System.Drawing.Point(73, 69);
            this.tbPuntosP.Name = "tbPuntosP";
            this.tbPuntosP.Size = new System.Drawing.Size(154, 23);
            this.tbPuntosP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // tbNombreP
            // 
            this.tbNombreP.Enabled = false;
            this.tbNombreP.Location = new System.Drawing.Point(73, 22);
            this.tbNombreP.Name = "tbNombreP";
            this.tbNombreP.Size = new System.Drawing.Size(154, 23);
            this.tbNombreP.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgvTareas);
            this.groupBox2.Controls.Add(this.btnRealizarTarea);
            this.groupBox2.Location = new System.Drawing.Point(6, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tareas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nombre,
            this.Puntos,
            this.Realizada});
            this.dgvTareas.Location = new System.Drawing.Point(11, 22);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.RowTemplate.Height = 25;
            this.dgvTareas.Size = new System.Drawing.Size(255, 164);
            this.dgvTareas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Puntos
            // 
            this.Puntos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            // 
            // Realizada
            // 
            this.Realizada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Realizada.HeaderText = "";
            this.Realizada.Name = "Realizada";
            // 
            // btnRealizarTarea
            // 
            this.btnRealizarTarea.Location = new System.Drawing.Point(191, 192);
            this.btnRealizarTarea.Name = "btnRealizarTarea";
            this.btnRealizarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnRealizarTarea.TabIndex = 3;
            this.btnRealizarTarea.Text = "Realizar";
            this.btnRealizarTarea.UseVisualStyleBackColor = true;
            this.btnRealizarTarea.Click += new System.EventHandler(this.btnRealizarTarea_Click);
            // 
            // Tienda
            // 
            this.Tienda.Controls.Add(this.btnCanjear);
            this.Tienda.Controls.Add(this.dgvTienda);
            this.Tienda.Controls.Add(this.label1);
            this.Tienda.Controls.Add(this.tbPuntos);
            this.Tienda.Location = new System.Drawing.Point(4, 24);
            this.Tienda.Name = "Tienda";
            this.Tienda.Padding = new System.Windows.Forms.Padding(3);
            this.Tienda.Size = new System.Drawing.Size(284, 356);
            this.Tienda.TabIndex = 1;
            this.Tienda.Text = "Tienda";
            this.Tienda.UseVisualStyleBackColor = true;
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(203, 324);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(75, 23);
            this.btnCanjear.TabIndex = 3;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // dgvTienda
            // 
            this.dgvTienda.AllowUserToAddRows = false;
            this.dgvTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn5,
            this.Costo,
            this.AddBy,
            this.Check});
            this.dgvTienda.EnableHeadersVisualStyles = false;
            this.dgvTienda.Location = new System.Drawing.Point(6, 6);
            this.dgvTienda.Name = "dgvTienda";
            this.dgvTienda.RowHeadersVisible = false;
            this.dgvTienda.RowTemplate.Height = 25;
            this.dgvTienda.Size = new System.Drawing.Size(272, 313);
            this.dgvTienda.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 111.9289F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Costo.FillWeight = 111.9289F;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // AddBy
            // 
            this.AddBy.HeaderText = "Agregado por";
            this.AddBy.Name = "AddBy";
            this.AddBy.ReadOnly = true;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Check.FillWeight = 76.14214F;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntos";
            // 
            // tbPuntos
            // 
            this.tbPuntos.Enabled = false;
            this.tbPuntos.Location = new System.Drawing.Point(56, 325);
            this.tbPuntos.Name = "tbPuntos";
            this.tbPuntos.Size = new System.Drawing.Size(141, 23);
            this.tbPuntos.TabIndex = 0;
            // 
            // Inventario
            // 
            this.Inventario.Controls.Add(this.lblSel);
            this.Inventario.Controls.Add(this.cbUsuario);
            this.Inventario.Controls.Add(this.dgvInventario);
            this.Inventario.Controls.Add(this.btnConsumir);
            this.Inventario.Location = new System.Drawing.Point(4, 24);
            this.Inventario.Name = "Inventario";
            this.Inventario.Padding = new System.Windows.Forms.Padding(3);
            this.Inventario.Size = new System.Drawing.Size(284, 356);
            this.Inventario.TabIndex = 2;
            this.Inventario.Text = "Inventario";
            this.Inventario.UseVisualStyleBackColor = true;
            // 
            // lblSel
            // 
            this.lblSel.AutoSize = true;
            this.lblSel.Location = new System.Drawing.Point(6, 330);
            this.lblSel.Name = "lblSel";
            this.lblSel.Size = new System.Drawing.Size(50, 15);
            this.lblSel.TabIndex = 5;
            this.lblSel.Text = "Usuario:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(62, 327);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(128, 23);
            this.cbUsuario.TabIndex = 4;
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.cbUsuario_SelectedIndexChanged);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.Location = new System.Drawing.Point(6, 6);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.Size = new System.Drawing.Size(272, 313);
            this.dgvInventario.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.FillWeight = 140.3373F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.FillWeight = 47.73378F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // btnConsumir
            // 
            this.btnConsumir.Location = new System.Drawing.Point(203, 326);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(75, 23);
            this.btnConsumir.TabIndex = 1;
            this.btnConsumir.Text = "Consumir";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // Objetos
            // 
            this.Objetos.Controls.Add(this.groupBox6);
            this.Objetos.Controls.Add(this.groupBox1);
            this.Objetos.Location = new System.Drawing.Point(4, 24);
            this.Objetos.Name = "Objetos";
            this.Objetos.Size = new System.Drawing.Size(284, 356);
            this.Objetos.TabIndex = 4;
            this.Objetos.Text = "Objetos";
            this.Objetos.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nuT);
            this.groupBox6.Controls.Add(this.bgnAgregarT);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.tbNombreT);
            this.groupBox6.Location = new System.Drawing.Point(7, 193);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 160);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Añadir tareas";
            // 
            // nuT
            // 
            this.nuT.Location = new System.Drawing.Point(103, 64);
            this.nuT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuT.Name = "nuT";
            this.nuT.Size = new System.Drawing.Size(157, 23);
            this.nuT.TabIndex = 19;
            // 
            // bgnAgregarT
            // 
            this.bgnAgregarT.Location = new System.Drawing.Point(185, 120);
            this.bgnAgregarT.Name = "bgnAgregarT";
            this.bgnAgregarT.Size = new System.Drawing.Size(75, 23);
            this.bgnAgregarT.TabIndex = 16;
            this.bgnAgregarT.Text = "Agregar";
            this.bgnAgregarT.UseVisualStyleBackColor = true;
            this.bgnAgregarT.Click += new System.EventHandler(this.bgnAgregarT_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Puntos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Nombre";
            // 
            // tbNombreT
            // 
            this.tbNombreT.Location = new System.Drawing.Point(103, 22);
            this.tbNombreT.Name = "tbNombreT";
            this.tbNombreT.Size = new System.Drawing.Size(157, 23);
            this.tbNombreT.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuO);
            this.groupBox1.Controls.Add(this.btnAgregarO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbAñadido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNombreO);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir objeto";
            // 
            // nuO
            // 
            this.nuO.Location = new System.Drawing.Point(106, 110);
            this.nuO.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuO.Name = "nuO";
            this.nuO.Size = new System.Drawing.Size(154, 23);
            this.nuO.TabIndex = 19;
            // 
            // btnAgregarO
            // 
            this.btnAgregarO.Location = new System.Drawing.Point(185, 149);
            this.btnAgregarO.Name = "btnAgregarO";
            this.btnAgregarO.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarO.TabIndex = 16;
            this.btnAgregarO.Text = "Agregar";
            this.btnAgregarO.UseVisualStyleBackColor = true;
            this.btnAgregarO.Click += new System.EventHandler(this.btnAgregarO_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Añadido por:";
            // 
            // tbAñadido
            // 
            this.tbAñadido.Enabled = false;
            this.tbAñadido.Location = new System.Drawing.Point(106, 31);
            this.tbAñadido.Name = "tbAñadido";
            this.tbAñadido.Size = new System.Drawing.Size(154, 23);
            this.tbAñadido.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Puntos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // tbNombreO
            // 
            this.tbNombreO.Location = new System.Drawing.Point(106, 69);
            this.tbNombreO.Name = "tbNombreO";
            this.tbNombreO.Size = new System.Drawing.Size(154, 23);
            this.tbNombreO.TabIndex = 10;
            // 
            // Usuarios
            // 
            this.Usuarios.Controls.Add(this.groupBox5);
            this.Usuarios.Controls.Add(this.groupBox4);
            this.Usuarios.Location = new System.Drawing.Point(4, 24);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(284, 356);
            this.Usuarios.TabIndex = 3;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvContador);
            this.groupBox5.Location = new System.Drawing.Point(3, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 160);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contador global";
            // 
            // dgvContador
            // 
            this.dgvContador.AllowUserToAddRows = false;
            this.dgvContador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvContador.Location = new System.Drawing.Point(11, 22);
            this.dgvContador.Name = "dgvContador";
            this.dgvContador.RowHeadersVisible = false;
            this.dgvContador.RowTemplate.Height = 25;
            this.dgvContador.Size = new System.Drawing.Size(255, 132);
            this.dgvContador.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Puntaje";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAgregarU);
            this.groupBox4.Controls.Add(this.tbNombre);
            this.groupBox4.Controls.Add(this.tbCedula);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbContraseña);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.sbTipo);
            this.groupBox4.Location = new System.Drawing.Point(3, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 177);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Añadir usuario";
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.Location = new System.Drawing.Point(191, 148);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarU.TabIndex = 8;
            this.btnAgregarU.Text = "Agregar";
            this.btnAgregarU.UseVisualStyleBackColor = true;
            this.btnAgregarU.Click += new System.EventHandler(this.btnAgregarU_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(111, 23);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(155, 23);
            this.tbNombre.TabIndex = 7;
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(111, 50);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(155, 23);
            this.tbCedula.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cedula";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(111, 81);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(155, 23);
            this.tbContraseña.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre";
            // 
            // sbTipo
            // 
            this.sbTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Usuario",
            "Coordinador",
            "Administrador"});
            this.sbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbTipo.FormattingEnabled = true;
            this.sbTipo.Items.AddRange(new object[] {
            "Usuario",
            "Coordinador",
            "Administrador"});
            this.sbTipo.Location = new System.Drawing.Point(111, 114);
            this.sbTipo.Name = "sbTipo";
            this.sbTipo.Size = new System.Drawing.Size(155, 23);
            this.sbTipo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(70, 404);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 15);
            this.lblEstado.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 431);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tc1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tc1.ResumeLayout(false);
            this.Inicio.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.Tienda.ResumeLayout(false);
            this.Tienda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).EndInit();
            this.Inventario.ResumeLayout(false);
            this.Inventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.Objetos.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuO)).EndInit();
            this.Usuarios.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContador)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage Inicio;
        private System.Windows.Forms.Button btnRealizarTarea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.TabPage Tienda;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.DataGridView dgvTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPuntos;
        private System.Windows.Forms.TabPage Inventario;
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPuntosP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreP;
        private System.Windows.Forms.TabPage Objetos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvContador;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreO;
        private System.Windows.Forms.Button btnAgregarO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAñadido;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnAgregarU;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sbTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.NumericUpDown nuO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nuT;
        private System.Windows.Forms.Button bgnAgregarT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNombreT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Realizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddBy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSel;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}