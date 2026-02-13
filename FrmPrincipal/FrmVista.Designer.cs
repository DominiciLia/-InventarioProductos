
namespace FrmPrincipal
{
    partial class FrmVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVista));
            Panel_Principal = new Panel();
            Btn_Eliminar = new Button();
            Btn_Actualizar = new Button();
            Btn_Crear = new Button();
            button1 = new Button();
            lbl_Titulo = new Label();
            dataGridView1 = new DataGridView();
            conexionBDBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Txt_Fullname = new TextBox();
            Cmb_SaborGalleta = new ComboBox();
            Txt_Cantidad = new TextBox();
            Dtp_FechaCompra = new DateTimePicker();
            Txt_OrderID = new TextBox();
            Txt_Edad = new TextBox();
            Panel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBDBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Panel_Principal
            // 
            Panel_Principal.Controls.Add(Btn_Eliminar);
            Panel_Principal.Controls.Add(Btn_Actualizar);
            Panel_Principal.Controls.Add(Btn_Crear);
            Panel_Principal.Controls.Add(button1);
            Panel_Principal.Controls.Add(lbl_Titulo);
            Panel_Principal.Dock = DockStyle.Top;
            Panel_Principal.Location = new Point(0, 0);
            Panel_Principal.Name = "Panel_Principal";
            Panel_Principal.Size = new Size(1534, 255);
            Panel_Principal.TabIndex = 0;
            Panel_Principal.Paint += panel1_Paint;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.BackColor = Color.BlanchedAlmond;
            Btn_Eliminar.Font = new Font("High Tower Text", 10.125F, FontStyle.Bold | FontStyle.Italic);
            Btn_Eliminar.Location = new Point(960, 199);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(150, 46);
            Btn_Eliminar.TabIndex = 4;
            Btn_Eliminar.Text = "Eliminar";
            Btn_Eliminar.UseVisualStyleBackColor = false;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            // 
            // Btn_Actualizar
            // 
            Btn_Actualizar.BackColor = Color.BlanchedAlmond;
            Btn_Actualizar.Font = new Font("High Tower Text", 10.125F, FontStyle.Bold | FontStyle.Italic);
            Btn_Actualizar.Location = new Point(583, 199);
            Btn_Actualizar.Name = "Btn_Actualizar";
            Btn_Actualizar.Size = new Size(150, 46);
            Btn_Actualizar.TabIndex = 3;
            Btn_Actualizar.Text = "Actualizar";
            Btn_Actualizar.UseVisualStyleBackColor = false;
            Btn_Actualizar.Click += Btn_Actualizar_Click;
            // 
            // Btn_Crear
            // 
            Btn_Crear.BackColor = Color.BlanchedAlmond;
            Btn_Crear.Font = new Font("High Tower Text", 10.125F, FontStyle.Bold | FontStyle.Italic);
            Btn_Crear.Location = new Point(379, 199);
            Btn_Crear.Name = "Btn_Crear";
            Btn_Crear.Size = new Size(150, 46);
            Btn_Crear.TabIndex = 2;
            Btn_Crear.Text = "Crear";
            Btn_Crear.UseVisualStyleBackColor = false;
            Btn_Crear.Click += Btn_Crear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.BlanchedAlmond;
            button1.Font = new Font("High Tower Text", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(764, 199);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.BackColor = Color.Transparent;
            lbl_Titulo.Font = new Font("Monotype Corsiva", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Titulo.ForeColor = Color.WhiteSmoke;
            lbl_Titulo.Location = new Point(73, 29);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(1407, 117);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Sistema de Registro de Ventas Galletas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 756);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1534, 390);
            dataGridView1.TabIndex = 1;
            // 
            // conexionBDBindingSource
            // 
            conexionBDBindingSource.DataSource = typeof(ConexionBD);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("High Tower Text", 16.125F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(40, 309);
            label1.Name = "label1";
            label1.Size = new Size(335, 49);
            label1.TabIndex = 2;
            label1.Text = "Nombre Completo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("High Tower Text", 16.125F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(40, 385);
            label2.Name = "label2";
            label2.Size = new Size(110, 49);
            label2.TabIndex = 3;
            label2.Text = "Edad";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("High Tower Text", 16.125F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(40, 469);
            label3.Name = "label3";
            label3.Size = new Size(263, 49);
            label3.TabIndex = 4;
            label3.Text = "Sabor Galleta";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("High Tower Text", 16.125F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(912, 309);
            label4.Name = "label4";
            label4.Size = new Size(183, 49);
            label4.TabIndex = 5;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("High Tower Text", 16.125F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(912, 382);
            label5.Name = "label5";
            label5.Size = new Size(319, 49);
            label5.TabIndex = 6;
            label5.Text = "Fecha de Compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("High Tower Text", 16.125F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(912, 455);
            label6.Name = "label6";
            label6.Size = new Size(180, 49);
            label6.TabIndex = 7;
            label6.Text = "OrderID";
            // 
            // Txt_Fullname
            // 
            Txt_Fullname.Location = new Point(379, 312);
            Txt_Fullname.Name = "Txt_Fullname";
            Txt_Fullname.Size = new Size(491, 39);
            Txt_Fullname.TabIndex = 8;
            // 
            // Cmb_SaborGalleta
            // 
            Cmb_SaborGalleta.FormattingEnabled = true;
            Cmb_SaborGalleta.Items.AddRange(new object[] { "Red Velvet", "Chocolate", "M&M ", "Chispas de chocolate", "Pistacho", "Oreo" });
            Cmb_SaborGalleta.Location = new Point(379, 478);
            Cmb_SaborGalleta.Name = "Cmb_SaborGalleta";
            Cmb_SaborGalleta.Size = new Size(242, 40);
            Cmb_SaborGalleta.TabIndex = 10;
            // 
            // Txt_Cantidad
            // 
            Txt_Cantidad.Location = new Point(1118, 319);
            Txt_Cantidad.Name = "Txt_Cantidad";
            Txt_Cantidad.Size = new Size(159, 39);
            Txt_Cantidad.TabIndex = 11;
            // 
            // Dtp_FechaCompra
            // 
            Dtp_FechaCompra.Location = new Point(1237, 395);
            Dtp_FechaCompra.Name = "Dtp_FechaCompra";
            Dtp_FechaCompra.Size = new Size(285, 39);
            Dtp_FechaCompra.TabIndex = 12;
            // 
            // Txt_OrderID
            // 
            Txt_OrderID.Location = new Point(1098, 465);
            Txt_OrderID.Name = "Txt_OrderID";
            Txt_OrderID.Size = new Size(159, 39);
            Txt_OrderID.TabIndex = 13;
            // 
            // Txt_Edad
            // 
            Txt_Edad.Location = new Point(390, 405);
            Txt_Edad.Name = "Txt_Edad";
            Txt_Edad.Size = new Size(200, 39);
            Txt_Edad.TabIndex = 14;
            // 
            // FrmVista
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1534, 1146);
            Controls.Add(Txt_Edad);
            Controls.Add(Txt_OrderID);
            Controls.Add(Dtp_FechaCompra);
            Controls.Add(Txt_Cantidad);
            Controls.Add(Cmb_SaborGalleta);
            Controls.Add(Txt_Fullname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Panel_Principal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVista";
            Text = "FrmVista";
            Panel_Principal.ResumeLayout(false);
            Panel_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBDBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel Panel_Principal;
        private Label lbl_Titulo;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource conexionBDBindingSource;
        private Button Btn_Eliminar;
        private Button Btn_Actualizar;
        private Button Btn_Crear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Txt_Fullname;
        private DateTimePicker dateTimePicker1;
        private ComboBox Cmb_SaborGalleta;
        private TextBox Txt_Cantidad;
        private DateTimePicker Dtp_FechaCompra;
        private TextBox Txt_OrderID;
        private TextBox Txt_Edad;
    }
}