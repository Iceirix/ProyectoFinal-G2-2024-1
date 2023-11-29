using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using BiblioExpedientes;

namespace PantallaExpediente
{
    public partial class FormPadre : Form
    {
        private Form formIniciarSesion;
        private ArrayList pacientes;
        private Paciente paciente;
        private Form activeForm = null;
        private bool medico;
        public FormPadre(Form formIniciarSesion)
        {
            InitializeComponent();
            this.formIniciarSesion = formIniciarSesion;
            openChildForm(new FormHome());
            pacientes = new ArrayList();
            cargarPacientes();
        }

        

        public bool Medico { get => medico; set => medico = value; }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHome());
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (paciente != null)
            {
                openChildForm(new FormPerfil(paciente));

            }
            else
                MessageBox.Show("No hay informacion registrada");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSettings(this, paciente));
        }

        private void cargarPacientes()
        {
            Paciente Maria = new Paciente("María González Sánchez", 71.3f, 1.75f, 36.2f, 12, 65, "120/80");
            Maria.User = "Maria";
            Maria.Sexo = "Femenino";
            Maria.DiaNacimiento = 25;
            Maria.MesNacimiento = 08;
            Maria.AñoNacimiento = 2000;
            Maria.Edad = 23;
            Maria.Telefono = "55968148";
            Maria.Email = "maria@gmail.com";
            Maria.Calle = "Rosedal";
            Maria.Delegacion = "Coyoacan";
            Maria.Cp = "06471";
            Maria.Polen = false;
            Maria.Acaros = true;
            Maria.Latex = true;
            Maria.Medicamento = false;
            Maria.NombreMedicamento = null;
            Maria.Alimento = true;
            Maria.NombreAlimento = "mango";
            Maria.EnfermedadesPrevias.Push("Asma");
            Maria.EnfermedadesPrevias.Push("Gastrítis");
            Maria.HospitalizacionesPrevias.Push("NO");
            Maria.Transfusiones.Push("NO");
            Maria.Cirugias.Push("Cesárea");
            Maria.Fracturas.Push("Hombro");
            Maria.AntecedentesHeredofamiliares.Push("Hemofilia");
            Maria.AntecedentesHeredofamiliares.Push("Síndrome de Marfan");

            Paciente Carlos = new Paciente("Carlos Rodríguez Martínez", 55.4f, 1.59f, 36.5f, 15, 72, "100/65");
            Carlos.User = "Carlos";
            Carlos.Sexo = "Masculino";
            Carlos.DiaNacimiento = 22;
            Carlos.MesNacimiento = 07;
            Carlos.AñoNacimiento = 2003;
            Carlos.Edad = 20;
            Carlos.Telefono = "5561620735";
            Carlos.Email = "carlosrmatrz@hotmail.com";
            Carlos.Calle = "Alondras";
            Carlos.Delegacion = "Milpa Alta";
            Carlos.Cp = "89765";
            Carlos.Polen = true;
            Carlos.Acaros = false;
            Carlos.Latex = false;
            Carlos.Medicamento = true;
            Carlos.NombreMedicamento = "penicilina";
            Carlos.Alimento = false;
            Carlos.NombreAlimento = null;
            Carlos.EnfermedadesPrevias.Push("Sarampión");
            Carlos.EnfermedadesPrevias.Push("SIDA");
            Carlos.EnfermedadesPrevias.Push("Zika");
            Carlos.EnfermedadesPrevias.Push("Ébola");
            Carlos.HospitalizacionesPrevias.Push("NO");
            Carlos.Transfusiones.Push("NO");
            Carlos.Cirugias.Push("NO");
            Carlos.Fracturas.Push("Muñeca");
            Carlos.AntecedentesHeredofamiliares.Push("Fibrosis quística");
            Carlos.AntecedentesHeredofamiliares.Push("Telasemia");

            Paciente Laura = new Paciente("Laura Pérez López", 82.4f, 1.59f, 35.9f, 17, 82, "118/79");
            Laura.User = "Laura";
            Laura.Sexo = "Femenino";
            Laura.DiaNacimiento = 09;
            Laura.MesNacimiento = 11;
            Laura.AñoNacimiento = 2003;
            Laura.Edad = 20;
            Laura.Telefono = "5634562398";
            Laura.Email = "laurapelo@gmail.com";
            Laura.Calle = "Rey Papatzin";
            Laura.Delegacion = "Coyoacan";
            Laura.Cp = "06489";
            Laura.Polen = false;
            Laura.Acaros = false;
            Laura.Latex = true;
            Laura.Medicamento = false;
            Laura.NombreMedicamento = null;
            Laura.Alimento = true;
            Laura.NombreAlimento = "Cebolla";
            Laura.EnfermedadesPrevias.Push("Gastritis");
            Laura.EnfermedadesPrevias.Push("Migraña");
            Laura.EnfermedadesPrevias.Push("Osteoporosis");
            Laura.EnfermedadesPrevias.Push("Tiroiditis");
            Laura.EnfermedadesPrevias.Push("Eczema");
            Laura.HospitalizacionesPrevias.Push("NO");
            Laura.Transfusiones.Push("NO");
            Laura.Cirugias.Push("NO");
            Laura.Fracturas.Push("Muñeca");
            Laura.AntecedentesHeredofamiliares.Push("Diabetes");
            Laura.AntecedentesHeredofamiliares.Push("Miopia");

            Paciente Luis = new Paciente("Luis Fernando Paredes Rivera", 60, 1.63f, 36.9f, 13, 72, "110/62");
            Luis.User = "Luis";
            Luis.Sexo = "Masculino";
            Luis.DiaNacimiento = 22;
            Luis.MesNacimiento = 07;
            Luis.AñoNacimiento = 2003;
            Luis.Edad = 20;
            Luis.Telefono = "5561620735";
            Luis.Email = "luisfdopapu@gmail.com";
            Luis.Calle = "Arbolito";
            Luis.Delegacion = "Coyoacan";
            Luis.Cp = "06471";
            Luis.Polen = false;
            Luis.Acaros = false;
            Luis.Latex = false;
            Luis.Medicamento = false;
            Luis.NombreMedicamento = null;
            Luis.Alimento = false;
            Luis.NombreAlimento = null;
            Luis.EnfermedadesPrevias.Push("Enfermedad1");
            Luis.EnfermedadesPrevias.Push("Enfermedad2");
            Luis.HospitalizacionesPrevias.Push("NO");
            Luis.Transfusiones.Push("NO");
            Luis.Cirugias.Push("Apendicitis");
            Luis.Fracturas.Push("Radio");
            Luis.AntecedentesHeredofamiliares.Push("Hipertensión Arterial");
            Luis.AntecedentesHeredofamiliares.Push("Trombofilia");

            Paciente Alejandro = new Paciente("Alejandro García Hernández", 89.4f, 1.84f, 37.5f, 20, 66, "97/62");
            Alejandro.User = "Alejandro";
            Alejandro.Sexo = "Masculino";
            Alejandro.DiaNacimiento = 24;
            Alejandro.MesNacimiento = 01;
            Alejandro.AñoNacimiento = 1975;
            Alejandro.Edad = 48;
            Alejandro.Telefono = "5554237643";
            Alejandro.Email = "alexdxd@gmail.com";
            Alejandro.Calle = "Pino";
            Alejandro.Delegacion = "Venustiano Carranza";
            Alejandro.Cp = "15530";
            Alejandro.Polen = true;
            Alejandro.Acaros = false;
            Alejandro.Latex = false;
            Alejandro.Medicamento = true;
            Alejandro.NombreMedicamento = "Paracetamol";
            Alejandro.Alimento = false;
            Alejandro.NombreAlimento = null;
            Alejandro.EnfermedadesPrevias.Push("Dertatitis atópica");
            Alejandro.EnfermedadesPrevias.Push("Insufuciencia renal");
            Alejandro.HospitalizacionesPrevias.Push("Internado 10 días");
            Alejandro.Transfusiones.Push("NO");
            Alejandro.Cirugias.Push("Riñones");
            Alejandro.Fracturas.Push("NO");
            Alejandro.AntecedentesHeredofamiliares.Push("Parkinson");


            Paciente Isabella = new Paciente("Isabella Velez Cruz", 48.9f, 1.50f, 38.4f, 13, 75, "150/100");
            Isabella.User = "Isabella";
            Isabella.Sexo = "Femenino";
            Isabella.DiaNacimiento = 08;
            Isabella.MesNacimiento = 03;
            Isabella.AñoNacimiento = 1999;
            Isabella.Edad = 24;
            Isabella.Telefono = "5678984356";
            Isabella.Email = "isaabxlx@gmail.com";
            Isabella.Calle = "Coyamel";
            Isabella.Delegacion = "Álavaro Obregón";
            Isabella.Cp = "78654";
            Isabella.Polen = false;
            Isabella.Acaros = false;
            Isabella.Latex = false;
            Isabella.Medicamento = false;
            Isabella.NombreMedicamento = null;
            Isabella.Alimento = false;
            Isabella.NombreAlimento = null;
            Isabella.EnfermedadesPrevias.Push("Úlcera gástrica");
            Isabella.EnfermedadesPrevias.Push("Dermatitis");
            Isabella.HospitalizacionesPrevias.Push("NO");
            Isabella.Transfusiones.Push("NO");
            Isabella.Cirugias.Push("NO");
            Isabella.Fracturas.Push("NO");
            Isabella.AntecedentesHeredofamiliares.Push("Diabetes");

            Paciente Aitana = new Paciente("Aitana Juárez Mondragón", 63.6f, 1.70f, 36.3f, 15, 100, "90/60");
            Aitana.User = "Aitana";
            Aitana.Sexo = "Femenino";
            Aitana.DiaNacimiento = 14;
            Aitana.MesNacimiento = 02;
            Aitana.AñoNacimiento = 1986;
            Aitana.Edad = 37;
            Aitana.Telefono = "5598653420";
            Aitana.Email = "aitanajumo@gmail.com";
            Aitana.Calle = "Jilgueros";
            Aitana.Delegacion = "Iztacalco";
            Aitana.Cp = "98654";
            Aitana.Polen = false;
            Aitana.Acaros = false;
            Aitana.Latex = false;
            Aitana.Medicamento = false;
            Aitana.NombreMedicamento = null;
            Aitana.Alimento = false;
            Aitana.NombreAlimento = null;
            Aitana.EnfermedadesPrevias.Push("Influenza");
            Aitana.EnfermedadesPrevias.Push("Depresión");
            Aitana.EnfermedadesPrevias.Push("Hipertensión arterial");
            Aitana.EnfermedadesPrevias.Push("Conjuntivitis");
            Aitana.EnfermedadesPrevias.Push("Colitis");
            Aitana.HospitalizacionesPrevias.Push("NO");
            Aitana.Transfusiones.Push("NO");
            Aitana.Cirugias.Push("NO");
            Aitana.Fracturas.Push("NO");
            Aitana.AntecedentesHeredofamiliares.Push("Osteoporosis");


            Paciente Alfredo = new Paciente("Alfredo Mora Cortes", 74.3f, 1.72f, 36.7f, 11, 61, "105/63");
            Alfredo.User = "Alfredo";
            Alfredo.Sexo = "Masculino";
            Alfredo.DiaNacimiento = 06;
            Alfredo.MesNacimiento = 10;
            Alfredo.AñoNacimiento = 1994;
            Alfredo.Edad = 29;
            Alfredo.Telefono = "5678964012";
            Alfredo.Email = "alfffedou@gmail.com";
            Alfredo.Calle = "Primaveras";
            Alfredo.Delegacion = "Tlalpan";
            Alfredo.Cp = "87453";
            Alfredo.Polen = true;
            Alfredo.Acaros = true;
            Alfredo.Latex = false;
            Alfredo.Medicamento = true;
            Alfredo.NombreMedicamento = "Clindamicina";
            Alfredo.Alimento = false;
            Alfredo.NombreAlimento = null;
            Alfredo.EnfermedadesPrevias.Push("Tiroiditis");
            Alfredo.HospitalizacionesPrevias.Push("NO");
            Alfredo.Transfusiones.Push("NO");
            Alfredo.Cirugias.Push("NO");
            Alfredo.Fracturas.Push("Clavícula");
            Alfredo.AntecedentesHeredofamiliares.Push("Cáncer cerebral");


            Paciente Pablo = new Paciente("Pablo Sánchez Ferrer", 87.3f, 1.72f, 35.8f, 14, 74, "85/55");
            Pablo.User = "Pablo";
            Pablo.Sexo = "Masculino";
            Pablo.DiaNacimiento = 26;
            Pablo.MesNacimiento = 11;
            Pablo.AñoNacimiento = 1989;
            Pablo.Edad = 34;
            Pablo.Telefono = "5590765833";
            Pablo.Email = "pablosanchzz@gmail.com";
            Pablo.Calle = "Framboyanes";
            Pablo.Delegacion = "Benito Juárez";
            Pablo.Cp = "08654";
            Pablo.Polen = false;
            Pablo.Acaros = false;
            Pablo.Latex = true;
            Pablo.Medicamento = false;
            Pablo.NombreMedicamento = null;
            Pablo.Alimento = false;
            Pablo.NombreAlimento = null;
            Pablo.EnfermedadesPrevias.Push("COVID-19");
            Pablo.EnfermedadesPrevias.Push("Ébola");
            Pablo.HospitalizacionesPrevias.Push("NO");
            Pablo.Transfusiones.Push("NO");
            Pablo.Cirugias.Push("NO");
            Pablo.Fracturas.Push("Fémur");
            Pablo.AntecedentesHeredofamiliares.Push("Osteoporosis");
            Pablo.AntecedentesHeredofamiliares.Push("Miopia");

            Paciente Samantha = new Paciente("Samantha Cruz Calderón", 55.4f, 1.52f, 36.1f, 18, 67, "128/80");
            Samantha.User = "Samantha";
            Samantha.Sexo = "Femenino";
            Samantha.DiaNacimiento = 01;
            Samantha.MesNacimiento = 09;
            Samantha.AñoNacimiento = 2006;
            Samantha.Edad = 17;
            Samantha.Telefono = "5679883345";
            Samantha.Email = "samyycrew@gmail.com";
            Samantha.Calle = "Mixcoac";
            Samantha.Delegacion = "Coyoacán";
            Samantha.Cp = "04763";
            Samantha.Polen = true;
            Samantha.Acaros = true;
            Samantha.Latex = true;
            Samantha.Medicamento = false;
            Samantha.NombreMedicamento = null;
            Samantha.Alimento = true;
            Samantha.NombreAlimento = "Lácteos";
            Samantha.EnfermedadesPrevias.Push("Úlcera gástrica");
            Samantha.EnfermedadesPrevias.Push("Asma");
            Samantha.EnfermedadesPrevias.Push(" Diabetes tipo 2");
            Samantha.HospitalizacionesPrevias.Push("NO");
            Samantha.Transfusiones.Push("SI");
            Samantha.Cirugias.Push("NO");
            Samantha.Fracturas.Push("NO");
            Samantha.AntecedentesHeredofamiliares.Push("Diabetes");
            Samantha.AntecedentesHeredofamiliares.Push("Astigmatismo");



            pacientes.Add(Maria);
            pacientes.Add(Carlos);
            pacientes.Add(Laura);
            pacientes.Add(Luis);
            pacientes.Add(Alejandro);
            pacientes.Add(Isabella);
            pacientes.Add(Aitana);
            pacientes.Add(Alfredo);
            pacientes.Add(Pablo);
            pacientes.Add(Samantha);

            lstbPacientes.DataSource = pacientes;
            lstbPacientes.DisplayMember = "Nombre";
        }

        private void FormPadre_FormClosing(object sender, FormClosingEventArgs e)
        {
            formIniciarSesion.Close();
        }
        public void verificarUsuario(Usuario usuario)
        {
            btnPacientes.Visible = false;
            for (int i = 0; i < pacientes.Count; i++)
            {
                Paciente varPaciente = (Paciente)pacientes[i];
                if (varPaciente.User == usuario.User)
                {
                    paciente = varPaciente;
                    lbNombre.Text = paciente.Nombre;
                    Medico = false;
                    break;
                }
                else if (i == pacientes.Count - 1)
                {
                    paciente = (Paciente)usuario;
                    pacientes.Add(paciente);
                }
                    
            }
        }
        public void actualizarNombre(string nuevoTexto)
        {
            if (lbNombre.InvokeRequired)
            {
                lbNombre.Invoke(new Action(() => lbNombre.Text = nuevoTexto));
            }
            else
            {
                lbNombre.Text = nuevoTexto;
            }
        }
        public void visibilidadBtnPacientes()
        {
            btnPacientes.Visible = true;
        }
        public void actualizarListBox()
        {
            if (lstbPacientes != null)
            {
                lstbPacientes.DataSource = null;
                lstbPacientes.DataSource = pacientes;
                lstbPacientes.DisplayMember = "Nombre";
            }
        }
        private void ptbCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            lstbPacientes.Visible = false;
            formIniciarSesion.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            lstbPacientes.Visible = !lstbPacientes.Visible;
        }

        private void lstbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbPacientes.SelectedIndex != -1 && lstbPacientes != null)
            {
                paciente = (Paciente)lstbPacientes.Items[lstbPacientes.SelectedIndex];
                if (activeForm is FormPerfil && medico)
                    btnPerfil_Click(sender, e);
                if (activeForm is FormSettings && medico)
                    btnSettings_Click(sender, e);
                lstbPacientes.Visible = false;
            }
        }
    }

}
