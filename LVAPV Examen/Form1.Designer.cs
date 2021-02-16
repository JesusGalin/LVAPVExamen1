namespace LVAPV_Examen
{
    partial class frmFormulario
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
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblTelefonoFijo = new System.Windows.Forms.Label();
            this.lblTelefonoMovil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.txtTelefonoMovil = new System.Windows.Forms.TextBox();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbTipoE = new System.Windows.Forms.RadioButton();
            this.rdpTipoN = new System.Windows.Forms.RadioButton();
            this.pctFotografía = new System.Windows.Forms.PictureBox();
            this.grpFotografia = new System.Windows.Forms.GroupBox();
            this.grpDatosCarrera = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.chcServicioSocialConcluido = new System.Windows.Forms.CheckBox();
            this.grpDocumentosEntregados = new System.Windows.Forms.GroupBox();
            this.chcSolicitudPracticasProfesionales = new System.Windows.Forms.CheckBox();
            this.chcCartaCompromiso = new System.Windows.Forms.CheckBox();
            this.chcCurriculumVitae = new System.Windows.Forms.CheckBox();
            this.chcEntrevistaCompetencias = new System.Windows.Forms.CheckBox();
            this.chcSeleccionDeEmpresas = new System.Windows.Forms.CheckBox();
            this.chcCartaDeAceptacion = new System.Windows.Forms.CheckBox();
            this.chcCartaLiberacion = new System.Windows.Forms.CheckBox();
            this.chcCartaPresentacion = new System.Windows.Forms.CheckBox();
            this.chcSeguroGastosMedicos = new System.Windows.Forms.CheckBox();
            this.grpDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.lstEmpresas = new System.Windows.Forms.ListBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.lblTelefonoMovilAsesor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefonoMovilAsesor = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.dttFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaTermino = new System.Windows.Forms.Label();
            this.dttFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.grpDatosPersonales.SuspendLayout();
            this.grbGenero.SuspendLayout();
            this.grpTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotografía)).BeginInit();
            this.grpFotografia.SuspendLayout();
            this.grpDatosCarrera.SuspendLayout();
            this.grpDocumentosEntregados.SuspendLayout();
            this.grpDatosEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Ingeniería en Software",
            "Ingeniería en Tecnologías de Información e Internet",
            "Ingeniería Industrial y Rentabilidad de Negocios",
            "Ingeniería en Mecatrónica"});
            this.cmbCarrera.Location = new System.Drawing.Point(128, 24);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(518, 24);
            this.cmbCarrera.TabIndex = 0;
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.txtTelefonoMovil);
            this.grpDatosPersonales.Controls.Add(this.txtTelefonoFijo);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblTelefonoMovil);
            this.grpDatosPersonales.Controls.Add(this.lblTelefonoFijo);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(411, 177);
            this.grpDatosPersonales.TabIndex = 1;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            this.grpDatosPersonales.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(6, 56);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(116, 17);
            this.lblApellidoPaterno.TabIndex = 3;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(6, 87);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(118, 17);
            this.lblApellidoMaterno.TabIndex = 4;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblTelefonoFijo
            // 
            this.lblTelefonoFijo.AutoSize = true;
            this.lblTelefonoFijo.Location = new System.Drawing.Point(6, 117);
            this.lblTelefonoFijo.Name = "lblTelefonoFijo";
            this.lblTelefonoFijo.Size = new System.Drawing.Size(94, 17);
            this.lblTelefonoFijo.TabIndex = 5;
            this.lblTelefonoFijo.Text = "Télefono Fijo;";
            // 
            // lblTelefonoMovil
            // 
            this.lblTelefonoMovil.AutoSize = true;
            this.lblTelefonoMovil.Location = new System.Drawing.Point(6, 145);
            this.lblTelefonoMovil.Name = "lblTelefonoMovil";
            this.lblTelefonoMovil.Size = new System.Drawing.Size(104, 17);
            this.lblTelefonoMovil.TabIndex = 6;
            this.lblTelefonoMovil.Text = "Télefono Móvil:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(128, 54);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(260, 22);
            this.txtApellidoPaterno.TabIndex = 8;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(128, 83);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(260, 22);
            this.txtApellidoMaterno.TabIndex = 9;
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Location = new System.Drawing.Point(128, 115);
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(260, 22);
            this.txtTelefonoFijo.TabIndex = 10;
            // 
            // txtTelefonoMovil
            // 
            this.txtTelefonoMovil.Location = new System.Drawing.Point(128, 143);
            this.txtTelefonoMovil.Name = "txtTelefonoMovil";
            this.txtTelefonoMovil.Size = new System.Drawing.Size(260, 22);
            this.txtTelefonoMovil.TabIndex = 11;
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.rdbFemenino);
            this.grbGenero.Controls.Add(this.rdbMasculino);
            this.grbGenero.Location = new System.Drawing.Point(436, 12);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(71, 84);
            this.grbGenero.TabIndex = 2;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 21);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(40, 21);
            this.rdbMasculino.TabIndex = 3;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "M";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 50);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(37, 21);
            this.rdbFemenino.TabIndex = 4;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "F";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdbTipoE);
            this.grpTipo.Controls.Add(this.rdpTipoN);
            this.grpTipo.Location = new System.Drawing.Point(436, 105);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(71, 84);
            this.grpTipo.TabIndex = 5;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rdbTipoE
            // 
            this.rdbTipoE.AutoSize = true;
            this.rdbTipoE.Location = new System.Drawing.Point(6, 50);
            this.rdbTipoE.Name = "rdbTipoE";
            this.rdbTipoE.Size = new System.Drawing.Size(38, 21);
            this.rdbTipoE.TabIndex = 4;
            this.rdbTipoE.TabStop = true;
            this.rdbTipoE.Text = "E";
            this.rdbTipoE.UseVisualStyleBackColor = true;
            // 
            // rdpTipoN
            // 
            this.rdpTipoN.AutoSize = true;
            this.rdpTipoN.Location = new System.Drawing.Point(6, 21);
            this.rdpTipoN.Name = "rdpTipoN";
            this.rdpTipoN.Size = new System.Drawing.Size(39, 21);
            this.rdpTipoN.TabIndex = 3;
            this.rdpTipoN.TabStop = true;
            this.rdpTipoN.Text = "N";
            this.rdpTipoN.UseVisualStyleBackColor = true;
            // 
            // pctFotografía
            // 
            this.pctFotografía.Image = global::LVAPV_Examen.Properties.Resources.SAVE_20200602_222624;
            this.pctFotografía.Location = new System.Drawing.Point(9, 19);
            this.pctFotografía.Name = "pctFotografía";
            this.pctFotografía.Size = new System.Drawing.Size(127, 150);
            this.pctFotografía.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotografía.TabIndex = 6;
            this.pctFotografía.TabStop = false;
            this.pctFotografía.Click += new System.EventHandler(this.pctFotografía_Click);
            // 
            // grpFotografia
            // 
            this.grpFotografia.Controls.Add(this.pctFotografía);
            this.grpFotografia.Location = new System.Drawing.Point(522, 13);
            this.grpFotografia.Name = "grpFotografia";
            this.grpFotografia.Size = new System.Drawing.Size(146, 176);
            this.grpFotografia.TabIndex = 7;
            this.grpFotografia.TabStop = false;
            this.grpFotografia.Text = "Fotografía";
            // 
            // grpDatosCarrera
            // 
            this.grpDatosCarrera.Controls.Add(this.chcServicioSocialConcluido);
            this.grpDatosCarrera.Controls.Add(this.txtPromedio);
            this.grpDatosCarrera.Controls.Add(this.cmbSemestre);
            this.grpDatosCarrera.Controls.Add(this.lblPromedio);
            this.grpDatosCarrera.Controls.Add(this.lblSemestre);
            this.grpDatosCarrera.Controls.Add(this.lblCarrera);
            this.grpDatosCarrera.Controls.Add(this.cmbCarrera);
            this.grpDatosCarrera.Location = new System.Drawing.Point(12, 195);
            this.grpDatosCarrera.Name = "grpDatosCarrera";
            this.grpDatosCarrera.Size = new System.Drawing.Size(656, 115);
            this.grpDatosCarrera.TabIndex = 8;
            this.grpDatosCarrera.TabStop = false;
            this.grpDatosCarrera.Text = "Datos Carrera";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(6, 29);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(60, 17);
            this.lblCarrera.TabIndex = 12;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(6, 58);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(72, 17);
            this.lblSemestre.TabIndex = 13;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(6, 86);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(72, 17);
            this.lblPromedio.TabIndex = 14;
            this.lblPromedio.Text = "Promedio:";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Items.AddRange(new object[] {
            "Sexto",
            "Septimo",
            "Octavo",
            "Noveno"});
            this.cmbSemestre.Location = new System.Drawing.Point(128, 54);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(518, 24);
            this.cmbSemestre.TabIndex = 15;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(128, 84);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(115, 22);
            this.txtPromedio.TabIndex = 12;
            // 
            // chcServicioSocialConcluido
            // 
            this.chcServicioSocialConcluido.AutoSize = true;
            this.chcServicioSocialConcluido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcServicioSocialConcluido.Location = new System.Drawing.Point(453, 87);
            this.chcServicioSocialConcluido.Name = "chcServicioSocialConcluido";
            this.chcServicioSocialConcluido.Size = new System.Drawing.Size(192, 21);
            this.chcServicioSocialConcluido.TabIndex = 9;
            this.chcServicioSocialConcluido.Text = "Servicio Social Concluido:";
            this.chcServicioSocialConcluido.UseVisualStyleBackColor = true;
            // 
            // grpDocumentosEntregados
            // 
            this.grpDocumentosEntregados.Controls.Add(this.chcCartaLiberacion);
            this.grpDocumentosEntregados.Controls.Add(this.chcCartaPresentacion);
            this.grpDocumentosEntregados.Controls.Add(this.chcSeguroGastosMedicos);
            this.grpDocumentosEntregados.Controls.Add(this.chcCartaDeAceptacion);
            this.grpDocumentosEntregados.Controls.Add(this.chcSeleccionDeEmpresas);
            this.grpDocumentosEntregados.Controls.Add(this.chcEntrevistaCompetencias);
            this.grpDocumentosEntregados.Controls.Add(this.chcCurriculumVitae);
            this.grpDocumentosEntregados.Controls.Add(this.chcCartaCompromiso);
            this.grpDocumentosEntregados.Controls.Add(this.chcSolicitudPracticasProfesionales);
            this.grpDocumentosEntregados.Location = new System.Drawing.Point(12, 317);
            this.grpDocumentosEntregados.Name = "grpDocumentosEntregados";
            this.grpDocumentosEntregados.Size = new System.Drawing.Size(654, 108);
            this.grpDocumentosEntregados.TabIndex = 9;
            this.grpDocumentosEntregados.TabStop = false;
            this.grpDocumentosEntregados.Text = "Documentos Entregados";
            this.grpDocumentosEntregados.Enter += new System.EventHandler(this.grpDocumentosEntregados_Enter);
            // 
            // chcSolicitudPracticasProfesionales
            // 
            this.chcSolicitudPracticasProfesionales.AutoSize = true;
            this.chcSolicitudPracticasProfesionales.Location = new System.Drawing.Point(9, 23);
            this.chcSolicitudPracticasProfesionales.Name = "chcSolicitudPracticasProfesionales";
            this.chcSolicitudPracticasProfesionales.Size = new System.Drawing.Size(235, 21);
            this.chcSolicitudPracticasProfesionales.TabIndex = 10;
            this.chcSolicitudPracticasProfesionales.Text = "Solicitud Prácticas Profesionales";
            this.chcSolicitudPracticasProfesionales.UseVisualStyleBackColor = true;
            // 
            // chcCartaCompromiso
            // 
            this.chcCartaCompromiso.AutoSize = true;
            this.chcCartaCompromiso.Location = new System.Drawing.Point(9, 50);
            this.chcCartaCompromiso.Name = "chcCartaCompromiso";
            this.chcCartaCompromiso.Size = new System.Drawing.Size(146, 21);
            this.chcCartaCompromiso.TabIndex = 11;
            this.chcCartaCompromiso.Text = "Carta Compromiso";
            this.chcCartaCompromiso.UseVisualStyleBackColor = true;
            // 
            // chcCurriculumVitae
            // 
            this.chcCurriculumVitae.AutoSize = true;
            this.chcCurriculumVitae.Location = new System.Drawing.Point(9, 77);
            this.chcCurriculumVitae.Name = "chcCurriculumVitae";
            this.chcCurriculumVitae.Size = new System.Drawing.Size(133, 21);
            this.chcCurriculumVitae.TabIndex = 12;
            this.chcCurriculumVitae.Text = "Currículum Vitae";
            this.chcCurriculumVitae.UseVisualStyleBackColor = true;
            // 
            // chcEntrevistaCompetencias
            // 
            this.chcEntrevistaCompetencias.AutoSize = true;
            this.chcEntrevistaCompetencias.Location = new System.Drawing.Point(242, 23);
            this.chcEntrevistaCompetencias.Name = "chcEntrevistaCompetencias";
            this.chcEntrevistaCompetencias.Size = new System.Drawing.Size(212, 21);
            this.chcEntrevistaCompetencias.TabIndex = 13;
            this.chcEntrevistaCompetencias.Text = "Entrevista Por Competencias";
            this.chcEntrevistaCompetencias.UseVisualStyleBackColor = true;
            // 
            // chcSeleccionDeEmpresas
            // 
            this.chcSeleccionDeEmpresas.AutoSize = true;
            this.chcSeleccionDeEmpresas.Location = new System.Drawing.Point(242, 50);
            this.chcSeleccionDeEmpresas.Name = "chcSeleccionDeEmpresas";
            this.chcSeleccionDeEmpresas.Size = new System.Drawing.Size(178, 21);
            this.chcSeleccionDeEmpresas.TabIndex = 14;
            this.chcSeleccionDeEmpresas.Text = "Selección de Empresas";
            this.chcSeleccionDeEmpresas.UseVisualStyleBackColor = true;
            // 
            // chcCartaDeAceptacion
            // 
            this.chcCartaDeAceptacion.AutoSize = true;
            this.chcCartaDeAceptacion.Location = new System.Drawing.Point(242, 77);
            this.chcCartaDeAceptacion.Name = "chcCartaDeAceptacion";
            this.chcCartaDeAceptacion.Size = new System.Drawing.Size(158, 21);
            this.chcCartaDeAceptacion.TabIndex = 15;
            this.chcCartaDeAceptacion.Text = "Carta de Aceptación";
            this.chcCartaDeAceptacion.UseVisualStyleBackColor = true;
            // 
            // chcCartaLiberacion
            // 
            this.chcCartaLiberacion.AutoSize = true;
            this.chcCartaLiberacion.Location = new System.Drawing.Point(460, 75);
            this.chcCartaLiberacion.Name = "chcCartaLiberacion";
            this.chcCartaLiberacion.Size = new System.Drawing.Size(154, 21);
            this.chcCartaLiberacion.TabIndex = 18;
            this.chcCartaLiberacion.Text = "Carta de Liberación";
            this.chcCartaLiberacion.UseVisualStyleBackColor = true;
            // 
            // chcCartaPresentacion
            // 
            this.chcCartaPresentacion.AutoSize = true;
            this.chcCartaPresentacion.Location = new System.Drawing.Point(460, 48);
            this.chcCartaPresentacion.Name = "chcCartaPresentacion";
            this.chcCartaPresentacion.Size = new System.Drawing.Size(151, 21);
            this.chcCartaPresentacion.TabIndex = 17;
            this.chcCartaPresentacion.Text = "Carta Presentación";
            this.chcCartaPresentacion.UseVisualStyleBackColor = true;
            // 
            // chcSeguroGastosMedicos
            // 
            this.chcSeguroGastosMedicos.AutoSize = true;
            this.chcSeguroGastosMedicos.Location = new System.Drawing.Point(460, 21);
            this.chcSeguroGastosMedicos.Name = "chcSeguroGastosMedicos";
            this.chcSeguroGastosMedicos.Size = new System.Drawing.Size(188, 21);
            this.chcSeguroGastosMedicos.TabIndex = 16;
            this.chcSeguroGastosMedicos.Text = "Seguros Gastos Médicos";
            this.chcSeguroGastosMedicos.UseVisualStyleBackColor = true;
            // 
            // grpDatosEmpresa
            // 
            this.grpDatosEmpresa.Controls.Add(this.dttFechaTermino);
            this.grpDatosEmpresa.Controls.Add(this.lblFechaTermino);
            this.grpDatosEmpresa.Controls.Add(this.lblFechaInicio);
            this.grpDatosEmpresa.Controls.Add(this.dttFechaInicio);
            this.grpDatosEmpresa.Controls.Add(this.txtAsesor);
            this.grpDatosEmpresa.Controls.Add(this.txtContacto);
            this.grpDatosEmpresa.Controls.Add(this.txtEmail);
            this.grpDatosEmpresa.Controls.Add(this.txtTelefonoMovilAsesor);
            this.grpDatosEmpresa.Controls.Add(this.lblEmail);
            this.grpDatosEmpresa.Controls.Add(this.lblTelefonoMovilAsesor);
            this.grpDatosEmpresa.Controls.Add(this.lblAsesor);
            this.grpDatosEmpresa.Controls.Add(this.lblContacto);
            this.grpDatosEmpresa.Controls.Add(this.lstEmpresas);
            this.grpDatosEmpresa.Location = new System.Drawing.Point(12, 432);
            this.grpDatosEmpresa.Name = "grpDatosEmpresa";
            this.grpDatosEmpresa.Size = new System.Drawing.Size(654, 196);
            this.grpDatosEmpresa.TabIndex = 10;
            this.grpDatosEmpresa.TabStop = false;
            this.grpDatosEmpresa.Text = "Datos Empresa";
            // 
            // lstEmpresas
            // 
            this.lstEmpresas.FormattingEnabled = true;
            this.lstEmpresas.ItemHeight = 16;
            this.lstEmpresas.Items.AddRange(new object[] {
            "Marvel",
            "BMW",
            "Aorus",
            "Monster",
            "Asus",
            "HP",
            "Microsoft",
            "Movistar",
            "Telcel",
            "Gigabyte",
            "Fanta",
            "Coca-Cola",
            "Pepsi"});
            this.lstEmpresas.Location = new System.Drawing.Point(9, 21);
            this.lstEmpresas.Name = "lstEmpresas";
            this.lstEmpresas.Size = new System.Drawing.Size(121, 164);
            this.lstEmpresas.TabIndex = 0;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(239, 21);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(68, 17);
            this.lblContacto.TabIndex = 12;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Location = new System.Drawing.Point(239, 50);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(56, 17);
            this.lblAsesor.TabIndex = 13;
            this.lblAsesor.Text = "Asesor:";
            // 
            // lblTelefonoMovilAsesor
            // 
            this.lblTelefonoMovilAsesor.AutoSize = true;
            this.lblTelefonoMovilAsesor.Location = new System.Drawing.Point(239, 106);
            this.lblTelefonoMovilAsesor.Name = "lblTelefonoMovilAsesor";
            this.lblTelefonoMovilAsesor.Size = new System.Drawing.Size(152, 17);
            this.lblTelefonoMovilAsesor.TabIndex = 14;
            this.lblTelefonoMovilAsesor.Text = "Teléfono Móvil Asesor:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(239, 79);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefonoMovilAsesor
            // 
            this.txtTelefonoMovilAsesor.Location = new System.Drawing.Point(394, 106);
            this.txtTelefonoMovilAsesor.Name = "txtTelefonoMovilAsesor";
            this.txtTelefonoMovilAsesor.Size = new System.Drawing.Size(251, 22);
            this.txtTelefonoMovilAsesor.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(394, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(394, 21);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(251, 22);
            this.txtContacto.TabIndex = 17;
            // 
            // txtAsesor
            // 
            this.txtAsesor.Location = new System.Drawing.Point(394, 48);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.Size = new System.Drawing.Size(251, 22);
            this.txtAsesor.TabIndex = 18;
            // 
            // dttFechaInicio
            // 
            this.dttFechaInicio.Location = new System.Drawing.Point(395, 137);
            this.dttFechaInicio.Name = "dttFechaInicio";
            this.dttFechaInicio.Size = new System.Drawing.Size(251, 22);
            this.dttFechaInicio.TabIndex = 19;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(301, 142);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.lblFechaInicio.TabIndex = 20;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaTermino
            // 
            this.lblFechaTermino.AutoSize = true;
            this.lblFechaTermino.Location = new System.Drawing.Point(285, 168);
            this.lblFechaTermino.Name = "lblFechaTermino";
            this.lblFechaTermino.Size = new System.Drawing.Size(107, 17);
            this.lblFechaTermino.TabIndex = 21;
            this.lblFechaTermino.Text = "Fecha Termino:";
            // 
            // dttFechaTermino
            // 
            this.dttFechaTermino.Location = new System.Drawing.Point(394, 168);
            this.dttFechaTermino.Name = "dttFechaTermino";
            this.dttFechaTermino.Size = new System.Drawing.Size(251, 22);
            this.dttFechaTermino.TabIndex = 22;
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 641);
            this.Controls.Add(this.grpDatosEmpresa);
            this.Controls.Add(this.grpDocumentosEntregados);
            this.Controls.Add(this.grpDatosCarrera);
            this.Controls.Add(this.grpFotografia);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "frmFormulario";
            this.Text = "Asignación Practica Profesional";
            this.Load += new System.EventHandler(this.frmFormulario_Load);
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotografía)).EndInit();
            this.grpFotografia.ResumeLayout(false);
            this.grpDatosCarrera.ResumeLayout(false);
            this.grpDatosCarrera.PerformLayout();
            this.grpDocumentosEntregados.ResumeLayout(false);
            this.grpDocumentosEntregados.PerformLayout();
            this.grpDatosEmpresa.ResumeLayout(false);
            this.grpDatosEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtTelefonoMovil;
        private System.Windows.Forms.TextBox txtTelefonoFijo;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefonoMovil;
        private System.Windows.Forms.Label lblTelefonoFijo;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbTipoE;
        private System.Windows.Forms.RadioButton rdpTipoN;
        private System.Windows.Forms.PictureBox pctFotografía;
        private System.Windows.Forms.GroupBox grpFotografia;
        private System.Windows.Forms.GroupBox grpDatosCarrera;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.CheckBox chcServicioSocialConcluido;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.GroupBox grpDocumentosEntregados;
        private System.Windows.Forms.CheckBox chcCartaLiberacion;
        private System.Windows.Forms.CheckBox chcCartaPresentacion;
        private System.Windows.Forms.CheckBox chcSeguroGastosMedicos;
        private System.Windows.Forms.CheckBox chcCartaDeAceptacion;
        private System.Windows.Forms.CheckBox chcSeleccionDeEmpresas;
        private System.Windows.Forms.CheckBox chcEntrevistaCompetencias;
        private System.Windows.Forms.CheckBox chcCurriculumVitae;
        private System.Windows.Forms.CheckBox chcCartaCompromiso;
        private System.Windows.Forms.CheckBox chcSolicitudPracticasProfesionales;
        private System.Windows.Forms.GroupBox grpDatosEmpresa;
        private System.Windows.Forms.ListBox lstEmpresas;
        private System.Windows.Forms.DateTimePicker dttFechaTermino;
        private System.Windows.Forms.Label lblFechaTermino;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dttFechaInicio;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefonoMovilAsesor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefonoMovilAsesor;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.Label lblContacto;
    }
}

