using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FrmPrincipal;
using Microsoft.EntityFrameworkCore;


namespace FrmPrincipal

{
    public partial class FrmVista : Form
    {
        public int? ClienteID;
        Venta Oventa = null;
        public FrmVista(int? id = null)
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

                Txt_Fullname.Text = Oventa.NombreCliente;
                Txt_Edad.Text = Oventa.Edad.ToString();
                Cmb_SaborGalleta.Text = Oventa.saborGalleta;
                Txt_Cantidad.Text = Oventa.cantidad.ToString();
                Dtp_FechaCompra.Value = Oventa.FechaCompra;
                Txt_OrderID.Text = Oventa.OrdenID.ToString();
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ConexionBD db = new ConexionBD())

            {

                refrescar();

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

        private void refrescar()
        {
            using (ConexionBD db = new ConexionBD())
           {

                var lst = from d in db.ventas
                          select d;
                dataGridView1.DataSource = lst.ToList();

                Txt_Fullname.Text = "";
                Txt_Edad.Text = "";
                Cmb_SaborGalleta.Text = "";
                Txt_Cantidad.Text = "";
                Dtp_FechaCompra.Text = "";
                Txt_OrderID.Text="";
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


                        db.SaveChanges();


                        refrescar();

                        MessageBox.Show("Datos insertados con exito");



                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }
        }


        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            using (ConexionBD db = new ConexionBD())

            {

                int? ClienteId = GetClientID();

                try
                {
                    int? id = GetClientID();

                    if (id == null)
                    {
                        MessageBox.Show("Seleccione un registro primero");
                        return;
                    }

                    var venta = db.ventas.Find(id);

                    if (venta == null)
                    {
                        MessageBox.Show("Registro no encontrado");
                        return;
                    }

                    venta.NombreCliente = Txt_Fullname.Text;
                    venta.Edad = Convert.ToInt32(Txt_Edad.Text);
                    venta.saborGalleta = Cmb_SaborGalleta.Text;
                    venta.cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                    venta.FechaCompra = Dtp_FechaCompra.Value;
                    venta.OrdenID = Convert.ToInt32(Txt_OrderID.Text);

                    db.SaveChanges();


                    refrescar();

                    MessageBox.Show("Registro actualizado correctamente ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }





        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

            using (ConexionBD db = new ConexionBD())
            {



                int? id = GetClientID();
                if (id != null)

                {
                    Venta oVenta = db.ventas.Find(id);
                    db.ventas.Remove(oVenta);
                    db.SaveChanges();

                    MessageBox.Show("Registro Eliminado Exitosamente");
                }

                refrescar();



            }

        }

    }

}
    

        


    

