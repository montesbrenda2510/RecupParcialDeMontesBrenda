using RecupParcialDeMontesBrenda.Entidades;
using System;
using System.Windows.Forms;

namespace RecupParcialDeMontesBrenda.Windows
{
    public partial class frmCuboAE : Form
    {
        public frmCuboAE()
        {
            InitializeComponent();
        }
        private Cubo cubo;
        private object errorprovider1;

        public string AristaTextbox { get; private set; }
        public object ContinuoAristaButton { get; private set; }
        public object RayasAritasButton { get; private set; }

        internal Cubo GetCubo()
        {
            return cubo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cubo == null)
                {
                    cubo = new Cubo();
                }
                cubo.Arista = int.Parse(AristaTextbox.Text);
                cubo.Relleno = (Relleno)RellenoComboBox.SelectedIndex;
                if (ContinuoAristaButton.Checked)
                {
                    cubo.trazo = Trazo.Continuo;
                }
                else if (RayasAritasButton.Checked)
                {
                    cubo.trazo = Trazo.Raya;
                }
                else
                {
                    cubo.trazo = Trazo.Punto
                }




            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorprovider1.Clear();
            if (!int.TryParse(AristaTextbox, out int Arista))
            {
                valido = false;
                errorprovider1.SetError(AristaTextbox, "Arista mal ingresada");
            }
            return valido;

        }
    }
}
