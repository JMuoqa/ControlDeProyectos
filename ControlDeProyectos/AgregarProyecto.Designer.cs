namespace ControlDeProyectos
{
    partial class AgregarProyecto
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
            etiqueta_entrega = new Label();
            etiqueta_inicio = new Label();
            etiqueta_descripcion = new Label();
            etiqueta_proyecto = new Label();
            etiqueta_cliente = new Label();
            etiqueta_precio = new Label();
            etiqueta_cobro = new Label();
            titulo_cargar = new Label();
            etiqueta_tipo = new Label();
            etiqueta_entrada = new Label();
            entrada_cliente = new TextBox();
            linea_cliente = new Panel();
            linea_proyecto = new Panel();
            entrada_proyecto = new TextBox();
            entrada_descripcion = new RichTextBox();
            linea_descripcion = new Panel();
            linea_descripcion2 = new Panel();
            linea_tipo = new Panel();
            entrada_tipo = new ComboBox();
            linea_inicio = new Panel();
            entrada_inicio = new TextBox();
            linea_entrega = new Panel();
            entrada_entrega = new TextBox();
            linea_inf_funciones = new Panel();
            linea_sup_funciones = new Panel();
            entrada_funciones = new RichTextBox();
            linea_precio = new Panel();
            entrada_precio = new TextBox();
            linea_pago = new Panel();
            entrada_pago = new TextBox();
            SuspendLayout();
            // 
            // etiqueta_entrega
            // 
            etiqueta_entrega.Anchor = AnchorStyles.Top;
            etiqueta_entrega.AutoSize = true;
            etiqueta_entrega.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_entrega.ForeColor = Color.Black;
            etiqueta_entrega.Location = new Point(503, 99);
            etiqueta_entrega.Name = "etiqueta_entrega";
            etiqueta_entrega.Size = new Size(315, 27);
            etiqueta_entrega.TabIndex = 9;
            etiqueta_entrega.Text = "Fecha estimada de entrega";
            // 
            // etiqueta_inicio
            // 
            etiqueta_inicio.Anchor = AnchorStyles.Top;
            etiqueta_inicio.AutoSize = true;
            etiqueta_inicio.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_inicio.ForeColor = Color.Black;
            etiqueta_inicio.Location = new Point(113, 619);
            etiqueta_inicio.Name = "etiqueta_inicio";
            etiqueta_inicio.Size = new Size(181, 27);
            etiqueta_inicio.TabIndex = 8;
            etiqueta_inicio.Text = "Fecha de inicio";
            // 
            // etiqueta_descripcion
            // 
            etiqueta_descripcion.Anchor = AnchorStyles.Top;
            etiqueta_descripcion.AutoSize = true;
            etiqueta_descripcion.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_descripcion.ForeColor = Color.Black;
            etiqueta_descripcion.ImageAlign = ContentAlignment.MiddleLeft;
            etiqueta_descripcion.Location = new Point(113, 239);
            etiqueta_descripcion.Name = "etiqueta_descripcion";
            etiqueta_descripcion.Size = new Size(290, 27);
            etiqueta_descripcion.TabIndex = 7;
            etiqueta_descripcion.Text = "Descripcion del proyecto";
            etiqueta_descripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_proyecto
            // 
            etiqueta_proyecto.Anchor = AnchorStyles.Top;
            etiqueta_proyecto.AutoSize = true;
            etiqueta_proyecto.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_proyecto.ForeColor = Color.Black;
            etiqueta_proyecto.Location = new Point(113, 169);
            etiqueta_proyecto.Name = "etiqueta_proyecto";
            etiqueta_proyecto.Size = new Size(247, 27);
            etiqueta_proyecto.TabIndex = 6;
            etiqueta_proyecto.Text = "Nombre del proyecto";
            etiqueta_proyecto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_cliente
            // 
            etiqueta_cliente.Anchor = AnchorStyles.Top;
            etiqueta_cliente.AutoSize = true;
            etiqueta_cliente.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_cliente.ForeColor = Color.Black;
            etiqueta_cliente.Location = new Point(113, 99);
            etiqueta_cliente.Name = "etiqueta_cliente";
            etiqueta_cliente.Size = new Size(225, 27);
            etiqueta_cliente.TabIndex = 99;
            etiqueta_cliente.Text = "Nombre del cliente";
            etiqueta_cliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_precio
            // 
            etiqueta_precio.Anchor = AnchorStyles.Top;
            etiqueta_precio.AutoSize = true;
            etiqueta_precio.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_precio.ForeColor = Color.Black;
            etiqueta_precio.Location = new Point(503, 376);
            etiqueta_precio.Name = "etiqueta_precio";
            etiqueta_precio.Size = new Size(82, 27);
            etiqueta_precio.TabIndex = 11;
            etiqueta_precio.Text = "Precio";
            // 
            // etiqueta_cobro
            // 
            etiqueta_cobro.Anchor = AnchorStyles.Top;
            etiqueta_cobro.AutoSize = true;
            etiqueta_cobro.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_cobro.ForeColor = Color.Black;
            etiqueta_cobro.Location = new Point(503, 446);
            etiqueta_cobro.Name = "etiqueta_cobro";
            etiqueta_cobro.Size = new Size(192, 27);
            etiqueta_cobro.TabIndex = 12;
            etiqueta_cobro.Text = "Pago del cliente";
            // 
            // titulo_cargar
            // 
            titulo_cargar.Anchor = AnchorStyles.Top;
            titulo_cargar.AutoSize = true;
            titulo_cargar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_cargar.ForeColor = Color.Black;
            titulo_cargar.Location = new Point(310, 9);
            titulo_cargar.Name = "titulo_cargar";
            titulo_cargar.Size = new Size(299, 47);
            titulo_cargar.TabIndex = 13;
            titulo_cargar.Text = "Cargar proyecto";
            // 
            // etiqueta_tipo
            // 
            etiqueta_tipo.Anchor = AnchorStyles.Top;
            etiqueta_tipo.AutoSize = true;
            etiqueta_tipo.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_tipo.ForeColor = Color.Black;
            etiqueta_tipo.Location = new Point(113, 539);
            etiqueta_tipo.Name = "etiqueta_tipo";
            etiqueta_tipo.Size = new Size(199, 27);
            etiqueta_tipo.TabIndex = 14;
            etiqueta_tipo.Text = "Tipo de proyecto";
            etiqueta_tipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_entrada
            // 
            etiqueta_entrada.Anchor = AnchorStyles.Top;
            etiqueta_entrada.AutoSize = true;
            etiqueta_entrada.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_entrada.ForeColor = Color.Black;
            etiqueta_entrada.Location = new Point(503, 169);
            etiqueta_entrada.Name = "etiqueta_entrada";
            etiqueta_entrada.Size = new Size(341, 27);
            etiqueta_entrada.TabIndex = 15;
            etiqueta_entrada.Text = "Funcionalidades importantes";
            // 
            // entrada_cliente
            // 
            entrada_cliente.Anchor = AnchorStyles.Top;
            entrada_cliente.BackColor = Color.FromArgb(242, 225, 199);
            entrada_cliente.BorderStyle = BorderStyle.None;
            entrada_cliente.Font = new Font("Montserrat", 15F);
            entrada_cliente.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_cliente.Location = new Point(113, 129);
            entrada_cliente.Name = "entrada_cliente";
            entrada_cliente.Size = new Size(319, 25);
            entrada_cliente.TabIndex = 8;
            entrada_cliente.Text = "Gaston";
            entrada_cliente.Enter += TodasLasEntradasNormales_Enter;
            entrada_cliente.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_cliente
            // 
            linea_cliente.Anchor = AnchorStyles.Top;
            linea_cliente.BackColor = Color.FromArgb(0, 0, 32);
            linea_cliente.Enabled = false;
            linea_cliente.Location = new Point(113, 158);
            linea_cliente.Margin = new Padding(3, 3, 3, 10);
            linea_cliente.Name = "linea_cliente";
            linea_cliente.Size = new Size(319, 1);
            linea_cliente.TabIndex = 17;
            // 
            // linea_proyecto
            // 
            linea_proyecto.Anchor = AnchorStyles.Top;
            linea_proyecto.BackColor = Color.FromArgb(0, 0, 32);
            linea_proyecto.Enabled = false;
            linea_proyecto.Location = new Point(113, 228);
            linea_proyecto.Margin = new Padding(3, 3, 3, 10);
            linea_proyecto.Name = "linea_proyecto";
            linea_proyecto.Size = new Size(319, 1);
            linea_proyecto.TabIndex = 101;
            // 
            // entrada_proyecto
            // 
            entrada_proyecto.Anchor = AnchorStyles.Top;
            entrada_proyecto.BackColor = Color.FromArgb(242, 225, 199);
            entrada_proyecto.BorderStyle = BorderStyle.None;
            entrada_proyecto.Font = new Font("Montserrat", 15F);
            entrada_proyecto.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_proyecto.Location = new Point(113, 199);
            entrada_proyecto.Name = "entrada_proyecto";
            entrada_proyecto.Size = new Size(319, 25);
            entrada_proyecto.TabIndex = 9;
            entrada_proyecto.Text = "Dia \"D\"";
            entrada_proyecto.Enter += TodasLasEntradasNormales_Enter;
            entrada_proyecto.Leave += TodasLasEntradasNormales_Leave;
            // 
            // entrada_descripcion
            // 
            entrada_descripcion.Anchor = AnchorStyles.Top;
            entrada_descripcion.BackColor = Color.FromArgb(222, 205, 179);
            entrada_descripcion.BorderStyle = BorderStyle.None;
            entrada_descripcion.Font = new Font("Montserrat", 15F);
            entrada_descripcion.ForeColor = Color.Black;
            entrada_descripcion.Location = new Point(113, 285);
            entrada_descripcion.MaxLength = 350;
            entrada_descripcion.Name = "entrada_descripcion";
            entrada_descripcion.Size = new Size(319, 237);
            entrada_descripcion.TabIndex = 10;
            entrada_descripcion.Text = "";
            // 
            // linea_descripcion
            // 
            linea_descripcion.Anchor = AnchorStyles.Top;
            linea_descripcion.BackColor = Color.FromArgb(0, 0, 32);
            linea_descripcion.Enabled = false;
            linea_descripcion.Location = new Point(113, 278);
            linea_descripcion.Margin = new Padding(3, 3, 3, 10);
            linea_descripcion.Name = "linea_descripcion";
            linea_descripcion.Size = new Size(319, 1);
            linea_descripcion.TabIndex = 102;
            // 
            // linea_descripcion2
            // 
            linea_descripcion2.Anchor = AnchorStyles.Top;
            linea_descripcion2.BackColor = Color.FromArgb(0, 0, 32);
            linea_descripcion2.Enabled = false;
            linea_descripcion2.Location = new Point(113, 528);
            linea_descripcion2.Margin = new Padding(3, 3, 3, 10);
            linea_descripcion2.Name = "linea_descripcion2";
            linea_descripcion2.Size = new Size(319, 1);
            linea_descripcion2.TabIndex = 103;
            // 
            // linea_tipo
            // 
            linea_tipo.Anchor = AnchorStyles.Top;
            linea_tipo.BackColor = Color.FromArgb(0, 0, 32);
            linea_tipo.Enabled = false;
            linea_tipo.Location = new Point(113, 608);
            linea_tipo.Margin = new Padding(3, 3, 3, 10);
            linea_tipo.Name = "linea_tipo";
            linea_tipo.Size = new Size(319, 1);
            linea_tipo.TabIndex = 105;
            // 
            // entrada_tipo
            // 
            entrada_tipo.Anchor = AnchorStyles.Top;
            entrada_tipo.BackColor = Color.FromArgb(242, 225, 199);
            entrada_tipo.FlatStyle = FlatStyle.Flat;
            entrada_tipo.Font = new Font("Montserrat", 15F);
            entrada_tipo.ForeColor = Color.Black;
            entrada_tipo.FormattingEnabled = true;
            entrada_tipo.Items.AddRange(new object[] { "Pagian Web", "Aplicacion de escritorio" });
            entrada_tipo.Location = new Point(113, 569);
            entrada_tipo.Name = "entrada_tipo";
            entrada_tipo.Size = new Size(319, 35);
            entrada_tipo.TabIndex = 11;
            // 
            // linea_inicio
            // 
            linea_inicio.Anchor = AnchorStyles.Top;
            linea_inicio.BackColor = Color.FromArgb(0, 0, 32);
            linea_inicio.Enabled = false;
            linea_inicio.Location = new Point(113, 678);
            linea_inicio.Margin = new Padding(3, 3, 3, 10);
            linea_inicio.Name = "linea_inicio";
            linea_inicio.Size = new Size(319, 1);
            linea_inicio.TabIndex = 107;
            // 
            // entrada_inicio
            // 
            entrada_inicio.Anchor = AnchorStyles.Top;
            entrada_inicio.BackColor = Color.FromArgb(242, 225, 199);
            entrada_inicio.BorderStyle = BorderStyle.None;
            entrada_inicio.Font = new Font("Montserrat", 15F);
            entrada_inicio.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_inicio.Location = new Point(113, 649);
            entrada_inicio.Name = "entrada_inicio";
            entrada_inicio.Size = new Size(319, 25);
            entrada_inicio.TabIndex = 12;
            entrada_inicio.Text = "24-08-2025";
            entrada_inicio.Enter += TodasLasEntradasNormales_Enter;
            entrada_inicio.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_entrega
            // 
            linea_entrega.Anchor = AnchorStyles.Top;
            linea_entrega.BackColor = Color.FromArgb(0, 0, 32);
            linea_entrega.Enabled = false;
            linea_entrega.Location = new Point(503, 158);
            linea_entrega.Margin = new Padding(3, 3, 3, 10);
            linea_entrega.Name = "linea_entrega";
            linea_entrega.Size = new Size(319, 1);
            linea_entrega.TabIndex = 109;
            // 
            // entrada_entrega
            // 
            entrada_entrega.Anchor = AnchorStyles.Top;
            entrada_entrega.BackColor = Color.FromArgb(242, 225, 199);
            entrada_entrega.BorderStyle = BorderStyle.None;
            entrada_entrega.Font = new Font("Montserrat", 15F);
            entrada_entrega.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_entrega.Location = new Point(503, 129);
            entrada_entrega.Name = "entrada_entrega";
            entrada_entrega.Size = new Size(319, 25);
            entrada_entrega.TabIndex = 13;
            entrada_entrega.Text = "24-09-2025";
            entrada_entrega.Enter += TodasLasEntradasNormales_Enter;
            entrada_entrega.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_inf_funciones
            // 
            linea_inf_funciones.Anchor = AnchorStyles.Top;
            linea_inf_funciones.BackColor = Color.FromArgb(0, 0, 32);
            linea_inf_funciones.Enabled = false;
            linea_inf_funciones.Location = new Point(503, 365);
            linea_inf_funciones.Margin = new Padding(3, 3, 3, 10);
            linea_inf_funciones.Name = "linea_inf_funciones";
            linea_inf_funciones.Size = new Size(319, 1);
            linea_inf_funciones.TabIndex = 112;
            // 
            // linea_sup_funciones
            // 
            linea_sup_funciones.Anchor = AnchorStyles.Top;
            linea_sup_funciones.BackColor = Color.FromArgb(0, 0, 32);
            linea_sup_funciones.Enabled = false;
            linea_sup_funciones.Location = new Point(503, 208);
            linea_sup_funciones.Margin = new Padding(3, 3, 3, 10);
            linea_sup_funciones.Name = "linea_sup_funciones";
            linea_sup_funciones.Size = new Size(319, 1);
            linea_sup_funciones.TabIndex = 111;
            // 
            // entrada_funciones
            // 
            entrada_funciones.Anchor = AnchorStyles.Top;
            entrada_funciones.BackColor = Color.FromArgb(222, 205, 179);
            entrada_funciones.BorderStyle = BorderStyle.None;
            entrada_funciones.Font = new Font("Montserrat", 15F);
            entrada_funciones.ForeColor = Color.Black;
            entrada_funciones.Location = new Point(503, 215);
            entrada_funciones.MaxLength = 250;
            entrada_funciones.Name = "entrada_funciones";
            entrada_funciones.Size = new Size(319, 144);
            entrada_funciones.TabIndex = 14;
            entrada_funciones.Text = "";
            // 
            // linea_precio
            // 
            linea_precio.Anchor = AnchorStyles.Top;
            linea_precio.BackColor = Color.FromArgb(0, 0, 32);
            linea_precio.Enabled = false;
            linea_precio.Location = new Point(503, 435);
            linea_precio.Margin = new Padding(3, 3, 3, 10);
            linea_precio.Name = "linea_precio";
            linea_precio.Size = new Size(319, 1);
            linea_precio.TabIndex = 114;
            // 
            // entrada_precio
            // 
            entrada_precio.Anchor = AnchorStyles.Top;
            entrada_precio.BackColor = Color.FromArgb(242, 225, 199);
            entrada_precio.BorderStyle = BorderStyle.None;
            entrada_precio.Font = new Font("Montserrat", 15F);
            entrada_precio.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_precio.Location = new Point(503, 406);
            entrada_precio.Name = "entrada_precio";
            entrada_precio.Size = new Size(319, 25);
            entrada_precio.TabIndex = 15;
            entrada_precio.Text = "$400.000";
            entrada_precio.Enter += TodasLasEntradasNormales_Enter;
            entrada_precio.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_pago
            // 
            linea_pago.Anchor = AnchorStyles.Top;
            linea_pago.BackColor = Color.FromArgb(0, 0, 32);
            linea_pago.Enabled = false;
            linea_pago.Location = new Point(503, 505);
            linea_pago.Margin = new Padding(3, 3, 3, 10);
            linea_pago.Name = "linea_pago";
            linea_pago.Size = new Size(319, 1);
            linea_pago.TabIndex = 116;
            // 
            // entrada_pago
            // 
            entrada_pago.Anchor = AnchorStyles.Top;
            entrada_pago.BackColor = Color.FromArgb(242, 225, 199);
            entrada_pago.BorderStyle = BorderStyle.None;
            entrada_pago.Font = new Font("Montserrat", 15F);
            entrada_pago.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_pago.Location = new Point(503, 476);
            entrada_pago.Name = "entrada_pago";
            entrada_pago.Size = new Size(319, 25);
            entrada_pago.TabIndex = 16;
            entrada_pago.Text = "$200.000";
            entrada_pago.Enter += TodasLasEntradasNormales_Enter;
            entrada_pago.Leave += TodasLasEntradasNormales_Leave;
            // 
            // AgregarProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(933, 742);
            Controls.Add(linea_pago);
            Controls.Add(entrada_pago);
            Controls.Add(linea_precio);
            Controls.Add(entrada_precio);
            Controls.Add(linea_inf_funciones);
            Controls.Add(linea_sup_funciones);
            Controls.Add(entrada_funciones);
            Controls.Add(linea_entrega);
            Controls.Add(entrada_entrega);
            Controls.Add(linea_inicio);
            Controls.Add(entrada_inicio);
            Controls.Add(entrada_tipo);
            Controls.Add(linea_tipo);
            Controls.Add(linea_descripcion2);
            Controls.Add(linea_descripcion);
            Controls.Add(entrada_descripcion);
            Controls.Add(linea_proyecto);
            Controls.Add(entrada_proyecto);
            Controls.Add(linea_cliente);
            Controls.Add(entrada_cliente);
            Controls.Add(etiqueta_entrada);
            Controls.Add(etiqueta_tipo);
            Controls.Add(titulo_cargar);
            Controls.Add(etiqueta_cobro);
            Controls.Add(etiqueta_precio);
            Controls.Add(etiqueta_entrega);
            Controls.Add(etiqueta_inicio);
            Controls.Add(etiqueta_descripcion);
            Controls.Add(etiqueta_proyecto);
            Controls.Add(etiqueta_cliente);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarProyecto";
            Text = "AgregarProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etiqueta_entrega;
        private Label etiqueta_inicio;
        private Label etiqueta_descripcion;
        private Label etiqueta_proyecto;
        private Label etiqueta_cliente;
        private Label etiqueta_precio;
        private Label etiqueta_cobro;
        private Label titulo_cargar;
        private Label etiqueta_tipo;
        private Label etiqueta_entrada;
        private TextBox entrada_cliente;
        private Panel linea_cliente;
        private Panel linea_proyecto;
        private TextBox entrada_proyecto;
        private RichTextBox entrada_descripcion;
        private Panel linea_descripcion;
        private Panel linea_descripcion2;
        private Panel linea_tipo;
        private ComboBox entrada_tipo;
        private Panel linea_inicio;
        private TextBox entrada_inicio;
        private Panel linea_entrega;
        private TextBox entrada_entrega;
        private Panel linea_inf_funciones;
        private Panel linea_sup_funciones;
        private RichTextBox entrada_funciones;
        private Panel linea_precio;
        private TextBox entrada_precio;
        private Panel linea_pago;
        private TextBox entrada_pago;
    }
}