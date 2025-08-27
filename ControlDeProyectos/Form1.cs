using System.Drawing;
using System.Runtime.InteropServices;
namespace ControlDeProyectos
{
    public partial class autenticacion_principal : Form
    {
        public autenticacion_principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void AutenticacionPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void entrada_usuario_Enter(object sender, EventArgs e)
        {
            if (entrada_usuario.Text == "USUARIO")
            {
                entrada_usuario.Text = "";
                entrada_usuario.ForeColor = Color.White;
            }
        }
        private void entrada_usuario_Leave(object sender, EventArgs e)
        {
            if (entrada_usuario.Text == "")
            {
                entrada_usuario.Text = "USUARIO";
                entrada_usuario.ForeColor = Color.FromArgb(144, 144, 144);
            }
        }
        private void entrada_pass_Enter(object sender, EventArgs e)
        {
            if (entrada_pass.Text == "CONTRASEÑA")
            {
                entrada_pass.Text = "";
                entrada_pass.ForeColor = Color.White;
                entrada_pass.UseSystemPasswordChar = true;
            }
        }
        private void entrada_pass_Leave(object sender, EventArgs e)
        {
            if (entrada_pass.Text == "")
            {
                entrada_pass.Text = "CONTRASEÑA";
                entrada_pass.ForeColor = Color.FromArgb(144, 144, 144);
                entrada_pass.UseSystemPasswordChar = false;
            }
        }
        private void cerrar_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizar_app_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void autenticacion_principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
