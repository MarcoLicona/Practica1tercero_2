using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base.DAO;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        MarcaTabla obje = new MarcaTabla();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obje.VistaTabla();
        }
    }
}
