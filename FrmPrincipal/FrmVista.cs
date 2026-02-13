using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FrmPrincipal;
using System.Data.Da

namespace FrmPrincipal
{
    public partial class FrmVista : Form
    {
        public int? ClienteID;
        Venta Oventa = null;
        public FrmVista(int? id =null)
        {
            InitializeComponent();

            this.ClienteID = id;
            if (id != null)
                CargarDatos();

            Panel_Principal.BackColor = Color.FromArgb(100, 0, 0, 0);

            using (ConexionBD db = new ConexionBD())

            {

                var lst = from d in db.ventas
                          select d;
                dataGridView1.DataSource = lst.ToList();

            }

        }

        private void CargarDatos()
        {
            using (ConexionBD db = new ConexionBD())
            {
                Oventa = db.ventas.Find(ClienteID);
            }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int? GetClientID()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            }

            catch 
            {
                return null; 
            }
        }
      

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            using (ConexionBD db = new ConexionBD())

                try
                {


                    {
                        if (ClienteID == null)
                            Oventa = new Venta();


                        Oventa.NombreCliente = Txt_Fullname.Text;
                        Oventa.Edad = Convert.ToInt32(Txt_Edad.Text);
                        Oventa.saborGalleta = Cmb_SaborGalleta.Text;
                        Oventa.cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                        Oventa.FechaCompra = Convert.ToDateTime(Dtp_FechaCompra.Text);
                        Oventa.OrdenID = Convert.ToInt32(Txt_OrderID.Text);

                        
                        if (ClienteID == null)
                        {
                            db.ventas.Add(Oventa);
                        }

                        else
                        {
                            db.Entry(Oventa).State = System.Data.Entity.EntityState.Modified;
                        }


                            db.ventas.Add(Oventa);
                            db.SaveChanges();


                            var lst = from d in db.ventas
                                      select d;
                            dataGridView1.DataSource = lst.ToList();

                            MessageBox.Show("Datos insertados ocn exito");

                        

                    }
                   

                }
                catch (Exception ex)
                { 
                 MessageBox.Show(ex.Message);

                    
                }
        }


        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            using (ConexionBD db = new ConexionBD()) ;

            int? ClienteId = GetClientID();

            if(ClienteID != null)
            {
              FrmVista ofrmvista = new FrmVista(ClienteId);
                ofrmvista.ShowDialog();
            }




        }

    }
}
