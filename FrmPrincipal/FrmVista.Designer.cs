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
            button1 = new Button();
            lbl_Titulo = new Label();
            dataGridView1 = new DataGridView();
            conexionBDBindingSource = new BindingSource(components);
            Btn_Crear = new Button();
            Btn_Actualizar = new Button();
            Btn_Eliminar = new Button();
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
            Panel_Principal.Size = new Size(1460, 255);
            Panel_Principal.TabIndex = 0;
            Panel_Principal.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.BlanchedAlmond;
            button1.Font = new Font("High Tower Text", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(720, 199);
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
            lbl_Titulo.Location = new Point(25, 34);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(1407, 117);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Sistema de Registro de Ventas Galletas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 643);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1460, 390);
            dataGridView1.TabIndex = 1;
            // 
            // conexionBDBindingSource
            // 
            conexionBDBindingSource.DataSource = typeof(ConexionBD);
            // 
            // Btn_Crear
            // 
            Btn_Crear.BackColor = Color.BlanchedAlmond;
            Btn_Crear.Font = new Font("High Tower Text", 10.125F, FontStyle.Bold | FontStyle.Italic);
            Btn_Crear.Location = new Point(319, 199);
            Btn_Crear.Name = "Btn_Crear";
            Btn_Crear.Size = new Size(150, 46);
            Btn_Crear.TabIndex = 2;
            Btn_Crear.Text = "Crear";
            Btn_Crear.UseVisualStyleBackColor = false;
            // 
            // Btn_Actualizar
            // 
            Btn_Actualizar.BackColor = Color.BlanchedAlmond;
            Btn_Actualizar.Font = new Font("High Tower Text", 10.125F, FontStyle.Bold | FontStyle.Italic);
            Btn_Actualizar.Location = new Point(522, 199);
            Btn_Actualizar.Name = "Btn_Actualizar";
            Btn_Actualizar.Size = new Size(150, 46);
            Btn_Actualizar.TabIndex = 3;
            Btn_Actualizar.Text = "Actualizar";
            Btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.BackColor = Color.BlanchedAlmond;
            Btn_Eliminar.Font = new Font("High Tower Text", 10.125F, FontStyle.Bold | FontStyle.Italic);
            Btn_Eliminar.Location = new Point(912, 199);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(150, 46);
            Btn_Eliminar.TabIndex = 4;
            Btn_Eliminar.Text = "Eliminar";
            Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // FrmVista
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1460, 1033);
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
    }
}