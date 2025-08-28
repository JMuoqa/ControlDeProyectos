namespace ControlDeProyectos
{
    partial class EditarProyecto
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
            linea_pago = new Panel();
            entrada_pago = new TextBox();
            linea_precio = new Panel();
            entrada_precio = new TextBox();
            linea_inf_funciones = new Panel();
            linea_sup_funciones = new Panel();
            entrada_funciones = new RichTextBox();
            linea_entrega = new Panel();
            entrada_entrega = new TextBox();
            linea_inicio = new Panel();
            entrada_inicio = new TextBox();
            entrada_tipo = new ComboBox();
            linea_tipo = new Panel();
            linea_descripcion2 = new Panel();
            linea_descripcion = new Panel();
            entrada_descripcion = new RichTextBox();
            linea_proyecto = new Panel();
            entrada_proyecto = new TextBox();
            linea_cliente = new Panel();
            entrada_cliente = new TextBox();
            etiqueta_entrada = new Label();
            etiqueta_tipo = new Label();
            etiqueta_cobro = new Label();
            etiqueta_precio = new Label();
            etiqueta_entrega = new Label();
            etiqueta_inicio = new Label();
            etiqueta_descripcion = new Label();
            etiqueta_proyecto = new Label();
            etiqueta_cliente = new Label();
            titulo_editar = new Label();
            linea_id = new Panel();
            entrada_id = new TextBox();
            etiqueta_buscar = new Label();
            boton_confirmar = new Button();
            boton_vaciar = new Button();
            boton_buscar = new Button();
            label2 = new Label();
            label3 = new Label();
            panel_pie = new Panel();
            SuspendLayout();
            // 
            // linea_pago
            // 
            linea_pago.Anchor = AnchorStyles.Top;
            linea_pago.BackColor = Color.FromArgb(255, 149, 0);
            linea_pago.Enabled = false;
            linea_pago.Location = new Point(474, 704);
            linea_pago.Margin = new Padding(3, 3, 3, 10);
            linea_pago.Name = "linea_pago";
            linea_pago.Size = new Size(319, 1);
            linea_pago.TabIndex = 145;
            // 
            // entrada_pago
            // 
            entrada_pago.Anchor = AnchorStyles.Top;
            entrada_pago.BackColor = Color.FromArgb(0, 0, 32);
            entrada_pago.BorderStyle = BorderStyle.None;
            entrada_pago.Font = new Font("Montserrat", 15F);
            entrada_pago.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_pago.Location = new Point(474, 675);
            entrada_pago.Name = "entrada_pago";
            entrada_pago.Size = new Size(319, 25);
            entrada_pago.TabIndex = 133;
            entrada_pago.Text = "$200.000";
            entrada_pago.Enter += TodasLasEntradasNormales_Enter;
            entrada_pago.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_precio
            // 
            linea_precio.Anchor = AnchorStyles.Top;
            linea_precio.BackColor = Color.FromArgb(255, 149, 0);
            linea_precio.Enabled = false;
            linea_precio.Location = new Point(474, 634);
            linea_precio.Margin = new Padding(3, 3, 3, 10);
            linea_precio.Name = "linea_precio";
            linea_precio.Size = new Size(319, 1);
            linea_precio.TabIndex = 144;
            // 
            // entrada_precio
            // 
            entrada_precio.Anchor = AnchorStyles.Top;
            entrada_precio.BackColor = Color.FromArgb(0, 0, 32);
            entrada_precio.BorderStyle = BorderStyle.None;
            entrada_precio.Font = new Font("Montserrat", 15F);
            entrada_precio.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_precio.Location = new Point(474, 605);
            entrada_precio.Name = "entrada_precio";
            entrada_precio.Size = new Size(319, 25);
            entrada_precio.TabIndex = 132;
            entrada_precio.Text = "$400.000";
            entrada_precio.Enter += TodasLasEntradasNormales_Enter;
            entrada_precio.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_inf_funciones
            // 
            linea_inf_funciones.Anchor = AnchorStyles.Top;
            linea_inf_funciones.BackColor = Color.FromArgb(255, 149, 0);
            linea_inf_funciones.Enabled = false;
            linea_inf_funciones.Location = new Point(474, 564);
            linea_inf_funciones.Margin = new Padding(3, 3, 3, 10);
            linea_inf_funciones.Name = "linea_inf_funciones";
            linea_inf_funciones.Size = new Size(319, 1);
            linea_inf_funciones.TabIndex = 143;
            // 
            // linea_sup_funciones
            // 
            linea_sup_funciones.Anchor = AnchorStyles.Top;
            linea_sup_funciones.BackColor = Color.FromArgb(255, 149, 0);
            linea_sup_funciones.Enabled = false;
            linea_sup_funciones.Location = new Point(474, 407);
            linea_sup_funciones.Margin = new Padding(3, 3, 3, 10);
            linea_sup_funciones.Name = "linea_sup_funciones";
            linea_sup_funciones.Size = new Size(319, 1);
            linea_sup_funciones.TabIndex = 142;
            // 
            // entrada_funciones
            // 
            entrada_funciones.Anchor = AnchorStyles.Top;
            entrada_funciones.BackColor = Color.FromArgb(12, 12, 42);
            entrada_funciones.BorderStyle = BorderStyle.None;
            entrada_funciones.Font = new Font("Montserrat", 15F);
            entrada_funciones.ForeColor = Color.White;
            entrada_funciones.Location = new Point(474, 414);
            entrada_funciones.MaxLength = 250;
            entrada_funciones.Name = "entrada_funciones";
            entrada_funciones.Size = new Size(319, 147);
            entrada_funciones.TabIndex = 130;
            entrada_funciones.Text = "";
            // 
            // linea_entrega
            // 
            linea_entrega.Anchor = AnchorStyles.Top;
            linea_entrega.BackColor = Color.FromArgb(255, 149, 0);
            linea_entrega.Enabled = false;
            linea_entrega.Location = new Point(474, 357);
            linea_entrega.Margin = new Padding(3, 3, 3, 10);
            linea_entrega.Name = "linea_entrega";
            linea_entrega.Size = new Size(319, 1);
            linea_entrega.TabIndex = 141;
            // 
            // entrada_entrega
            // 
            entrada_entrega.Anchor = AnchorStyles.Top;
            entrada_entrega.BackColor = Color.FromArgb(0, 0, 32);
            entrada_entrega.BorderStyle = BorderStyle.None;
            entrada_entrega.Font = new Font("Montserrat", 15F);
            entrada_entrega.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_entrega.Location = new Point(474, 328);
            entrada_entrega.Name = "entrada_entrega";
            entrada_entrega.Size = new Size(319, 25);
            entrada_entrega.TabIndex = 128;
            entrada_entrega.Text = "24-09-2025";
            entrada_entrega.Enter += TodasLasEntradasNormales_Enter;
            entrada_entrega.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_inicio
            // 
            linea_inicio.Anchor = AnchorStyles.Top;
            linea_inicio.BackColor = Color.FromArgb(255, 149, 0);
            linea_inicio.Enabled = false;
            linea_inicio.Location = new Point(474, 287);
            linea_inicio.Margin = new Padding(3, 3, 3, 10);
            linea_inicio.Name = "linea_inicio";
            linea_inicio.Size = new Size(319, 1);
            linea_inicio.TabIndex = 140;
            // 
            // entrada_inicio
            // 
            entrada_inicio.Anchor = AnchorStyles.Top;
            entrada_inicio.BackColor = Color.FromArgb(0, 0, 32);
            entrada_inicio.BorderStyle = BorderStyle.None;
            entrada_inicio.Font = new Font("Montserrat", 15F);
            entrada_inicio.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_inicio.Location = new Point(474, 258);
            entrada_inicio.Name = "entrada_inicio";
            entrada_inicio.Size = new Size(319, 25);
            entrada_inicio.TabIndex = 126;
            entrada_inicio.Text = "24-08-2025";
            entrada_inicio.Enter += TodasLasEntradasNormales_Enter;
            entrada_inicio.Leave += TodasLasEntradasNormales_Leave;
            // 
            // entrada_tipo
            // 
            entrada_tipo.Anchor = AnchorStyles.Top;
            entrada_tipo.BackColor = Color.FromArgb(0, 0, 32);
            entrada_tipo.FlatStyle = FlatStyle.Flat;
            entrada_tipo.Font = new Font("Montserrat", 15F);
            entrada_tipo.ForeColor = Color.White;
            entrada_tipo.FormattingEnabled = true;
            entrada_tipo.Items.AddRange(new object[] { "Pagian Web", "Aplicacion de escritorio" });
            entrada_tipo.Location = new Point(84, 698);
            entrada_tipo.Name = "entrada_tipo";
            entrada_tipo.Size = new Size(319, 35);
            entrada_tipo.TabIndex = 125;
            entrada_tipo.Enter += TodasLasEntradasNormales_Enter;
            entrada_tipo.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_tipo
            // 
            linea_tipo.Anchor = AnchorStyles.Top;
            linea_tipo.BackColor = Color.FromArgb(255, 149, 0);
            linea_tipo.Enabled = false;
            linea_tipo.Location = new Point(84, 737);
            linea_tipo.Margin = new Padding(3, 3, 3, 10);
            linea_tipo.Name = "linea_tipo";
            linea_tipo.Size = new Size(319, 1);
            linea_tipo.TabIndex = 139;
            // 
            // linea_descripcion2
            // 
            linea_descripcion2.Anchor = AnchorStyles.Top;
            linea_descripcion2.BackColor = Color.FromArgb(255, 149, 0);
            linea_descripcion2.Enabled = false;
            linea_descripcion2.Location = new Point(84, 657);
            linea_descripcion2.Margin = new Padding(3, 3, 3, 10);
            linea_descripcion2.Name = "linea_descripcion2";
            linea_descripcion2.Size = new Size(319, 1);
            linea_descripcion2.TabIndex = 138;
            // 
            // linea_descripcion
            // 
            linea_descripcion.Anchor = AnchorStyles.Top;
            linea_descripcion.BackColor = Color.FromArgb(255, 149, 0);
            linea_descripcion.Enabled = false;
            linea_descripcion.Location = new Point(84, 407);
            linea_descripcion.Margin = new Padding(3, 3, 3, 10);
            linea_descripcion.Name = "linea_descripcion";
            linea_descripcion.Size = new Size(319, 1);
            linea_descripcion.TabIndex = 137;
            // 
            // entrada_descripcion
            // 
            entrada_descripcion.Anchor = AnchorStyles.Top;
            entrada_descripcion.BackColor = Color.FromArgb(12, 12, 42);
            entrada_descripcion.BorderStyle = BorderStyle.None;
            entrada_descripcion.Font = new Font("Montserrat", 15F);
            entrada_descripcion.ForeColor = Color.White;
            entrada_descripcion.Location = new Point(84, 414);
            entrada_descripcion.MaxLength = 350;
            entrada_descripcion.Name = "entrada_descripcion";
            entrada_descripcion.Size = new Size(319, 240);
            entrada_descripcion.TabIndex = 123;
            entrada_descripcion.Text = "";
            // 
            // linea_proyecto
            // 
            linea_proyecto.Anchor = AnchorStyles.Top;
            linea_proyecto.BackColor = Color.FromArgb(255, 149, 0);
            linea_proyecto.Enabled = false;
            linea_proyecto.Location = new Point(84, 357);
            linea_proyecto.Margin = new Padding(3, 3, 3, 10);
            linea_proyecto.Name = "linea_proyecto";
            linea_proyecto.Size = new Size(319, 1);
            linea_proyecto.TabIndex = 136;
            // 
            // entrada_proyecto
            // 
            entrada_proyecto.Anchor = AnchorStyles.Top;
            entrada_proyecto.BackColor = Color.FromArgb(0, 0, 32);
            entrada_proyecto.BorderStyle = BorderStyle.None;
            entrada_proyecto.Font = new Font("Montserrat", 15F);
            entrada_proyecto.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_proyecto.Location = new Point(84, 328);
            entrada_proyecto.Name = "entrada_proyecto";
            entrada_proyecto.Size = new Size(319, 25);
            entrada_proyecto.TabIndex = 121;
            entrada_proyecto.Text = "Dia \"D\"";
            entrada_proyecto.Enter += TodasLasEntradasNormales_Enter;
            entrada_proyecto.Leave += TodasLasEntradasNormales_Leave;
            // 
            // linea_cliente
            // 
            linea_cliente.Anchor = AnchorStyles.Top;
            linea_cliente.BackColor = Color.FromArgb(255, 149, 0);
            linea_cliente.Enabled = false;
            linea_cliente.Location = new Point(84, 287);
            linea_cliente.Margin = new Padding(3, 3, 3, 10);
            linea_cliente.Name = "linea_cliente";
            linea_cliente.Size = new Size(319, 1);
            linea_cliente.TabIndex = 134;
            // 
            // entrada_cliente
            // 
            entrada_cliente.Anchor = AnchorStyles.Top;
            entrada_cliente.BackColor = Color.FromArgb(0, 0, 32);
            entrada_cliente.BorderStyle = BorderStyle.None;
            entrada_cliente.Font = new Font("Montserrat", 15F);
            entrada_cliente.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_cliente.Location = new Point(84, 258);
            entrada_cliente.Name = "entrada_cliente";
            entrada_cliente.Size = new Size(319, 25);
            entrada_cliente.TabIndex = 119;
            entrada_cliente.Text = "Gaston";
            entrada_cliente.Enter += TodasLasEntradasNormales_Enter;
            entrada_cliente.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_entrada
            // 
            etiqueta_entrada.Anchor = AnchorStyles.Top;
            etiqueta_entrada.AutoSize = true;
            etiqueta_entrada.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_entrada.ForeColor = Color.White;
            etiqueta_entrada.Location = new Point(474, 368);
            etiqueta_entrada.Name = "etiqueta_entrada";
            etiqueta_entrada.Size = new Size(341, 27);
            etiqueta_entrada.TabIndex = 131;
            etiqueta_entrada.Text = "Funcionalidades importantes";
            // 
            // etiqueta_tipo
            // 
            etiqueta_tipo.Anchor = AnchorStyles.Top;
            etiqueta_tipo.AutoSize = true;
            etiqueta_tipo.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_tipo.ForeColor = Color.White;
            etiqueta_tipo.Location = new Point(84, 668);
            etiqueta_tipo.Name = "etiqueta_tipo";
            etiqueta_tipo.Size = new Size(199, 27);
            etiqueta_tipo.TabIndex = 129;
            etiqueta_tipo.Text = "Tipo de proyecto";
            etiqueta_tipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_cobro
            // 
            etiqueta_cobro.Anchor = AnchorStyles.Top;
            etiqueta_cobro.AutoSize = true;
            etiqueta_cobro.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_cobro.ForeColor = Color.White;
            etiqueta_cobro.Location = new Point(474, 645);
            etiqueta_cobro.Name = "etiqueta_cobro";
            etiqueta_cobro.Size = new Size(192, 27);
            etiqueta_cobro.TabIndex = 127;
            etiqueta_cobro.Text = "Pago del cliente";
            // 
            // etiqueta_precio
            // 
            etiqueta_precio.Anchor = AnchorStyles.Top;
            etiqueta_precio.AutoSize = true;
            etiqueta_precio.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_precio.ForeColor = Color.White;
            etiqueta_precio.Location = new Point(474, 575);
            etiqueta_precio.Name = "etiqueta_precio";
            etiqueta_precio.Size = new Size(82, 27);
            etiqueta_precio.TabIndex = 124;
            etiqueta_precio.Text = "Precio";
            // 
            // etiqueta_entrega
            // 
            etiqueta_entrega.Anchor = AnchorStyles.Top;
            etiqueta_entrega.AutoSize = true;
            etiqueta_entrega.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_entrega.ForeColor = Color.White;
            etiqueta_entrega.Location = new Point(474, 298);
            etiqueta_entrega.Name = "etiqueta_entrega";
            etiqueta_entrega.Size = new Size(315, 27);
            etiqueta_entrega.TabIndex = 122;
            etiqueta_entrega.Text = "Fecha estimada de entrega";
            // 
            // etiqueta_inicio
            // 
            etiqueta_inicio.Anchor = AnchorStyles.Top;
            etiqueta_inicio.AutoSize = true;
            etiqueta_inicio.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_inicio.ForeColor = Color.White;
            etiqueta_inicio.Location = new Point(474, 228);
            etiqueta_inicio.Name = "etiqueta_inicio";
            etiqueta_inicio.Size = new Size(181, 27);
            etiqueta_inicio.TabIndex = 120;
            etiqueta_inicio.Text = "Fecha de inicio";
            // 
            // etiqueta_descripcion
            // 
            etiqueta_descripcion.Anchor = AnchorStyles.Top;
            etiqueta_descripcion.AutoSize = true;
            etiqueta_descripcion.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_descripcion.ForeColor = Color.White;
            etiqueta_descripcion.ImageAlign = ContentAlignment.MiddleLeft;
            etiqueta_descripcion.Location = new Point(84, 368);
            etiqueta_descripcion.Name = "etiqueta_descripcion";
            etiqueta_descripcion.Size = new Size(290, 27);
            etiqueta_descripcion.TabIndex = 118;
            etiqueta_descripcion.Text = "Descripcion del proyecto";
            etiqueta_descripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_proyecto
            // 
            etiqueta_proyecto.Anchor = AnchorStyles.Top;
            etiqueta_proyecto.AutoSize = true;
            etiqueta_proyecto.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            etiqueta_proyecto.ForeColor = Color.White;
            etiqueta_proyecto.Location = new Point(84, 298);
            etiqueta_proyecto.Name = "etiqueta_proyecto";
            etiqueta_proyecto.Size = new Size(247, 27);
            etiqueta_proyecto.TabIndex = 117;
            etiqueta_proyecto.Text = "Nombre del proyecto";
            etiqueta_proyecto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // etiqueta_cliente
            // 
            etiqueta_cliente.Anchor = AnchorStyles.Top;
            etiqueta_cliente.AutoSize = true;
            etiqueta_cliente.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_cliente.ForeColor = Color.White;
            etiqueta_cliente.Location = new Point(84, 228);
            etiqueta_cliente.Name = "etiqueta_cliente";
            etiqueta_cliente.Size = new Size(225, 27);
            etiqueta_cliente.TabIndex = 135;
            etiqueta_cliente.Text = "Nombre del cliente";
            etiqueta_cliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titulo_editar
            // 
            titulo_editar.Anchor = AnchorStyles.Top;
            titulo_editar.AutoSize = true;
            titulo_editar.Font = new Font("Montserrat SemiBold", 25.25F, FontStyle.Bold);
            titulo_editar.ForeColor = Color.White;
            titulo_editar.Location = new Point(281, 9);
            titulo_editar.Name = "titulo_editar";
            titulo_editar.Size = new Size(286, 47);
            titulo_editar.TabIndex = 146;
            titulo_editar.Text = "Editar proyecto";
            // 
            // linea_id
            // 
            linea_id.Anchor = AnchorStyles.Top;
            linea_id.BackColor = Color.FromArgb(255, 149, 0);
            linea_id.Enabled = false;
            linea_id.Location = new Point(84, 144);
            linea_id.Margin = new Padding(3, 3, 3, 30);
            linea_id.Name = "linea_id";
            linea_id.Size = new Size(319, 1);
            linea_id.TabIndex = 148;
            // 
            // entrada_id
            // 
            entrada_id.Anchor = AnchorStyles.Top;
            entrada_id.BackColor = Color.FromArgb(0, 0, 32);
            entrada_id.BorderStyle = BorderStyle.None;
            entrada_id.Font = new Font("Montserrat", 15F);
            entrada_id.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_id.Location = new Point(84, 113);
            entrada_id.Name = "entrada_id";
            entrada_id.Size = new Size(319, 25);
            entrada_id.TabIndex = 147;
            entrada_id.Text = "7";
            entrada_id.Enter += TodasLasEntradasNormales_Enter;
            entrada_id.Leave += TodasLasEntradasNormales_Leave;
            // 
            // etiqueta_buscar
            // 
            etiqueta_buscar.Anchor = AnchorStyles.Top;
            etiqueta_buscar.AutoSize = true;
            etiqueta_buscar.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etiqueta_buscar.ForeColor = Color.White;
            etiqueta_buscar.Location = new Point(84, 83);
            etiqueta_buscar.Name = "etiqueta_buscar";
            etiqueta_buscar.Size = new Size(58, 27);
            etiqueta_buscar.TabIndex = 149;
            etiqueta_buscar.Text = "#ID:";
            etiqueta_buscar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // boton_confirmar
            // 
            boton_confirmar.Anchor = AnchorStyles.Top;
            boton_confirmar.BackColor = Color.FromArgb(242, 225, 199);
            boton_confirmar.Cursor = Cursors.Hand;
            boton_confirmar.FlatAppearance.BorderSize = 0;
            boton_confirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 109, 0);
            boton_confirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 149, 0);
            boton_confirmar.FlatStyle = FlatStyle.Flat;
            boton_confirmar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold);
            boton_confirmar.ForeColor = Color.FromArgb(0, 0, 23);
            boton_confirmar.Location = new Point(84, 771);
            boton_confirmar.Margin = new Padding(3, 3, 3, 20);
            boton_confirmar.Name = "boton_confirmar";
            boton_confirmar.Size = new Size(319, 40);
            boton_confirmar.TabIndex = 152;
            boton_confirmar.Text = "Confirmar cambios";
            boton_confirmar.UseVisualStyleBackColor = false;
            // 
            // boton_vaciar
            // 
            boton_vaciar.Anchor = AnchorStyles.Top;
            boton_vaciar.BackColor = Color.FromArgb(242, 225, 199);
            boton_vaciar.Cursor = Cursors.Hand;
            boton_vaciar.FlatAppearance.BorderSize = 0;
            boton_vaciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 109, 0);
            boton_vaciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 149, 0);
            boton_vaciar.FlatStyle = FlatStyle.Flat;
            boton_vaciar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold);
            boton_vaciar.ForeColor = Color.FromArgb(0, 0, 23);
            boton_vaciar.Location = new Point(474, 771);
            boton_vaciar.Margin = new Padding(3, 3, 3, 20);
            boton_vaciar.Name = "boton_vaciar";
            boton_vaciar.Size = new Size(319, 40);
            boton_vaciar.TabIndex = 153;
            boton_vaciar.Text = "Vaciar datos";
            boton_vaciar.UseVisualStyleBackColor = false;
            // 
            // boton_buscar
            // 
            boton_buscar.Anchor = AnchorStyles.Top;
            boton_buscar.BackColor = Color.FromArgb(242, 225, 199);
            boton_buscar.Cursor = Cursors.Hand;
            boton_buscar.FlatAppearance.BorderSize = 0;
            boton_buscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 109, 0);
            boton_buscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 149, 0);
            boton_buscar.FlatStyle = FlatStyle.Flat;
            boton_buscar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_buscar.ForeColor = Color.FromArgb(0, 0, 23);
            boton_buscar.Location = new Point(497, 105);
            boton_buscar.Margin = new Padding(3, 3, 3, 30);
            boton_buscar.Name = "boton_buscar";
            boton_buscar.Size = new Size(319, 40);
            boton_buscar.TabIndex = 154;
            boton_buscar.Text = "Buscar";
            boton_buscar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 176);
            label2.Name = "label2";
            label2.Size = new Size(268, 27);
            label2.TabIndex = 155;
            label2.Text = "Proyecto seleccionado:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(358, 176);
            label3.Name = "label3";
            label3.Size = new Size(110, 27);
            label3.TabIndex = 156;
            label3.Text = "Ninguno";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_pie
            // 
            panel_pie.Dock = DockStyle.Bottom;
            panel_pie.Location = new Point(0, 811);
            panel_pie.Name = "panel_pie";
            panel_pie.Size = new Size(997, 52);
            panel_pie.TabIndex = 157;
            // 
            // EditarProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 0, 32);
            ClientSize = new Size(1014, 811);
            Controls.Add(panel_pie);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(boton_buscar);
            Controls.Add(boton_vaciar);
            Controls.Add(boton_confirmar);
            Controls.Add(etiqueta_buscar);
            Controls.Add(linea_id);
            Controls.Add(entrada_id);
            Controls.Add(titulo_editar);
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
            Name = "EditarProyecto";
            Text = "EditarProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel linea_pago;
        private TextBox entrada_pago;
        private Panel linea_precio;
        private TextBox entrada_precio;
        private Panel linea_inf_funciones;
        private Panel linea_sup_funciones;
        private RichTextBox entrada_funciones;
        private Panel linea_entrega;
        private TextBox entrada_entrega;
        private Panel linea_inicio;
        private TextBox entrada_inicio;
        private ComboBox entrada_tipo;
        private Panel linea_tipo;
        private Panel linea_descripcion2;
        private Panel linea_descripcion;
        private RichTextBox entrada_descripcion;
        private Panel linea_proyecto;
        private TextBox entrada_proyecto;
        private Panel linea_cliente;
        private TextBox entrada_cliente;
        private Label etiqueta_entrada;
        private Label etiqueta_tipo;
        private Label etiqueta_cobro;
        private Label etiqueta_precio;
        private Label etiqueta_entrega;
        private Label etiqueta_inicio;
        private Label etiqueta_descripcion;
        private Label etiqueta_proyecto;
        private Label etiqueta_cliente;
        private Label titulo_editar;
        private Panel linea_id;
        private TextBox entrada_id;
        private Label etiqueta_buscar;
        private ComboBox comboBox1;
        private Label label1;
        private Button boton_confirmar;
        private Button boton_vaciar;
        private Button boton_buscar;
        private Label label2;
        private Label label3;
        private Panel panel_pie;
    }
}