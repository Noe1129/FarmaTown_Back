using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farmatown.Controllers;
using farmatown.Modelos;

namespace farmatown.Vistas
{
    public partial class FrmArticulos : Form
    {
        ArticleController controladorArticulos;
        public FrmArticulos()
        {
            InitializeComponent();
            controladorArticulos = new ArticleController();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            CargarArticulosEnGrilla();
            CargarComboTiposArticulo();
            CargarComboDrogas();
            CargarComboLaboratorios();
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            CargarArticulosConFiltro();
        }

        private void btnEliminarFiltro_Click_1(object sender, EventArgs e)
        {
            CargarArticulosEnGrilla();
            txtProducto.Text = "";
        }

        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {
            if (ValidarArticulo())
            {
                DataRowView itemTipoArt = (DataRowView)cboTipoArticulo.SelectedItem;
                DataRowView itemDroga = (DataRowView)cboDroga.SelectedItem;
                DataRowView itemLab = (DataRowView)cboLaboratorio.SelectedItem;

                string nombreArticulo = txtNombre.Text;

                double precioUnitario = Convert.ToDouble(txtPrecio.Text);
                
                int idTipoArticulo = Convert.ToInt32(itemTipoArt.Row.ItemArray[0]);
                string descripcionTipoArticulo = itemTipoArt.Row.ItemArray[1].ToString();
                TipoArticulo tipo = new TipoArticulo(idTipoArticulo,descripcionTipoArticulo);

                int idDroga = Convert.ToInt32(itemDroga.Row.ItemArray[0]);
                string nombreDroga = itemDroga.Row.ItemArray[1].ToString();
                Droga droga = new Droga(idDroga, nombreDroga);

                int idLaboratorio = Convert.ToInt32(itemLab.Row.ItemArray[0]);
                string nombreLab = itemLab.Row.ItemArray[1].ToString();
                Laboratorio laboratorio = new Laboratorio(idLaboratorio, nombreLab);

                int stock = Convert.ToInt32(txtStockInicial.Text);

                Articulo articulo = new Articulo(precioUnitario,nombreArticulo,stock,tipo,droga,laboratorio);

                controladorArticulos.CrearArticulo(articulo);
                CargarArticulosEnGrilla();
            }
        }

        //METODOS

        private bool ValidarArticulo()
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            } else if(txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un precio inicial para el articulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }else if (txtStockInicial.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un stock inicial para el articulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            try
            {
                Convert.ToDouble(txtPrecio.Text);
                Convert.ToInt32(txtStockInicial.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("El precio y el stock deben ser numeros", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void CargarArticulosEnGrilla()
        {
            dgvConsultar.Rows.Clear();
            DataTable table = controladorArticulos.obtenerArticulosGrilla();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i][0], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3], table.Rows[i][4], table.Rows[i][5], table.Rows[i][6], table.Rows[i][7], table.Rows[i][8], table.Rows[i][9]);
            }
        }

        private void CargarArticulosConFiltro()
        {
            dgvConsultar.Rows.Clear();
            DataTable table = controladorArticulos.ObtenerArticulosConFiltro(txtProducto.Text);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i][0], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3], table.Rows[i][4], table.Rows[i][5], table.Rows[i][6], table.Rows[i][7], table.Rows[i][8], table.Rows[i][9]);
            }
        }

        private void CargarComboTiposArticulo()
        {
            DataTable tabla = controladorArticulos.obtenerTiposArticulosComboBox();

            cboTipoArticulo.DataSource = tabla;
            cboTipoArticulo.ValueMember = "idTipoArticulo";
            cboTipoArticulo.DisplayMember = "descripcion";
        }
        private void CargarComboDrogas()
        {
            DataTable tabla = controladorArticulos.obtenerDrogasComboBox();

            cboDroga.DataSource = tabla;
            cboDroga.ValueMember = "id_droga";
            cboDroga.DisplayMember = "nombreDroga";
        }
        private void CargarComboLaboratorios()
        {
            DataTable tabla = controladorArticulos.obtenerLaboratoriosComboBox();

            cboLaboratorio.DataSource = tabla;
            cboLaboratorio.ValueMember = "id_laboratorio";
            cboLaboratorio.DisplayMember = "nombreLab";
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvConsultar.CurrentCell.ColumnIndex == 10)
            {
                DataRowView item = (DataRowView)cboTipoArticulo.SelectedItem;

                int idArticulo = int.Parse(dgvConsultar.CurrentRow.Cells[0].Value.ToString());
                string nombre = dgvConsultar.CurrentRow.Cells[1].Value.ToString();

                int idTipoArticulo = int.Parse(dgvConsultar.CurrentRow.Cells[2].Value.ToString());
                string descTipoArticulo = dgvConsultar.CurrentRow.Cells[3].Value.ToString();
                TipoArticulo tipoArticulo = new TipoArticulo(idTipoArticulo,descTipoArticulo);

                int idDroga = int.Parse(dgvConsultar.CurrentRow.Cells[4].Value.ToString());
                string nombreDroga = dgvConsultar.CurrentRow.Cells[5].Value.ToString();
                Droga droga = new Droga(idDroga, nombreDroga);

                int idLab = int.Parse(dgvConsultar.CurrentRow.Cells[6].Value.ToString());
                string nombreLab = dgvConsultar.CurrentRow.Cells[7].Value.ToString();
                Laboratorio laboratorio = new Laboratorio(idLab, nombreLab);

                double precio = double.Parse(dgvConsultar.CurrentRow.Cells[8].Value.ToString());
                int stock = int.Parse(dgvConsultar.CurrentRow.Cells[9].Value.ToString());

                Articulo articulo = new Articulo(idArticulo,precio,nombre,stock,tipoArticulo,droga,laboratorio);
                new FrmModificarArticulo(articulo).ShowDialog();
                CargarArticulosEnGrilla();

            }
        }

        private void btnFiltrarDroga_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            DataTable table = controladorArticulos.ObtenerArticulosConFiltroDroga(txtDroga.Text);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i][0], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3], table.Rows[i][4], table.Rows[i][5], table.Rows[i][6], table.Rows[i][7], table.Rows[i][8], table.Rows[i][9]);
            }
        }
    }
}
