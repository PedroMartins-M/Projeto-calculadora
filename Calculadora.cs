namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void lblnumero2_Click(object sender, EventArgs e)
        {

        }

        private void bpnsomar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtnumero1.Text);
            double numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = (numero1 + numero2).ToString();
        }
    }
}
