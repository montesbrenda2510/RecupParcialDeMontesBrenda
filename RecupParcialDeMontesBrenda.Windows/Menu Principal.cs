using RecupParcialDeMontesBrenda.Datos;
using RecupParcialDeMontesBrenda.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecupParcialDeMontesBrenda.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCuboAE frm = new frmCuboAE() { Text="Agregar un nuevo cubo"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Cubo cubo = frm.GetCubo();
            repocitorio.Agregar(cubo);
            DataGridViewRow r = CostruirFila();
            Setearfila(r, cubo);
            AgregarFila(r);

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);

        }

        private DataGridViewRow CostruirFila()
        {
            
            
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                return r;
            

        }

        private void Setearfila(DataGridViewRow r, Cubo cubo)
        {
            r.Cells[colArista.Index].Value = cubo.Arista;
            r.Cells[colRelleno.Index].Value = cubo.Relleno.ToString();
            r.Cells[colTrazo.Index].Value = cubo.trazo.ToString();
            r.Cells[colVolumen.Index].Value = cubo.GetVolumen();
            r.Cells[colArea.Index].Value=cubo.GetArea();

            r.Tag = cubo;


        
        private RepocitorioDeCubo repocitorio;
        private void Form1_Load(object sender, EventArgs e)
        {
            repocitorio = new RepocitorioDeCubo();


        }
    }
}
