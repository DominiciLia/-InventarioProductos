using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FrmPrincipal;

namespace FrmPrincipal
{
    public partial class FrmVista : Form
    {
        public FrmVista()
        {
            InitializeComponent();

            Panel_Principal.BackColor = Color.FromArgb(100, 0, 0, 0);

          }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ConexionBD db = new ConexionBD())

            {

                var lst = from d in db.ventas
                          select d;
                dataGridView1.DataSource = lst.ToList();
            
            }

        }
    }
}
