namespace SegundoParcialElipses.Windows
{
    public partial class frmElipses : Form
    {
        public frmElipses()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var frm = new frmElipsesAE() { Text = "Agregar rectángulo" };
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
        }
    }
}
