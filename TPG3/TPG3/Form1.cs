namespace TPG3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hideSubMenu()
        {
            panelSubMenuPelicula.Visible = false;
            panelSubMenuCombo.Visible = false;
            panelSubMenuFuncion.Visible = false;
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

        private void btnMenuCombo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCombo);
        }

        private void btnMenuFunción_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuFuncion);
        }
    }
}