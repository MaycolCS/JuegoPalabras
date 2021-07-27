namespace ParcialJuego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTituloTexto = new System.Windows.Forms.Label();
            this.letraPistaCod = new System.Windows.Forms.ComboBox();
            this.letraPistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLetrasPistaCod = new ParcialJuego.DataSetLetrasPistaCod();
            this.lblLetraPistaCod = new System.Windows.Forms.Label();
            this.inputTexto = new System.Windows.Forms.TextBox();
            this.lblLetraPistaDec = new System.Windows.Forms.Label();
            this.lblTituloCodigosCifrados = new System.Windows.Forms.Label();
            this.lblTituloNombres = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.letraPistaDec = new System.Windows.Forms.ComboBox();
            this.letraPistaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLetrasPistaDec = new ParcialJuego.DataSetLetrasPistaDec();
            this.inputCodigos = new System.Windows.Forms.TextBox();
            this.lblTituloCodificador = new System.Windows.Forms.Label();
            this.lblTituloDecodificador = new System.Windows.Forms.Label();
            this.btnCleanFields = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCodificador = new System.Windows.Forms.Panel();
            this.tbCodigosCifrados = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelDecodificador = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.dropDownRonda = new System.Windows.Forms.ComboBox();
            this.lblTituloRonda = new System.Windows.Forms.Label();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.letraPistaTableAdapter = new ParcialJuego.DataSetLetrasPistaCodTableAdapters.LetraPistaTableAdapter();
            this.letraPistaTableAdapter1 = new ParcialJuego.DataSetLetrasPistaDecTableAdapters.LetraPistaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.letraPistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLetrasPistaCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letraPistaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLetrasPistaDec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCodificador.SuspendLayout();
            this.panelDecodificador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloTexto
            // 
            this.lblTituloTexto.AutoSize = true;
            this.lblTituloTexto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloTexto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTexto.Location = new System.Drawing.Point(17, 79);
            this.lblTituloTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloTexto.Name = "lblTituloTexto";
            this.lblTituloTexto.Size = new System.Drawing.Size(60, 18);
            this.lblTituloTexto.TabIndex = 0;
            this.lblTituloTexto.Text = "Texto";
            // 
            // letraPistaCod
            // 
            this.letraPistaCod.DataSource = this.letraPistaBindingSource;
            this.letraPistaCod.DisplayMember = "letra";
            this.letraPistaCod.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letraPistaCod.FormattingEnabled = true;
            this.letraPistaCod.Location = new System.Drawing.Point(133, 145);
            this.letraPistaCod.Margin = new System.Windows.Forms.Padding(2);
            this.letraPistaCod.Name = "letraPistaCod";
            this.letraPistaCod.Size = new System.Drawing.Size(53, 25);
            this.letraPistaCod.TabIndex = 1;
            this.letraPistaCod.ValueMember = "codigo";
            // 
            // letraPistaBindingSource
            // 
            this.letraPistaBindingSource.DataMember = "LetraPista";
            this.letraPistaBindingSource.DataSource = this.dataSetLetrasPistaCod;
            // 
            // dataSetLetrasPistaCod
            // 
            this.dataSetLetrasPistaCod.DataSetName = "DataSetLetrasPistaCod";
            this.dataSetLetrasPistaCod.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLetraPistaCod
            // 
            this.lblLetraPistaCod.AutoSize = true;
            this.lblLetraPistaCod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblLetraPistaCod.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraPistaCod.Location = new System.Drawing.Point(17, 144);
            this.lblLetraPistaCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLetraPistaCod.Name = "lblLetraPistaCod";
            this.lblLetraPistaCod.Size = new System.Drawing.Size(103, 18);
            this.lblLetraPistaCod.TabIndex = 2;
            this.lblLetraPistaCod.Text = "Letra Pista";
            // 
            // inputTexto
            // 
            this.inputTexto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTexto.Location = new System.Drawing.Point(103, 62);
            this.inputTexto.Margin = new System.Windows.Forms.Padding(2);
            this.inputTexto.Multiline = true;
            this.inputTexto.Name = "inputTexto";
            this.inputTexto.Size = new System.Drawing.Size(254, 56);
            this.inputTexto.TabIndex = 3;
            // 
            // lblLetraPistaDec
            // 
            this.lblLetraPistaDec.AutoSize = true;
            this.lblLetraPistaDec.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblLetraPistaDec.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraPistaDec.Location = new System.Drawing.Point(14, 203);
            this.lblLetraPistaDec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLetraPistaDec.Name = "lblLetraPistaDec";
            this.lblLetraPistaDec.Size = new System.Drawing.Size(103, 18);
            this.lblLetraPistaDec.TabIndex = 6;
            this.lblLetraPistaDec.Text = "Letra Pista";
            // 
            // lblTituloCodigosCifrados
            // 
            this.lblTituloCodigosCifrados.AutoSize = true;
            this.lblTituloCodigosCifrados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloCodigosCifrados.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCodigosCifrados.Location = new System.Drawing.Point(14, 55);
            this.lblTituloCodigosCifrados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloCodigosCifrados.Name = "lblTituloCodigosCifrados";
            this.lblTituloCodigosCifrados.Size = new System.Drawing.Size(155, 18);
            this.lblTituloCodigosCifrados.TabIndex = 4;
            this.lblTituloCodigosCifrados.Text = "Codigos Cifrados";
            // 
            // lblTituloNombres
            // 
            this.lblTituloNombres.AutoSize = true;
            this.lblTituloNombres.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombres.Location = new System.Drawing.Point(542, 31);
            this.lblTituloNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloNombres.Name = "lblTituloNombres";
            this.lblTituloNombres.Size = new System.Drawing.Size(279, 38);
            this.lblTituloNombres.TabIndex = 8;
            this.lblTituloNombres.Text = "Maycol Andres Canastero Soler\r\nLucas Alejandro Patiño Dorado";
            // 
            // btnCifrar
            // 
            this.btnCifrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCifrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCifrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCifrar.Location = new System.Drawing.Point(212, 140);
            this.btnCifrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(144, 31);
            this.btnCifrar.TabIndex = 9;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = false;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // letraPistaDec
            // 
            this.letraPistaDec.DataSource = this.letraPistaBindingSource1;
            this.letraPistaDec.DisplayMember = "letra";
            this.letraPistaDec.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letraPistaDec.FormattingEnabled = true;
            this.letraPistaDec.Location = new System.Drawing.Point(129, 203);
            this.letraPistaDec.Margin = new System.Windows.Forms.Padding(2);
            this.letraPistaDec.Name = "letraPistaDec";
            this.letraPistaDec.Size = new System.Drawing.Size(53, 25);
            this.letraPistaDec.TabIndex = 10;
            this.letraPistaDec.ValueMember = "codigo";
            // 
            // letraPistaBindingSource1
            // 
            this.letraPistaBindingSource1.DataMember = "LetraPista";
            this.letraPistaBindingSource1.DataSource = this.dataSetLetrasPistaDec;
            // 
            // dataSetLetrasPistaDec
            // 
            this.dataSetLetrasPistaDec.DataSetName = "DataSetLetrasPistaDec";
            this.dataSetLetrasPistaDec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputCodigos
            // 
            this.inputCodigos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCodigos.Location = new System.Drawing.Point(18, 92);
            this.inputCodigos.Margin = new System.Windows.Forms.Padding(2);
            this.inputCodigos.Multiline = true;
            this.inputCodigos.Name = "inputCodigos";
            this.inputCodigos.Size = new System.Drawing.Size(348, 82);
            this.inputCodigos.TabIndex = 11;
            // 
            // lblTituloCodificador
            // 
            this.lblTituloCodificador.AutoSize = true;
            this.lblTituloCodificador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloCodificador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCodificador.Location = new System.Drawing.Point(119, 12);
            this.lblTituloCodificador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloCodificador.Name = "lblTituloCodificador";
            this.lblTituloCodificador.Size = new System.Drawing.Size(137, 18);
            this.lblTituloCodificador.TabIndex = 12;
            this.lblTituloCodificador.Text = "CODIFICADOR";
            // 
            // lblTituloDecodificador
            // 
            this.lblTituloDecodificador.AutoSize = true;
            this.lblTituloDecodificador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloDecodificador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDecodificador.Location = new System.Drawing.Point(122, 12);
            this.lblTituloDecodificador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloDecodificador.Name = "lblTituloDecodificador";
            this.lblTituloDecodificador.Size = new System.Drawing.Size(161, 18);
            this.lblTituloDecodificador.TabIndex = 13;
            this.lblTituloDecodificador.Text = "DECODIFICADOR";
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.BackColor = System.Drawing.Color.Gold;
            this.btnCleanFields.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanFields.Location = new System.Drawing.Point(161, 10);
            this.btnCleanFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(136, 34);
            this.btnCleanFields.TabIndex = 16;
            this.btnCleanFields.Text = "Limpiar Campos";
            this.btnCleanFields.UseVisualStyleBackColor = false;
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panelCodificador
            // 
            this.panelCodificador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCodificador.Controls.Add(this.tbCodigosCifrados);
            this.panelCodificador.Controls.Add(this.btnCifrar);
            this.panelCodificador.Controls.Add(this.lblTituloTexto);
            this.panelCodificador.Controls.Add(this.inputTexto);
            this.panelCodificador.Controls.Add(this.letraPistaCod);
            this.panelCodificador.Controls.Add(this.lblTituloCodificador);
            this.panelCodificador.Controls.Add(this.lblLetraPistaCod);
            this.panelCodificador.Location = new System.Drawing.Point(12, 170);
            this.panelCodificador.Margin = new System.Windows.Forms.Padding(2);
            this.panelCodificador.Name = "panelCodificador";
            this.panelCodificador.Size = new System.Drawing.Size(380, 319);
            this.panelCodificador.TabIndex = 18;
            // 
            // tbCodigosCifrados
            // 
            this.tbCodigosCifrados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCodigosCifrados.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigosCifrados.Location = new System.Drawing.Point(21, 197);
            this.tbCodigosCifrados.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigosCifrados.Multiline = true;
            this.tbCodigosCifrados.Name = "tbCodigosCifrados";
            this.tbCodigosCifrados.ReadOnly = true;
            this.tbCodigosCifrados.Size = new System.Drawing.Size(336, 106);
            this.tbCodigosCifrados.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(161, 54);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 34);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelDecodificador
            // 
            this.panelDecodificador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDecodificador.Controls.Add(this.btnBuscar);
            this.panelDecodificador.Controls.Add(this.btnDescifrar);
            this.panelDecodificador.Controls.Add(this.tbTexto);
            this.panelDecodificador.Controls.Add(this.letraPistaDec);
            this.panelDecodificador.Controls.Add(this.lblLetraPistaDec);
            this.panelDecodificador.Controls.Add(this.lblTituloDecodificador);
            this.panelDecodificador.Controls.Add(this.inputCodigos);
            this.panelDecodificador.Controls.Add(this.lblTituloCodigosCifrados);
            this.panelDecodificador.Location = new System.Drawing.Point(419, 170);
            this.panelDecodificador.Margin = new System.Windows.Forms.Padding(2);
            this.panelDecodificador.Name = "panelDecodificador";
            this.panelDecodificador.Size = new System.Drawing.Size(384, 319);
            this.panelDecodificador.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(336, 51);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 31);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "🔎";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDescifrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescifrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDescifrar.Location = new System.Drawing.Point(220, 198);
            this.btnDescifrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(144, 31);
            this.btnDescifrar.TabIndex = 14;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = false;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // tbTexto
            // 
            this.tbTexto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTexto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTexto.Location = new System.Drawing.Point(18, 243);
            this.tbTexto.Margin = new System.Windows.Forms.Padding(2);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.ReadOnly = true;
            this.tbTexto.Size = new System.Drawing.Size(348, 58);
            this.tbTexto.TabIndex = 14;
            // 
            // dropDownRonda
            // 
            this.dropDownRonda.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownRonda.FormattingEnabled = true;
            this.dropDownRonda.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.dropDownRonda.Location = new System.Drawing.Point(87, 15);
            this.dropDownRonda.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownRonda.Name = "dropDownRonda";
            this.dropDownRonda.Size = new System.Drawing.Size(53, 25);
            this.dropDownRonda.TabIndex = 14;
            // 
            // lblTituloRonda
            // 
            this.lblTituloRonda.AutoSize = true;
            this.lblTituloRonda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloRonda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRonda.Location = new System.Drawing.Point(11, 15);
            this.lblTituloRonda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloRonda.Name = "lblTituloRonda";
            this.lblTituloRonda.Size = new System.Drawing.Size(65, 18);
            this.lblTituloRonda.TabIndex = 15;
            this.lblTituloRonda.Text = "Ronda";
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(153, 15);
            this.lblTituloCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(94, 18);
            this.lblTituloCategoria.TabIndex = 16;
            this.lblTituloCategoria.Text = "Categoria";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblTituloRonda);
            this.panel1.Controls.Add(this.lblTituloCategoria);
            this.panel1.Controls.Add(this.dropDownRonda);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 52);
            this.panel1.TabIndex = 19;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCategoria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(247, 15);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(26, 18);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "...";
            // 
            // letraPistaTableAdapter
            // 
            this.letraPistaTableAdapter.ClearBeforeFill = true;
            // 
            // letraPistaTableAdapter1
            // 
            this.letraPistaTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(828, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCleanFields);
            this.Controls.Add(this.lblTituloNombres);
            this.Controls.Add(this.panelCodificador);
            this.Controls.Add(this.panelDecodificador);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.letraPistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLetrasPistaCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letraPistaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLetrasPistaDec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCodificador.ResumeLayout(false);
            this.panelCodificador.PerformLayout();
            this.panelDecodificador.ResumeLayout(false);
            this.panelDecodificador.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTexto;
        private System.Windows.Forms.ComboBox letraPistaCod;
        private System.Windows.Forms.Label lblLetraPistaCod;
        private System.Windows.Forms.TextBox inputTexto;
        private System.Windows.Forms.Label lblLetraPistaDec;
        private System.Windows.Forms.Label lblTituloCodigosCifrados;
        private System.Windows.Forms.Label lblTituloNombres;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.ComboBox letraPistaDec;
        private System.Windows.Forms.TextBox inputCodigos;
        private System.Windows.Forms.Label lblTituloCodificador;
        private System.Windows.Forms.Label lblTituloDecodificador;
        private System.Windows.Forms.Button btnCleanFields;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCodificador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelDecodificador;
        private System.Windows.Forms.TextBox tbCodigosCifrados;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.ComboBox dropDownRonda;
        private System.Windows.Forms.Label lblTituloRonda;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategoria;
        private DataSetLetrasPistaCod dataSetLetrasPistaCod;
        private System.Windows.Forms.BindingSource letraPistaBindingSource;
        private DataSetLetrasPistaCodTableAdapters.LetraPistaTableAdapter letraPistaTableAdapter;
        private DataSetLetrasPistaDec dataSetLetrasPistaDec;
        private System.Windows.Forms.BindingSource letraPistaBindingSource1;
        private DataSetLetrasPistaDecTableAdapters.LetraPistaTableAdapter letraPistaTableAdapter1;
        private System.Windows.Forms.Button btnBuscar;
    }
}

