using TPG3.AccesoADatos;

namespace TPG3.Formularios.Funcion
{
    public partial class AltaFuncion : Form
    {
        private Entidades.Funcion func;
        public AltaFuncion(Entidades.Funcion editFuncion)
        {
            func = editFuncion;
            InitializeComponent();
            cargarFormulario(func);
        }

        private void limpiarEspacios()
        {
            maskedTextBox1.Text = maskedTextBox1.Text.Replace("_", "");
        }

        private string completarFecha(DateTime fechaInicial)
        {
            string fecha = fechaInicial.ToString();
            int charLocation = fecha.IndexOf("/", StringComparison.Ordinal);            
            string resto = "";
            string dia = fecha.Substring(0, charLocation);
            if (dia.Count() == 1) dia = "0" + dia;
            resto = fecha.Substring(charLocation+1);
            int charLocation2 = resto.IndexOf("/", StringComparison.Ordinal);            
            string mes = resto.Substring(0, charLocation2);
            if (mes.Count() == 1) mes = "0" + mes;            
            string año = resto.Substring(charLocation2+1);
            string fechaFinal = dia + "/" + mes + "/" + año;
            return fechaFinal;           
        }

        private void cargarFormulario(Entidades.Funcion editFuncion)
        {
            if (editFuncion.TipoEdicion > 1)
            {
                cargarComboSala();
                cargarComboPelicula();
                cargarComboEstado();
                cargarComboFechaInicio();
                cargarComboFechaFin();
                if (editFuncion.TipoEdicion == 2)
                {
                    var fechaHoraOld = editFuncion.fechaHora.ToString();
                    maskedTextBox1.Text = completarFecha(editFuncion.fechaHora);
                    lblTitulo.Text = "Modificar Función";
                    btnCargarFuncion.Text = "Actualizar";
                    cmbPeli.SelectedIndex = cmbPeli.FindString(editFuncion.nombrePelicula);
                    cmbPeli.SelectedValue = editFuncion.pelicula;
                    cmbEstado.SelectedIndex = cmbEstado.FindString(editFuncion.estado);
                    cmbSala.SelectedIndex = cmbSala.FindString(editFuncion.sala.ToString());
                    int charLocation = editFuncion.fechaInicio.ToString().IndexOf(" ", StringComparison.Ordinal);
                    string fechaInicio = editFuncion.fechaInicio.ToString().Substring(0, charLocation);
                    charLocation = editFuncion.fechaFin.ToString().IndexOf(" ", StringComparison.Ordinal);
                    string fechaFin = editFuncion.fechaFin.ToString().Substring(0, charLocation);
                    cmbFechaInicio.SelectedIndex = cmbFechaInicio.FindString(fechaInicio);
                    cmbFechaFin.SelectedIndex = cmbFechaFin.FindString(fechaFin);
                }
                else
                {
                    DateTime inicio = DateTime.Now;
                    maskedTextBox1.Text = completarFecha(inicio);                    
                }
            }
        }
        private void btnCargarFuncion_Click(object sender, EventArgs e)
        {
            //validamos los datos
            limpiarEspacios();
            bool valido = validarCampos();
            if (valido)
            {
                bool result = cargarFunc(func);
                if (result)
                {
                    if (func.TipoEdicion == 3)
                    {
                        MessageBox.Show("Función cargada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Función actualizada con éxito!");
                    }
                    lblError.Text = "";
                    volverMenuFuncion(sender, e);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cargarComboFechaInicio()
        {
            try { 
                cmbFechaInicio.DataSource = AD_ProgramacionSemanal.ObtenerTablaProgSem();
                cmbFechaInicio.DisplayMember = "fechaInicio";
                cmbFechaInicio.ValueMember = "fechaInicio";
                cmbFechaFin.SelectedIndex = 0;
            }
            catch (Exception)
            {
                ;
            }
        }

        private void cargarComboFechaFin()
        {
            try
            {
                cmbFechaFin.DataSource = AD_ProgramacionSemanal.ObtenerTablaProgSem();
                cmbFechaFin.DisplayMember = "fechaFin";
                cmbFechaFin.ValueMember = "fechaFin";
                cmbFechaFin.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener las fechas de fin.");
            }
        }

        private void cargarComboEstado()
        {
            try
            {
                cmbEstado.DataSource = AD_Estado.ObtenerTablaEstado();
                cmbEstado.DisplayMember = "Nombre";
                cmbEstado.ValueMember = "nombre";

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los estados.");
            }
        }

        private void cargarComboPelicula()
        {
            try
            {
                cmbPeli.DataSource = AD_Pelicula.ObtenerTablaPelicula();
                cmbPeli.DisplayMember = "ptitulo";
                cmbPeli.ValueMember = "codPelicula";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener las películas.");
            }
        }

        private bool validarFormatoDate(String fecha)
        {
            string inputString = fecha;
            DateTime dDateInicio;

            if (DateTime.TryParse(inputString, out dDateInicio))
            {
                String.Format("{0:dd/MM/yyyy hh:mm}", dDateInicio);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarCampos()
        {
            if (maskedTextBox1.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo 'Fecha y Hora' no puede estar vacío.";
                maskedTextBox1.Focus();
                return false;
            }
            int count = 0;
            foreach (char c in maskedTextBox1.Text)
            {
                count++;
            }
            if (count < 16)
            {
                lblError.Text = "La Fecha no está completa (dd/mm/yyyy hh:mm).";
                maskedTextBox1.Focus();
                return false;
            }
            if (!validarFormatoDate(maskedTextBox1.Text))
            {
                lblError.Text = "La Fecha no está en el formato correcto (dd/mm/yyyy hh:mm).";
                maskedTextBox1.Focus();
                return false;
            }
            var date = new DateTime(1800, 1, 1);
            DateTime fechaInicio = DateTime.ParseExact(maskedTextBox1.Text.Trim(), "dd/MM/yyyy HH:mm", null);
            if (fechaInicio <= date)
            {
                lblError.Text = "La Fecha no es válida.";
                maskedTextBox1.Focus();
                return false;
            }
            return true;
        }
        public bool cargarFunc(Entidades.Funcion func)
        {
            if (func.TipoEdicion > 1)
            {
                try
                {
                    func.sala = (int)cmbSala.SelectedValue;
                    func.pelicula = (int)cmbPeli.SelectedValue;
                    func.estado = cmbEstado.SelectedValue.ToString();
                    func.fechaInicio = (DateTime)cmbFechaInicio.SelectedValue;
                    func.fechaFin = (DateTime)cmbFechaFin.SelectedValue;
                    var fecha = maskedTextBox1.Text;
                    if (func.TipoEdicion == 3)
                    {
                        try
                        {
                            func.fechaHora = DateTime.Parse(fecha);
                            AD_Funcion.InsertarFuncion(func);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al insertar la función!");
                            return false;
                        }
                    }
                    else
                    {
                        try
                        {
                            var fechaNueva = DateTime.Parse(fecha);
                            AD_Funcion.ActualizarFuncion(func, fechaNueva);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al modificar la función!");
                            return false;
                        }
                    };
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                    return false;
                }
            }
            else
            {
                try
                {
                    AD_Funcion.EliminarFuncion(func);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar la función.");
                    return false;
                }
            }
            return true;
        }

        private void cargarComboSala()
        {
            try
            {
                cmbSala.DataSource = AD_Sala.ObtenerTablaSala();
                cmbSala.DisplayMember = "Numero";
                cmbSala.ValueMember = "codigo";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los combos.");
            }
        }

        private void cmbFechaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbFechaInicio.SelectedIndex;
            cmbFechaFin.SelectedIndex = index;
        }

        private void volverMenuFuncion(object sender, EventArgs e)
        {
            Main.main1.btnFuncion_Click(sender, e);
        }
    }
}


