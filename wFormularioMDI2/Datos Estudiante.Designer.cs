namespace wFormularioMDI2
{
    partial class frmDatosEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosEstudiante));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNumDocumento = new System.Windows.Forms.Label();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarToolStripMenuItem1,
            this.guardarMenu});
            this.opcionesToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // limpiarToolStripMenuItem1
            // 
            this.limpiarToolStripMenuItem1.Name = "limpiarToolStripMenuItem1";
            this.limpiarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.limpiarToolStripMenuItem1.Text = "&Limpiar";
            this.limpiarToolStripMenuItem1.Click += new System.EventHandler(this.limpiarToolStripMenuItem1_Click);
            // 
            // guardarMenu
            // 
            this.guardarMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarMenu.MergeIndex = 1;
            this.guardarMenu.Name = "guardarMenu";
            this.guardarMenu.Size = new System.Drawing.Size(224, 26);
            this.guardarMenu.Text = "&Guardar";
            this.guardarMenu.Click += new System.EventHandler(this.guardarMenu_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(14, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(14, 98);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 25);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(256, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 28);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(256, 98);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 28);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // cboDocumento
            // 
            this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PAS",
            "CE",
            "TE"});
            this.cboDocumento.Location = new System.Drawing.Point(256, 151);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(161, 30);
            this.cboDocumento.TabIndex = 5;
            this.cboDocumento.SelectedIndexChanged += new System.EventHandler(this.cboDocumento_SelectedIndexChanged);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.White;
            this.lblDocumento.Location = new System.Drawing.Point(14, 151);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(186, 25);
            this.lblDocumento.TabIndex = 6;
            this.lblDocumento.Text = "Tipo De Documento";
            // 
            // lblNumDocumento
            // 
            this.lblNumDocumento.AutoSize = true;
            this.lblNumDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDocumento.ForeColor = System.Drawing.Color.White;
            this.lblNumDocumento.Location = new System.Drawing.Point(14, 199);
            this.lblNumDocumento.Name = "lblNumDocumento";
            this.lblNumDocumento.Size = new System.Drawing.Size(186, 25);
            this.lblNumDocumento.TabIndex = 7;
            this.lblNumDocumento.Text = "Numero Documento";
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Location = new System.Drawing.Point(256, 203);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(161, 28);
            this.txtNumDocumento.TabIndex = 8;
            this.txtNumDocumento.TextChanged += new System.EventHandler(this.txtNumDocumento_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.cboCiudad);
            this.groupBox1.Controls.Add(this.lblCiudad);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.cboSexo);
            this.groupBox1.Controls.Add(this.txtNumDocumento);
            this.groupBox1.Controls.Add(this.lblNumDocumento);
            this.groupBox1.Controls.Add(this.lblDocumento);
            this.groupBox1.Controls.Add(this.cboDocumento);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 361);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Estudiante";
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Items.AddRange(new object[] {
            "Bogotá",
            "Medellín",
            "Cali",
            "Barranquilla",
            "Cartagena",
            "Soacha",
            "Palermo",
            "Cúcuta",
            "Soledad",
            "Pereira",
            "Bucaramanga",
            "Valledupar",
            "Ibagué",
            "Villavicencio",
            "Santa Marta",
            "Montería",
            "Manizales",
            "Buenaventura",
            "Pasto",
            "Bello",
            "Neiva",
            "Armenia",
            "Popayán",
            "Sincelejo",
            "Floridablanca",
            "Itagüí",
            "Envigado",
            "Tuluá",
            "Tumaco",
            "Barrancabermeja",
            "Tunja",
            "Zipaquirá",
            "Turbo",
            "Yopal",
            "Dosquebradas",
            "Ríohacha",
            "Girón",
            "Florencia",
            "Fusagasugá",
            "Cartago",
            "Pitalito",
            "Ciénaga",
            "Sogamoso",
            "Quibdó",
            "Girardot",
            "Duitama",
            "Magangué",
            "Maicao",
            "Uribia",
            "Piedecuesta",
            "Facatativá",
            "Guadalajara de Buga",
            "Madrid",
            "Santander de Quilichao",
            "Aguachica",
            "Ipiales",
            "Chía",
            "Jamundí",
            "Arauca",
            "Yumbo",
            "Mosquera",
            "Fundación",
            "Ocaña",
            "Montelíbano",
            "Chiquinquirá",
            "Sabanalarga",
            "Chigorodó",
            "Cereté",
            "Caldas",
            "Funza",
            "Los Patios",
            "Tierralta",
            "El Carmen de Bolívar",
            "La Dorada",
            "Arjona",
            "Turbaco",
            "Espinal",
            "Acacías",
            "Copacabana",
            "Santa Rosa de Cabal",
            "San Vicente del Caguán",
            "San Andrés",
            "Corozal",
            "Villa del Rosario",
            "Garzón",
            "Planeta Rica",
            "Necoclí",
            "San José del Guaviare",
            "Manaure",
            "Marinilla",
            "Ciénaga de Oro",
            "Puerto Asís",
            "Riosucio",
            "Plato",
            "Carepa",
            "Cajicá",
            "Villamaría",
            "San Marcos",
            "Girardota",
            "Florida",
            "Pamplona",
            "Pradera",
            "Orito",
            "Puerto Boyacá",
            "El Banco",
            "San Gil",
            "Sabaneta",
            "Valle del Guamuez",
            "Puerto Libertador",
            "Tame",
            "Barbosa",
            "Lorica",
            "San Onofre",
            "Guarne",
            "El Bagre",
            "Chinú",
            "Baranoa",
            "Puerto Berrío",
            "Cimitarra",
            "María la Baja",
            "Agustín Codazzi",
            "Samaniego",
            "Carmen de Viboral",
            "Yarumal",
            "La Vega",
            "Chaparral",
            "Andes",
            "San Andrés de Sotavento",
            "Ayapel",
            "Urrao",
            "Zarzal",
            "Valencia",
            "Roldanillo",
            "Puerto Tejada",
            "Santa Rosa del Sur",
            "San Pelayo",
            "Arboletes",
            "Villeta",
            "Aguazul",
            "Cumaribo",
            "Miranda",
            "El Charco",
            "Cáceres",
            "Montenegro",
            "Pueblo Nuevo",
            "Tuchín",
            "Arauquita",
            "Guaduas",
            "Pie de Pató",
            "Cumbal",
            "Aracataca",
            "La Unión",
            "Túquerres",
            "Acevedo",
            "Bosconia",
            "Líbano",
            "Villa de San Diego de Ubaté",
            "San Juan del Cesar",
            "Tarazá",
            "Cajibío",
            "Segovia",
            "Sibaté",
            "Sampués",
            "Dibulla",
            "El Bordo",
            "Santa Rosa de Osos",
            "Tibú",
            "Melgar",
            "Dagua",
            "La Macarena",
            "Belalcázar",
            "Sonsón",
            "San Pablo",
            "San Bernardo del Viento",
            "Santiago de Tolú",
            "Guacarí",
            "Timbío",
            "Gigante",
            "Cartagena del Chairá",
            "Tocancipá",
            "Yarumal",
            "Quimbaya",
            "Fonseca",
            "San Vicente de Chucurí",
            "Puerto López",
            "San Luis de Sincé",
            "Campoalegre",
            "Sabanagrande",
            "Caldono",
            "San Agustín",
            "San Juan Nepomuceno",
            "Majagual",
            "Quinchía",
            "Puerto Rico",
            "San Antero",
            "Corinto",
            "Pivijay",
            "Puebloviejo",
            "Bocas de Satinga",
            "Puerto Escondido",
            "Silvia",
            "El Difícil",
            "Inzá",
            "Leticia",
            "La Virginia",
            "San Pedro de Urabá",
            "Remedios",
            "Paipa",
            "Guachavés",
            "Sitionuevo",
            "Puerto Wilches",
            "Neira",
            "Guamo",
            "Circasia",
            "Amagá",
            "Chimichagua",
            "Planadas",
            "Fresno",
            "Purificación",
            "Tabio",
            "Barbosa",
            "Flandes",
            "Aipe",
            "Sopó",
            "Moñitos",
            "Riosucio",
            "La Dorada",
            "La Calera",
            "Caicedonia",
            "Hatonuevo",
            "San Carlos",
            "Isnos",
            "Coyaima",
            "Mitú",
            "Guamal",
            "Luruaco",
            "Belén de Umbría",
            "Argelia",
            "Supía",
            "Ciudad Bolívar",
            "Repelón",
            "San Juan de Urabá",
            "Puerto Colombia",
            "Fortul",
            "Morales",
            "Los Córdobas",
            "San Benito Abad",
            "San Alberto",
            "Balboa",
            "Pensilvania",
            "Paz de Ariporo",
            "Buesaco",
            "Istmina",
            "Santa Ana",
            "San Martín",
            "Palmar de Varela",
            "Nechí",
            "Yolombó",
            "Solano",
            "Vistahermosa",
            "San José",
            "La Unión",
            "Chocontá",
            "Sandoná",
            "Pinillos",
            "Socorro",
            "Tauramena",
            "Villanueva",
            "Algeciras",
            "Santa Rosa",
            "Pueblo Bello",
            "El Retorno",
            "Valdivia",
            "Puerto Guzmán",
            "La Montañita",
            "Donmatías",
            "Rioblanco",
            "Marsella",
            "Cogua",
            "El Zulia",
            "Honda",
            "El Paso",
            "Canalete",
            "Teorama",
            "San José",
            "Ponedera",
            "Alcalá",
            "Puerto Concordia",
            "Achí",
            "Curumaní",
            "Dabeiba",
            "Guadalupe",
            "Ataco",
            "Santa Fe de Antioquia",
            "Amalfi",
            "Buenavista",
            "Manzanares",
            "Sardinata",
            "Mutatá",
            "La Jagua de Ibirico",
            "Natagaima",
            "El Doncello",
            "El Colegio",
            "Pailitas",
            "Timbiquí",
            "Tiquisio",
            "Mocoa",
            "Silvania",
            "Taminango",
            "Ginebra",
            "Puerto Triunfo",
            "San Jacinto",
            "Nueva Granada",
            "Galeras",
            "Villagarzón",
            "San Bernardo",
            "El Paujíl",
            "Santa Bárbara",
            "Moniquirá",
            "Almaguer",
            "Totoró",
            "Aguadas",
            "Montecristo",
            "Suaza",
            "Villapinzón",
            "Fredonia",
            "El Retén",
            "Bugalagrande",
            "López",
            "Sotomayor",
            "Ovejas",
            "Samacá",
            "Timaná",
            "San Lorenzo",
            "Concordia",
            "Simití",
            "Tenjo",
            "Rovira",
            "Inírida",
            "Urumita",
            "Polonuevo",
            "La Unión",
            "Tadó",
            "Vélez",
            "Tocaima",
            "Villa de Leyva",
            "Campo de la Cruz",
            "Sabana de Torres",
            "Pelaya",
            "Salgar",
            "La Primavera",
            "Guaranda",
            "Suesca",
            "Betulia",
            "El Rosal",
            "Retiro",
            "Puerto Carreño",
            "El Piñón",
            "Anorí",
            "Aquitania",
            "Chivolo",
            "Guasca",
            "Landázuri",
            "Támesis",
            "Obando",
            "Condoto",
            "Sopetrán",
            "Tenerife",
            "Juan de Acosta",
            "Titiribí",
            "El Carmen de Atrato",
            "Río de Oro",
            "Córdoba",
            "Guapí",
            "Jardín",
            "Altos del Rosario",
            "Filandia",
            "Manatí",
            "San Jacinto del Cauca",
            "Rosas",
            "Anolaima",
            "Los Santos",
            "Santa Bárbara de Pinto",
            "Candelaria",
            "Saboyá",
            "Hatillo de Loba",
            "Córdoba",
            "Ebéjico",
            "Caimito",
            "Curití",
            "Oiba",
            "Santa Lucía",
            "Puente Nacional",
            "La Unión",
            "Cisneros",
            "Guayabal",
            "Talaigua Nuevo",
            "Coveñas",
            "Bojacá",
            "El Playón",
            "El Águila",
            "Agua de Dios",
            "El Tarra",
            "Mogotes",
            "Santo Domingo",
            "Tubará",
            "Regidor",
            "Lenguazaque",
            "Charalá",
            "Medina",
            "Granada",
            "Suaita",
            "Margarita",
            "Norosí",
            "Chita",
            "Pesca",
            "Granada",
            "Tibaná",
            "San Zenón",
            "Nuquí",
            "Alvarado",
            "Zapatoca",
            "Junín",
            "Iles",
            "La Belleza",
            "Usiacurí",
            "Muzo",
            "Orocué",
            "Guatapé",
            "San Francisco",
            "Aratoca",
            "Uramita",
            "Uribe",
            "Motavita",
            "Pedraza",
            "Puerto Parra",
            "San Luis de Palenque",
            "Paratebueno",
            "Santana",
            "Coromoro",
            "Ambalema",
            "Tarso",
            "Maripí",
            "Simacota",
            "Soatá",
            "Tona",
            "Socha",
            "Salento",
            "Boavita",
            "Guatavita",
            "Güicán",
            "Puerto Nariño",
            "Cubará",
            "Tasco",
            "Florián",
            "Heliconia",
            "Colosó",
            "Albán",
            "Sutamarchán",
            "Chitaraque",
            "Zipacón",
            "Chíquiza",
            "Villanueva",
            "Caramanta",
            "Tota",
            "Córdoba",
            "El Cocuy",
            "Arcabuco",
            "San José de Pare",
            "Labranzagrande",
            "Togüí",
            "Piojó",
            "El Peñón",
            "Chiscas",
            "Santa Rosalía",
            "El Espino",
            "Puerto Rondón",
            "Sáchica",
            "Güepsa",
            "San Mateo",
            "Guavatá",
            "Guayabal de Síquima",
            "Chinavita",
            "Concepción",
            "La Jagua del Pilar",
            "Cravo Norte",
            "Palmar",
            "Tipacoque",
            "Susacón",
            "Tinjacá",
            "Sora",
            "Covarachía",
            "Oicatá",
            "Guataquí",
            "Santa Sofía",
            "Jerusalén",
            "Gachantivá",
            "Briceño",
            "La Uvita",
            "Encino",
            "Vetas",
            "Juradó",
            "Iza",
            "Sativanorte",
            "Palmas del Socorro",
            "Almeida",
            "Guacamayas",
            "Galán",
            "Tutazá",
            "Cepitá",
            "San Eduardo",
            "Tununguá",
            "Pajarito",
            "La Victoria",
            "Panqueba",
            "Sativasur",
            "Mahates",
            "Barichara",
            "La Estrella",
            "Malambo",
            "Rionegro",
            "Galapa",
            "Cota",
            "La Tebaida",
            "Chinchiná",
            "Gachancipá",
            "La Ceja",
            "Santuario",
            "Calarcá",
            "Sesquilé",
            "Santo Tomás",
            "Nobsa",
            "Málaga",
            "Palmira",
            "Providencia",
            "Candelaria",
            "Apartadó",
            "Guateque",
            "Piendamó",
            "Sahagún",
            "Marmato",
            "Suan",
            "Santa Isabel",
            "La Mesa",
            "Villa Rica",
            "Puerto Santander",
            "Granada",
            "Sibundoy",
            "Cotorra",
            "Cachipay",
            "Gualmatán",
            "Buenos Aires",
            "Belén",
            "Recetor",
            "Coello",
            "Tena",
            "Tibasosa",
            "Génova",
            "Marquetalia",
            "Peñol",
            "San Pablo",
            "Guática",
            "Clemencia",
            "Contadero",
            "Nilo",
            "La Pintada",
            "Pupiales",
            "Susa",
            "Ulloa",
            "Villanueva",
            "Cicuco",
            "San Cristóbal",
            "San Antonio del Tequendama",
            "Andalucía",
            "Anserma",
            "Prado-Sevilla",
            "Palocabildo",
            "Cáqueza",
            "Cabrera",
            "Cartago",
            "Ospina",
            "Nemocón",
            "Simijaca",
            "El Cerrito",
            "Carlosama",
            "Aldana",
            "Nuevo Colón",
            "Nimaima",
            "Palestina",
            "Berruecos",
            "Apía",
            "Pueblorrico",
            "Purísima de la Concepción",
            "Chivatá",
            "San Sebastián de Mariquita",
            "Restrepo",
            "San Pedro",
            "Calamar",
            "Jenesano",
            "Florencia",
            "Anapoima",
            "San José",
            "Tópaga",
            "Venecia",
            "Cucaita",
            "Angelópolis",
            "Santa Rosa de Viterbo",
            "Padilla",
            "Sutatenza",
            "Momil",
            "Risaralda",
            "Ventaquemada",
            "Caloto",
            "Guachené",
            "Yacuanquer",
            "San Vicente",
            "Manaure Balcón del Cesar",
            "Pinchote",
            "Turbaná",
            "Hispania",
            "Nariño",
            "Chinácota",
            "Villanueva",
            "Vijes",
            "Cómbita",
            "Boyacá",
            "Concordia",
            "Chachagüí",
            "Viterbo",
            "Soplaviento",
            "Guachucal",
            "Soracá",
            "La Vega",
            "San Pedro",
            "Mompós",
            "Belalcázar",
            "Ciénega",
            "Oporapa",
            "Sasaima",
            "Santa Catalina",
            "La Hormiga",
            "Garagoa",
            "Jambaló",
            "Tenza",
            "Nocaima",
            "Toro",
            "Los Palmitos",
            "Palmito",
            "Subachoque",
            "La Celia",
            "Morroa",
            "San Jerónimo",
            "Ancuya",
            "Buenavista",
            "Consacá",
            "Imués",
            "San Pedro",
            "Sutatausa",
            "Cocorná",
            "González",
            "La Cruz",
            "Ricaurte",
            "Lebrija",
            "Monguí",
            "Sevilla",
            "Enciso",
            "San Juan de Betulia",
            "Ragonvalia",
            "San Estanislao",
            "Santuario",
            "Ramiriquí",
            "Caucasia",
            "Pital",
            "Saldaña",
            "Guaitarilla",
            "Jericó",
            "Pandi",
            "Úmbita",
            "Aranzazu",
            "Palestina",
            "Betania",
            "Fúquene",
            "Guachetá",
            "Apulo",
            "Saravena",
            "Capitanejo",
            "Turmequé",
            "Toribío",
            "Lérida",
            "Ráquira",
            "Sucre",
            "Linares",
            "Tolú Viejo",
            "Ocamonte",
            "La Florida",
            "Arroyohondo",
            "Pacho",
            "Siachoque",
            "Distracción",
            "Fosca",
            "Toca",
            "Buenavista",
            "Cerro de San Antonio",
            "Venadillo",
            "Guadalupe",
            "Tuta",
            "La Apartada",
            "Somondoco",
            "San Pablo de Borbur",
            "Páramo",
            "Útica",
            "Valparaíso",
            "Ubaque",
            "Rivera",
            "Nariño",
            "La Plata",
            "Viotá",
            "Chipatá",
            "Chipaque",
            "Filadelfia",
            "Cucunubá",
            "Vianí",
            "Cerinza",
            "Campamento",
            "Sapuyes",
            "Icononzo",
            "Ansermanuevo",
            "Cuítiva",
            "Firavitoba",
            "La Peña",
            "Quetame",
            "Barranco de Loba",
            "Armenia",
            "San José de Miranda",
            "Argelia",
            "Cañasgordas",
            "Toledo",
            "Gamarra",
            "Trujillo",
            "Carmen de Apicalá",
            "Bolívar",
            "El Roble",
            "Cumbitara",
            "Anzoátegui",
            "La Victoria",
            "Quebradanegra",
            "Floresta",
            "Buenavista",
            "Balboa",
            "Albania",
            "Liborina",
            "Arbeláez",
            "Ánimas",
            "Choachí",
            "San Fernando",
            "Quipile",
            "San Luis",
            "La Sierra",
            "Yotoco",
            "Viracachá",
            "Tarqui",
            "San Roque",
            "Falan",
            "La Merced",
            "Barrancas",
            "Riofrío",
            "Chimá",
            "Entrerríos",
            "Argelia",
            "Pasca",
            "California",
            "Tibacuy",
            "Salamina",
            "Chalán",
            "Nátaga",
            "San Benito",
            "Pácora",
            "Tausa",
            "Elías",
            "Abejorral",
            "Caicedo",
            "Matanza",
            "Angostura",
            "Arenal",
            "San Rafael",
            "Leiva",
            "La Cumbre",
            "El Cairo",
            "Valle de San José",
            "Une",
            "Gachetá",
            "Busbanzá",
            "San Francisco",
            "Salamina",
            "Pauna",
            "El Tablón",
            "Albania",
            "Tibirita",
            "San Sebastián de Buenavista",
            "La Capilla",
            "Olaya",
            "El Tambo",
            "El Peñol",
            "Casabianca",
            "La Argentina",
            "Quípama",
            "San Cayetano",
            "Belén",
            "Caldas",
            "Paispamba",
            "Gámeza",
            "Bochalema",
            "San Sebastián",
            "Gómez Plata",
            "Hobo",
            "Nariño",
            "San Andrés",
            "Policarpa",
            "El Molino",
            "Giraldo",
            "Santiago",
            "Tangua",
            "Miraflores",
            "Puerto Salgar",
            "Confines",
            "Cajamarca",
            "Gramalote",
            "San Miguel de Sema",
            "Corrales",
            "Herrán",
            "Íquira",
            "Bituima",
            "Guayatá",
            "Colón",
            "Vergara",
            "Zambrano",
            "Sabanalarga",
            "Lourdes",
            "Villahermosa",
            "La Palma",
            "San Martín de Loba",
            "Alejandría",
            "Ortega",
            "Gama",
            "Paz de Río",
            "La Playa",
            "Valle de San Juan",
            "Puerto Nare",
            "San Antonio",
            "Algarrobo",
            "Anzá",
            "Pachavita",
            "Agrado",
            "Victoria",
            "Coconuco",
            "Yaguará",
            "Santa Rita",
            "Potosí",
            "Santa María",
            "El Peñón",
            "Tamalameque",
            "El Dovio",
            "Supatá",
            "Samaná",
            "San Calixto",
            "Versalles",
            "Jesús María",
            "Guapotá",
            "Génova",
            "Cértegui",
            "Suárez",
            "Berbeo",
            "El Dorado",
            "Salahonda",
            "Pamplonita",
            "La Tola",
            "San Andrés",
            "Villagómez",
            "Cumaral",
            "Machetá",
            "San José de la Montaña",
            "Jericó",
            "San Juan de Rioseco",
            "Guadalupe",
            "Norcasia",
            "Manta",
            "Aguada",
            "Carmen de Carupa",
            "Venecia",
            "Astrea",
            "Paime",
            "Carolina",
            "San Miguel",
            "Briceño",
            "Mistrató",
            "Zaragoza",
            "Mercaderes",
            "Ábrego",
            "Sotaquirá",
            "Sucre",
            "Pijiño del Carmen",
            "El Copey",
            "El Carmen de Chucurí",
            "Jordán",
            "Suárez",
            "Belmira",
            "San Carlos",
            "El Peñón",
            "Peque",
            "Beltrán",
            "San Bernardo",
            "Restrepo",
            "Morelia",
            "Saladoblanco",
            "Macanal",
            "Monterrey",
            "Contratación",
            "Tello",
            "Santa Isabel",
            "San Luis",
            "Tesalia",
            "Topaipí",
            "Caparrapí",
            "Punta de Piedras",
            "Herveo",
            "Hacarí",
            "Altamira",
            "Andagoya",
            "La Llanada",
            "Fuente de Oro",
            "Yuto",
            "Charta",
            "Buriticá",
            "Molagavita",
            "Coper",
            "Maceo",
            "Pijao",
            "Caracolí",
            "Puerres",
            "Mutiscua",
            "Fómeque",
            "Guaca",
            "Ubalá",
            "Castilla La Nueva",
            "Otanche",
            "San Francisco",
            "San Diego",
            "Mosquera",
            "Vegachí",
            "Yalí",
            "Betéitiva",
            "El Guamo",
            "Cucutilla",
            "Darién",
            "La Paz",
            "Prado",
            "Morales",
            "Guayabetal",
            "Bolívar",
            "San Martín",
            "Managrú",
            "El Rosario",
            "Paicol",
            "Durania",
            "Pueblo Rico",
            "Chaguaní",
            "Macaravita",
            "Cunday",
            "San Cayetano",
            "Cáchira",
            "La Paz",
            "Chiriguaná",
            "El Tambo",
            "Río Viejo",
            "La Esperanza",
            "Chima",
            "Carcasí",
            "Zetaquira",
            "Puerto Caicedo",
            "San Carlos de Guaroa",
            "Arboledas",
            "Frontino",
            "Rondón",
            "Rionegro",
            "Piedras",
            "San Joaquín",
            "Sucre",
            "Salazar",
            "Teruel",
            "La Gloria",
            "Curillo",
            "Ricaurte",
            "Guamal",
            "Yacopí",
            "Bucarasica",
            "Concepción",
            "Chámeza",
            "Beté",
            "Gachalá",
            "Cerrito",
            "Santiago",
            "Paimadó",
            "Payán",
            "Lloró",
            "Convención",
            "Unguía",
            "Hato",
            "San Ángel",
            "Silos",
            "Cácota",
            "Villavieja",
            "Piedrancha",
            "Chivor",
            "Pulí",
            "Santa María",
            "Acandí",
            "Villa Caro",
            "Ituango",
            "Barbacoas",
            "Remolino",
            "Cantagallo",
            "Mongua",
            "Dolores",
            "Santa Bárbara",
            "Baraya",
            "Bagadó",
            "Campohermoso",
            "Solita",
            "Iscuandé",
            "San José del Fragua",
            "Betulia",
            "Murillo",
            "Socotá",
            "Pore",
            "San Luis de Gaceno",
            "Becerril",
            "Toledo",
            "Mutis",
            "Abriaquí",
            "Cabrera",
            "Belén de los Andaquíes",
            "Villarrica",
            "Alpujarra",
            "Bolívar",
            "Puerto Meluk",
            "Albania",
            "Valparaíso",
            "Yondó",
            "Santa Helena del Opón",
            "El Guacamayo",
            "Onzaga",
            "Barranca de Upía",
            "Funes",
            "Gámbita",
            "San Juanito",
            "Suratá",
            "Chitagá",
            "Lejanías",
            "El Castillo",
            "Marulanda",
            "El Carmen",
            "Nunchía",
            "La Salina",
            "Gutiérrez",
            "Piamonte",
            "Nóvita",
            "San Juan de Arama",
            "Páez",
            "Colombia",
            "Milán",
            "Támara",
            "Trinidad",
            "El Calvario",
            "Roncesvalles",
            "Paya",
            "Pizarro",
            "Puerto Rico",
            "Sabanalarga",
            "Cubarral",
            "Cabuyaro",
            "Santa Genoveva de Docordó",
            "Mesetas",
            "Vigía del Fuerte",
            "Puerto Lleras",
            "Mapiripán",
            "Sácama",
            "Maní",
            "Murindó",
            "Santa Rosa",
            "Sipí",
            "Hato Corozal",
            "Bellavista",
            "Pisba",
            "San José del Palmar",
            "Curbaradó",
            "Puerto Leguízamo",
            "Puerto Gaitán",
            "Miraflores",
            "Carurú",
            "Calamar",
            "Taraira",
            "San José de Uré"});
            this.cboCiudad.Location = new System.Drawing.Point(256, 297);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(161, 30);
            this.cboCiudad.TabIndex = 12;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.White;
            this.lblCiudad.Location = new System.Drawing.Point(14, 293);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(75, 25);
            this.lblCiudad.TabIndex = 11;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(14, 251);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(58, 25);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.cboSexo.Location = new System.Drawing.Point(256, 255);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(161, 30);
            this.cboSexo.TabIndex = 9;
            this.cboSexo.SelectedIndexChanged += new System.EventHandler(this.cboSexo_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(55, 523);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 55);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(225, 523);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 55);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(403, 523);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 55);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmDatosEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 611);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDatosEstudiante";
            this.Text = "Datos Estudiante";
            this.Load += new System.EventHandler(this.Datos_Estudiante_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNumDocumento;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarMenu;
        private System.Windows.Forms.Button btnSalir;
    }
}