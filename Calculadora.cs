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
           

            if (string.IsNullOrWhiteSpace(txtnumero1.Text))
            {
                MessageBox.Show("O campo está vazio");
            }
            else if (string.IsNullOrWhiteSpace(txtnumero2.Text))
            {
                MessageBox.Show("O campo está vazio");
                return;
            }
            if (!double.TryParse(txtnumero1.Text, out double numero1))
            {
                MessageBox.Show("Preencha o campo com um número.");
                return;

            }
            if (!double.TryParse(txtnumero2.Text, out double numero2)) 
            {
                MessageBox.Show("Preencha o campo com um número.");
                return;

            }

            // double numero1 = Convert.ToDouble(txtnumero1.Text);
            //double numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = (numero1 + numero2).ToString();
        }

        private void bpnsubtrair_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnumero1.Text))
            {
                MessageBox.Show("O campo está vazio");
            }
            else if (string.IsNullOrWhiteSpace(txtnumero2.Text))
            {
                MessageBox.Show("O campo está vazio");
                return;
            }
            if (!double.TryParse(txtnumero1.Text, out double numero1))
            {
                MessageBox.Show("Preencha o campo com um número.");
                return;

            }
            if (!double.TryParse(txtnumero2.Text, out double numero2))
            {
                MessageBox.Show("Preencha o campo com um número.");
                return;

            }

            //double numero1 = Convert.ToDouble(txtnumero1.Text);
           // double numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = (numero1 - numero2).ToString();
        }

        private void bpnmultiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnumero1.Text))
            {
                MessageBox.Show("O campo está vazio");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtnumero2.Text))
            {
                MessageBox.Show("O campo está vazio");
            }
            if (!double.TryParse(txtnumero1.Text, out double numero1))
            {
                MessageBox.Show("Preencha o campo com um número.");
                return;

            }
            if (!double.TryParse(txtnumero2.Text, out double numero2))
            {
                MessageBox.Show("Preencha o campo com um número.");
                return;

            }

            //double numero1 = Convert.ToDouble(txtnumero1.Text);
           // double numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = (numero1 * numero2).ToString();
        }

        private void bpndividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnumero1.Text))
            {
                MessageBox.Show("O campo está vazio");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtnumero2.Text))
            {
                MessageBox.Show("O campo está vazio");
                return;
            }
            if (!double.TryParse(txtnumero1.Text, out double numero1))
            {
                MessageBox.Show("Preencha o campo com um número.");
                return;

            }
            if (!double.TryParse(txtnumero2.Text, out double numero2))
            {
                MessageBox.Show("Preencha o campo com um número.");
                return;

            }

            //double numero1 = Convert.ToDouble(txtnumero1.Text);
            //double numero2 = Convert.ToDouble(txtnumero2.Text);

            lblresultado.Text = (numero1 / numero2).ToString();
        }

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {
         

        }
    }
}
