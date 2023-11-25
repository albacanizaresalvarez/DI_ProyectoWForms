using System.Runtime.Serialization.Formatters.Binary;

namespace ProyectoWForms
{
    public partial class Form1 : Form
    {
        private List<Alumnos> listaAlumnos;
        private int indiceActual;
        bool esNuevoAlumno = false;
        bool modificacionActiva = false;
        private string rutaArchivo = "databank.data";
        public Form1()
        {
            InitializeComponent();
            btnAnterior.Enabled = false;
            byte[] fotoNueva;


            listaAlumnos = new List<Alumnos>();

            string rutafoto1 = "C:\\Users\\albit\\Desktop\\2 DAM\\DI\\Fotos WForms\\Foto1.jpg";
            string rutafoto2 = "C:\\Users\\albit\\Desktop\\2 DAM\\DI\\Fotos WForms\\Foto2.jpg";
            string rutafoto3 = "C:\\Users\\albit\\Desktop\\2 DAM\\DI\\Fotos WForms\\Foto3.jpg";
            string rutafoto4 = "C:\\Users\\albit\\Desktop\\2 DAM\\DI\\Fotos WForms\\Foto4.jpg";
            string rutafoto5 = "C:\\Users\\albit\\Desktop\\2 DAM\\DI\\Fotos WForms\\Foto5.jpg";

            byte[] foto1 = File.ReadAllBytes(rutafoto1);
            byte[] foto2 = File.ReadAllBytes(rutafoto2);
            byte[] foto3 = File.ReadAllBytes(rutafoto3);
            byte[] foto4 = File.ReadAllBytes(rutafoto4);
            byte[] foto5 = File.ReadAllBytes(rutafoto5);

            listaAlumnos.Add(new Alumnos("Juan", "Pérez", 20, 1.75f, 12345678, 'A', true, foto1));
            listaAlumnos.Add(new Alumnos("María", "Gómez", 22, 1.68f, 98765432, 'B', false, foto2));
            listaAlumnos.Add(new Alumnos("Carlos", "Rodríguez", 21, 1.80f, 55555555, 'C', true, foto3));
            listaAlumnos.Add(new Alumnos("Pepito", "Prieto", 24, 1.91f, 98234432, 'D', true, foto4));
            listaAlumnos.Add(new Alumnos("Alba", "Cañizares", 25, 1.83f, 55534555, 'E', false, foto5));

            indiceActual = 0; // Comenzar desde el primer alumno

            // Mostrar la información del primer alumno
            MostrarAlumnoActual();
        }

        public void desactivarTextos()
        {
            txtNombre.Enabled = false;
            txtApellido1.Enabled = false;
            txtEdad.Enabled = false;
            txtAltura.Enabled = false;
            txtDni.Enabled = false;
            txtLetra.Enabled = false;
            boxImagen.Enabled = false;
        }
        public void activarTextos()
        {
            txtNombre.Enabled = true;
            txtApellido1.Enabled = true;
            txtEdad.Enabled = true;
            txtAltura.Enabled = true;
            txtDni.Enabled = true;
            txtLetra.Enabled = true;
            boxImagen.Enabled = true;
        }

        private bool MostrarAlumnoActual()
        {
            desactivarTextos();
            // Verificar si hay alumnos en la lista y si el índice está dentro de los límites
            if ((listaAlumnos.Count > 0) && (indiceActual >= 0) && (indiceActual < listaAlumnos.Count))
            {
                Alumnos alumnoActual = listaAlumnos[indiceActual];

                txtNombre.Text = alumnoActual.Nombre.ToString();
                txtApellido1.Text = alumnoActual.Apellido1.ToString();
                txtEdad.Text = alumnoActual.Edad.ToString();
                txtAltura.Text = alumnoActual.Altura.ToString();
                txtDni.Text = alumnoActual.Dni.ToString();
                txtLetra.Text = alumnoActual.Letra.ToString();
                checkBox1.Checked = alumnoActual.EsNuevo;
                boxImagen.Image = byteArrayToImage(alumnoActual.Foto);
                txtRecuento.Text = listaAlumnos.Count.ToString();


                Console.WriteLine($"Mostrando alumno {indiceActual + 1} de {listaAlumnos.Count}");
                return true;
            }
            else
            {
                return false;
            }

        }
       
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                MostrarAlumnoActual();
            }

            // Desactivar el botón Anterior si no hay registros anteriores
            btnAnterior.Enabled = (indiceActual > 0);

