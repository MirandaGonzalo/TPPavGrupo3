using TPG3.AccesoADatos;
using TPG3.Entidades;

namespace TPG3.Formularios.Pelicula
{
    public partial class AltaPelicula : Form
    {
        public AltaPelicula()
        {
            InitializeComponent();
        }
        private void AltaPelicula_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboOrigen();
            CargarComboCalificacion();
            CargarComboFormato();
            CargarComboGenero();
            CargarComboDistribuidora();
            CargarComboIdioma();
            CargarGrilla();
            btnActualizar.Enabled = false;
        }
        private void LimpiarCampos()
        {
            txtTitulo.Text = "";
            txtLeyenda.Text = "";
            txtDuracion.Text = "";
            txtSinopsis.Text = "";
            txtEstreno.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void CargarComboOrigen()
        {
            try
            {
                cmbOrigen.DataSource = AD_Origen.ObtenerOrigen();
                cmbOrigen.DisplayMember = "nombre";
                cmbOrigen.ValueMember = "idOrigen";
                cmbOrigen.SelectedIndex = 0;
            }

            catch (Exception)
            {
                MessageBox.Show("Error al cargar el origen de la película");
            }
        }
        private void CargarComboCalificacion()
        {
            try
            {
                cmbCalificacion.DataSource = AD_Calificacion.ObtenerTablaCalificacion();
                cmbCalificacion.DisplayMember = "descripcion";
                cmbCalificacion.ValueMember = "codCalificacion";
                cmbCalificacion.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las calificacion de la película");
            }
        }
        private void CargarComboFormato()
        {
            try
            {
                cmbFormato.DataSource = AD_Formato.ObtenerFormato();
                cmbFormato.DisplayMember = "descripcion";
                cmbFormato.ValueMember = "codFormato";
                cmbFormato.SelectedIndex = 0;
            }

            catch (Exception)
            {
                MessageBox.Show("Error al cargar el formato de la película");
            }
        }
        private void CargarComboGenero()
        {
            try
            {
                cmbGenero.DataSource = AD_Genero.ObtenerGenero();
                cmbGenero.DisplayMember = "descripcion";
                cmbGenero.ValueMember = "codGenero";
                cmbGenero.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el genero de la película");
            }
        }
        private void CargarComboDistribuidora()
        {
            try
            {
                cmbDistribuidora.DataSource = AD_Distribuidora.ObtenerDistribuidora();
                cmbDistribuidora.DisplayMember = "nombreDistribuidora";
                cmbDistribuidora.ValueMember = "idDistribuidora";
                cmbDistribuidora.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la distribuidora de la película");
            }
        }     
        private void CargarComboIdioma()
        {
            try
            {
                cmbIdioma.DataSource = AD_Idioma.ObtenerIdioma();
                cmbIdioma.DisplayMember = "descripcion";
                cmbIdioma.ValueMember = "codIdioma";
                cmbIdioma.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el idioma de la película");
            }
        }  
        private void CargarGrilla()
        {
            try
            {
                gdrActualizarPeli.DataSource = AD_Pelicula.ObtenerTablaPelicula();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de películas.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Peliculas p = ObtenerDatosPelicula();
            bool resultado = AD_Pelicula.AgregarPeliculaABD(p);
            if (resultado)
            {
                MessageBox.Show("Película agregada con éxito");
                LimpiarCampos();
                CargarComboOrigen();
                CargarComboCalificacion();
                CargarComboFormato();
                CargarComboGenero();
                CargarComboDistribuidora();
                CargarComboIdioma();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar la película");
            }
        }
        private Peliculas ObtenerDatosPelicula()
        {
            Peliculas pelicula = new Peliculas();
            pelicula.Titulo = txtTitulo.Text.Trim();
            pelicula.Leyenda = txtLeyenda.Text.Trim();
            pelicula.Duracion = txtDuracion.Text.Trim();
            pelicula.Sinopsis = txtSinopsis.Text.Trim();
            pelicula.AñoEstreno = int.Parse(txtEstreno.Text);
            pelicula.Origen = (int)cmbOrigen.SelectedValue;
            pelicula.Calificacion = (int)cmbCalificacion.SelectedValue;
            pelicula.Formato = (int)cmbFormato.SelectedValue;
            pelicula.Genero = (int)cmbGenero.SelectedValue;
            pelicula.Distribuidora = (int)cmbDistribuidora.SelectedValue;
            pelicula.Idioma = (int)cmbIdioma.SelectedValue;
            return pelicula;
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Peliculas p = ObtenerDatosPelicula();
            bool resultado = AD_Pelicula.ActualizarPelicula(p);
            if (resultado)
            {
                MessageBox.Show("Película actualizado con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboOrigen();
                CargarComboCalificacion();
                CargarComboFormato();
                CargarComboGenero();
                CargarComboDistribuidora();
                CargarComboIdioma();
            }
            else
            {
                MessageBox.Show("Error al actualizar Película");
            }
        }
        private void CargarCampos(Peliculas p)
        {
            txtCodPelicula.Text = p.CodPelicula.ToString();
            txtTitulo.Text = p.Titulo.ToString();
            txtLeyenda.Text = p.Leyenda.ToString();
            txtDuracion.Text = p.Duracion;
            txtSinopsis.Text = p.Sinopsis;
            txtEstreno.Text = p.AñoEstreno.ToString();
            cmbOrigen.SelectedValue = p.Origen;
            cmbCalificacion.SelectedValue = p.Calificacion;
            cmbFormato.SelectedValue = p.Formato;
            cmbGenero.SelectedValue = p.Genero;
            cmbDistribuidora.SelectedValue = p.Distribuidora;
            cmbIdioma.SelectedValue = p.Idioma;
        }

        private void gdrActualizarPeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrActualizarPeli.Rows[indice];
            int codPelicula = (int)filaSeleccionada.Cells["codPeliculaItem"].Value;
            Peliculas p = AD_Pelicula.ObtenerPelicula(codPelicula);
            LimpiarCampos();
            CargarCampos(p);
        }
    }
}
