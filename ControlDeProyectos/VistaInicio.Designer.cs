namespace ControlDeProyectos
{
    partial class VistaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaInicio));
            menu_lateral = new Panel();
            panel1 = new Panel();
            panelSubMenuAdministrar = new Panel();
            boton_error = new Button();
            boton_editar = new Button();
            boton_agregar = new Button();
            boton_administrar = new Button();
            panelSubMenuLogo = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lineaDivisoria = new Panel();
            panelHijo = new Panel();
            pictureBox1 = new PictureBox();
            menu_lateral.SuspendLayout();
            panelSubMenuAdministrar.SuspendLayout();
            panelSubMenuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menu_lateral
            // 
            menu_lateral.AutoScroll = true;
            menu_lateral.BackColor = Color.FromArgb(0, 0, 16);
            menu_lateral.Controls.Add(panel1);
            menu_lateral.Controls.Add(panelSubMenuAdministrar);
            menu_lateral.Controls.Add(boton_administrar);
            menu_lateral.Controls.Add(panelSubMenuLogo);
            menu_lateral.Dock = DockStyle.Left;
            menu_lateral.Location = new Point(0, 0);
            menu_lateral.Name = "menu_lateral";
            menu_lateral.Size = new Size(250, 811);
            menu_lateral.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 149, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 4;
            // 
            // panelSubMenuAdministrar
            // 
            panelSubMenuAdministrar.BackColor = Color.FromArgb(0, 0, 25);
            panelSubMenuAdministrar.Controls.Add(boton_error);
            panelSubMenuAdministrar.Controls.Add(boton_editar);
            panelSubMenuAdministrar.Controls.Add(boton_agregar);
            panelSubMenuAdministrar.Dock = DockStyle.Top;
            panelSubMenuAdministrar.Location = new Point(0, 156);
            panelSubMenuAdministrar.Name = "panelSubMenuAdministrar";
            panelSubMenuAdministrar.Size = new Size(250, 123);
            panelSubMenuAdministrar.TabIndex = 2;
            // 
            // boton_error
            // 
            boton_error.Cursor = Cursors.Hand;
            boton_error.Dock = DockStyle.Top;
            boton_error.FlatAppearance.BorderSize = 0;
            boton_error.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 109, 0);
            boton_error.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 149, 0);
            boton_error.FlatStyle = FlatStyle.Flat;
            boton_error.ForeColor = Color.White;
            boton_error.Location = new Point(0, 80);
            boton_error.Name = "boton_error";
            boton_error.Padding = new Padding(35, 0, 0, 0);
            boton_error.Size = new Size(250, 40);
            boton_error.TabIndex = 7;
            boton_error.Text = "Registrar error";
            boton_error.TextAlign = ContentAlignment.MiddleLeft;
            boton_error.UseVisualStyleBackColor = true;
            boton_error.Click += boton_error_Click;
            // 
            // boton_editar
            // 
            boton_editar.Cursor = Cursors.Hand;
            boton_editar.Dock = DockStyle.Top;
            boton_editar.FlatAppearance.BorderSize = 0;
            boton_editar.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 109, 0);
            boton_editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 149, 0);
            boton_editar.FlatStyle = FlatStyle.Flat;
            boton_editar.ForeColor = Color.White;
            boton_editar.Location = new Point(0, 40);
            boton_editar.Name = "boton_editar";
            boton_editar.Padding = new Padding(35, 0, 0, 0);
            boton_editar.Size = new Size(250, 40);
            boton_editar.TabIndex = 6;
            boton_editar.Text = "Editar proyecto";
            boton_editar.TextAlign = ContentAlignment.MiddleLeft;
            boton_editar.UseVisualStyleBackColor = true;
            boton_editar.Click += boton_editar_Click;
            // 
            // boton_agregar
            // 
            boton_agregar.Cursor = Cursors.Hand;
            boton_agregar.Dock = DockStyle.Top;
            boton_agregar.FlatAppearance.BorderSize = 0;
            boton_agregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 109, 0);
            boton_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 149, 0);
            boton_agregar.FlatStyle = FlatStyle.Flat;
            boton_agregar.ForeColor = Color.White;
            boton_agregar.Location = new Point(0, 0);
            boton_agregar.Name = "boton_agregar";
            boton_agregar.Padding = new Padding(35, 0, 0, 0);
            boton_agregar.Size = new Size(250, 40);
            boton_agregar.TabIndex = 5;
            boton_agregar.Text = "Agregar proyecto";
            boton_agregar.TextAlign = ContentAlignment.MiddleLeft;
            boton_agregar.UseVisualStyleBackColor = true;
            boton_agregar.Click += boton_agregar_Click;
            // 
            // boton_administrar
            // 
            boton_administrar.Cursor = Cursors.Hand;
            boton_administrar.Dock = DockStyle.Top;
            boton_administrar.FlatAppearance.BorderSize = 0;
            boton_administrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 109, 0);
            boton_administrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 149, 0);
            boton_administrar.FlatStyle = FlatStyle.Flat;
            boton_administrar.ForeColor = Color.White;
            boton_administrar.Location = new Point(0, 111);
            boton_administrar.Name = "boton_administrar";
            boton_administrar.Padding = new Padding(10, 0, 0, 0);
            boton_administrar.Size = new Size(250, 45);
            boton_administrar.TabIndex = 4;
            boton_administrar.Text = "Administrar";
            boton_administrar.TextAlign = ContentAlignment.MiddleLeft;
            boton_administrar.UseVisualStyleBackColor = true;
            boton_administrar.Click += boton_administrar_Click;
            // 
            // panelSubMenuLogo
            // 
            panelSubMenuLogo.Controls.Add(pictureBox2);
            panelSubMenuLogo.Controls.Add(label1);
            panelSubMenuLogo.Controls.Add(lineaDivisoria);
            panelSubMenuLogo.Dock = DockStyle.Top;
            panelSubMenuLogo.Location = new Point(0, 0);
            panelSubMenuLogo.Name = "panelSubMenuLogo";
            panelSubMenuLogo.Size = new Size(250, 111);
            panelSubMenuLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 30);
            label1.Name = "label1";
            label1.Size = new Size(168, 55);
            label1.TabIndex = 4;
            label1.Text = "Muoqa";
            // 
            // lineaDivisoria
            // 
            lineaDivisoria.BackColor = Color.FromArgb(255, 149, 0);
            lineaDivisoria.Dock = DockStyle.Bottom;
            lineaDivisoria.Location = new Point(0, 110);
            lineaDivisoria.Name = "lineaDivisoria";
            lineaDivisoria.Size = new Size(250, 1);
            lineaDivisoria.TabIndex = 3;
            // 
            // panelHijo
            // 
            panelHijo.BackColor = Color.FromArgb(0, 0, 32);
            panelHijo.Controls.Add(pictureBox1);
            panelHijo.Dock = DockStyle.Fill;
            panelHijo.Location = new Point(250, 0);
            panelHijo.Name = "panelHijo";
            panelHijo.Size = new Size(1014, 811);
            panelHijo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(314, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // VistaInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 811);
            Controls.Add(panelHijo);
            Controls.Add(menu_lateral);
            Font = new Font("Montserrat", 10F);
            MinimumSize = new Size(1100, 750);
            Name = "VistaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaInicio";
            menu_lateral.ResumeLayout(false);
            panelSubMenuAdministrar.ResumeLayout(false);
            panelSubMenuLogo.ResumeLayout(false);
            panelSubMenuLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu_lateral;
        private Button boton_administrar;
        private Panel panelSubMenuLogo;
        private Panel panelSubMenuAdministrar;
        private Button boton_editar;
        private Button boton_agregar;
        private Button boton_error;
        private Panel panelHijo;
        private Panel lineaDivisoria;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}