            // Activar el botón Siguiente después de hacer clic en Anterior
            btnSiguiente.Enabled = true;

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceActual < listaAlumnos.Count - 1)
            {
                indiceActual++;
                MostrarAlumnoActual();
            }

            // Desactivar el botón Siguiente si no hay registros posteriores
            btnSiguiente.Enabled = (indiceActual < listaAlumnos.Count - 1);

            // Activar el botón Anterior después de hacer clic en Siguiente
            btnAnterior.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //MessageBox.Show("Mensaje 1: CheckBox activado");
                txtMensaje.Text = "Enhorabuena! Ya estas inscrito, \n las clases empezaran pronto";
            }
            else
            {
                //MessageBox.Show("Mensaje 2: CheckBox desactivado");
                txtMensaje.Text = "Esperamos que tuvieras buena experiencia";
            }
        }

        private void btnNuevaImg_Click(object sender, EventArgs e)
        {

        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            activarTextos();
            txtNombre.Clear();
            txtApellido1.Clear();
            txtEdad.Clear();
            txtAltura.Clear();
            txtDni.Clear();
            txtLetra.Clear();
            esNuevoAlumno = true;

        }
        private byte[] ObtenerImagen()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Selecciona una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lee la imagen seleccionada en un array de bytes
                        return File.ReadAllBytes(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al leer la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // En caso de error o cancelación, retorna un array de bytes vacío.
            return new byte[0];
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (esNuevoAlumno == true)
            {
                //cuando estoy creando hago un nuevo alumno
                Alumnos alumnoNuevo = listaAlumnos[indiceActual];
                string? nomNuevo = txtNombre.Text;
                string? apeNuevo = txtApellido1.Text;
                int edadNueva = int.Parse(txtEdad.Text);
                float altNueva = float.Parse(txtAltura.Text);
                int dniNuevo = int.Parse(txtDni.Text);
                char letNueva = char.Parse(txtLetra.Text);
                bool esNueNuevo = checkBox1.Checked;
                byte[] fotoNueva = ObtenerImagen();

                alumnoNuevo = new Alumnos(nomNuevo, apeNuevo, edadNueva, altNueva, dniNuevo, letNueva, esNueNuevo, fotoNueva);

                listaAlumnos.Add(alumnoNuevo);
                indiceActual = listaAlumnos.Count - 1;
                MostrarAlumnoActual();

                esNuevoAlumno = false;

            }
            else
            {
                MessageBox.Show("No has creado un alumno nuevo");
            }

            if (modificacionActiva)
            {
                //Cuando modifico solo edito el actual
                Alumnos alumnoActual = listaAlumnos[indiceActual];
                alumnoActual.Nombre = txtNombre.Text;
                alumnoActual.Apellido1 = txtApellido1.Text;
                alumnoActual.Edad = int.Parse(txtEdad.Text);
                alumnoActual.Altura = float.Parse(txtAltura.Text);
                alumnoActual.Dni = int.Parse(txtDni.Text);
                alumnoActual.Letra = char.Parse(txtLetra.Text);
                alumnoActual.EsNuevo = checkBox1.Checked;
                alumnoActual.Foto = ObtenerImagen();

                // Mostrar el alumno actualizado
                MostrarAlumnoActual();

                // Desactivar la modificación
                desactivarTextos();
                modificacionActiva = false;
            }
            else
            {
                MessageBox.Show("No se ha podido modificar");
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay alumnos en la lista
            if (listaAlumnos.Count > 0)
            {
                // Eliminar el alumno en la posición actual
                listaAlumnos.RemoveAt(indiceActual);

                // Ajustar el índice actual si es necesario
                if (indiceActual >= listaAlumnos.Count)
                {
                    indiceActual = listaAlumnos.Count - 1;
                }

                // Mostrar la información actualizada (puedes manejar el caso cuando no haya más alumnos)
                if (listaAlumnos.Count > 0)
                {
                    MostrarAlumnoActual();
                }
                else
                {
                    Console.WriteLine("No hay más alumnos en la lista.");
                }
            }
            else
            {
                Console.WriteLine("No hay alumnos en la lista para eliminar.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarAlumnoActual();
        }



        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    listaAlumnos.Clear(); // Limpiar la lista antes de cargar nuevos datos

                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        // Leer propiedades individuales desde el archivo binario
                        string nombre = reader.ReadString();
                        string apellido1 = reader.ReadString();
                        int edad = reader.ReadInt32();
                        float altura = reader.ReadSingle();
                        int dni = reader.ReadInt32();
                        char letra = reader.ReadChar();
                        bool esNuevo = reader.ReadBoolean();
                        int fotoLength = reader.ReadInt32();
                        byte[] foto = reader.ReadBytes(fotoLength);

                        // Crear un nuevo alumno con los datos leídos y agregarlo a la lista
                        Alumnos alumno = new Alumnos(nombre, apellido1, edad, altura, dni, letra, esNuevo, foto);
                        listaAlumnos.Add(alumno);
                    }
                }

                indiceActual = 0;
                MostrarAlumnoActual();
                MessageBox.Show("Datos cargados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    foreach (var alumno in listaAlumnos)
                    {
                        // Guardar propiedades individuales en el archivo binario
                        writer.Write(alumno.Nombre);
                        writer.Write(alumno.Apellido1);
                        writer.Write(alumno.Edad);
                        writer.Write(alumno.Altura);
                        writer.Write(alumno.Dni);
                        writer.Write(alumno.Letra);
                        writer.Write(alumno.EsNuevo);
                        writer.Write(alumno.Foto.Length);
                        writer.Write(alumno.Foto);
                    }
                }

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}");
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificacionActiva = true;
            activarTextos();
        }
    }
}