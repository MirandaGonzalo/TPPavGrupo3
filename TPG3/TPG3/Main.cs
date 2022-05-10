using System;

namespace TPG3
{
    public partial class Main : Form
    {
        private static Form currentForm = null; 
        internal static Main main1;
        public Main()
        {
            InitializeComponent();
            hideSubMenu();
            main1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void displayLogIn()
        {
            Form logIn = new LogIn();
            logIn.ShowDialog();
        }
        private void openChildForm(Form childForm)
        {
            if (currentForm != null) currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void hideSubMenu()
        {
            panelSubMenuPelicula.Visible = false;
            panelSubMenuCombo.Visible = false;
            panelSubMenuEntrada.Visible = false;
            panelSubMenuFuncion.Visible = false;
            panelSubMenuTicket.Visible = false;
            panelSubMenuMedioPago.Visible = false;
            panelSubMenuUsuario.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false){
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMenuPelicula_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPelicula);
        }
        private void btnMenuCombo_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCombo);
        }

        private void btnMenuEntrada_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuEntrada);
        }

        private void btnMenuFuncion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuFuncion);
        }

        private void btnMenuTicket_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuTicket);
        }

        private void btnMenuMedioPago_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMedioPago);
        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuUsuario);
        }

        public void btnSubPromocionAltaPromocion(Entidades.Promocion promo)
        {
            Formularios.Promocion.AltaPromocion altaPromocion = new Formularios.Promocion.AltaPromocion(promo);
            openChildForm(altaPromocion);
        }

        public void btnSubPromocion_Click(object sender, EventArgs e)
        {
            Formularios.Promocion.ListaPromocion listaPromocion = new Formularios.Promocion.ListaPromocion();
            openChildForm(listaPromocion);
        }

        public void btnSubMedioPagoAltaMedioPago(Entidades.MedioPago medio)
        {
            Formularios.MedioPago.AltaMedioPago altaMedioPago = new Formularios.MedioPago.AltaMedioPago(medio);
            openChildForm(altaMedioPago);
        }

        public void btnSubMedioPago_Click(object sender, EventArgs e)
        {
            Formularios.MedioPago.ListaMedioPago listaMedioPago = new Formularios.MedioPago.ListaMedioPago();
            openChildForm(listaMedioPago);
        }

        private void btnSubTipoDocumento_Click(object sender, EventArgs e)
        {
            Formularios.TipoDocumento.ListadoTipoDocumento listaTipoDocumento = new Formularios.TipoDocumento.ListadoTipoDocumento();
            openChildForm(listaTipoDocumento);
        }

        public void btnSubEmpleado_Click(object sender, EventArgs e)
        {
            Formularios.Empleado.ListadoEmpelado listaEmpleado = new Formularios.Empleado.ListadoEmpelado();
            openChildForm(listaEmpleado);
        }
        public void btnSubTicketAltaEmpleado(Entidades.Empleado empleado)
        {
            Formularios.Empleado.AltaEmpleado altaEmpleado = new Formularios.Empleado.AltaEmpleado(empleado);
            openChildForm(altaEmpleado);
        }

        private void btnSubParticipantes_Click(object sender, EventArgs e)
        {
            Formularios.Actores.ListaActor listaActor = new Formularios.Actores.ListaActor();
            openChildForm(listaActor);
        }

        public void btnSubParticipantesAltaParticipante(object sender, EventArgs e)
        {
            Formularios.Actores.AltaActor altaActor = new Formularios.Actores.AltaActor();
            openChildForm(altaActor);
        }
    }
}