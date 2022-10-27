using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTP2
{
    public partial class Fprincipal : Form
    {
        Trivago gestor;
        public Fprincipal()
        {
            InitializeComponent();
            this.Show();
        }
       
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fregistrar fregistro = new Fregistrar();
            fregistro.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Fprincipal_Load(object sender, EventArgs e)
        {
            FprecioBase fpb = new FprecioBase();
            decimal precio = 100;
            if (fpb.ShowDialog() == DialogResult.OK)
            {
                precio = Convert.ToDecimal(fpb.tBprecioBase.Text);
            }
            gestor = new Trivago(precio);
            //DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            //DataGridViewColumn[] columnas = new DataGridViewColumn[]
            //{
            //    new DataGridViewColumn(cell),
            //    new DataGridViewColumn(cell)
            //};
            //for(int i = 0; i < columnas.Length; i++)
            //{
            //    dataGridView1.Columns.Add(columnas[i]);
            //}
            dataGridView1.ColumnCount = 2;
            foreach(Alojamiento a in gestor.Alojamientos)
            {
                dataGridView1.Rows.Add(a.Direccion, a.PrecioPorDia());
            }

        }

        private void Fprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            gestor.BackUp();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAlojamiento fa = new fAlojamiento("agregar");
            fa.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAlojamiento fa = new fAlojamiento("modif");
            fa.ShowDialog();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bajaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAlojamiento fa = new fAlojamiento("baja");
            fa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            int columnas = 1;
            for (int c = 0; c < columnas; c++)
            {
                DataGridViewImageColumn dgvc = new DataGridViewImageColumn();
                dgvc.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.Columns.Add(dgvc);
            }
            dataGridView1.Rows[n].Cells[0].Value = Properties.Resources.ciudad;
        }
    }
}
