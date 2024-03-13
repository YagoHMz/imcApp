namespace windows
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        decimal Imc(decimal p, decimal a)
        {
            return p / (a * a);
        }

        string Classificacao(decimal imc)
        {
            double i = (double)imc;
            if (i < 18.6)
                return "Abaixo do peso";
            if (i < 25)
                return "Peso ideal";
            if (i < 30)
                return "Levemente acima do peso";
            if (i < 35)
                return "Obesidade grau 1";
            if (i < 40)
                return "Obesidade grau 2";
            else
                return "Obesidade grau 3";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            decimal peso, altura;



            peso = numPeso.Value;
            altura = numAltura.Value;


            if (altura == 0)
            {
                MessageBox.Show("Bota uma altura válida!");
            }
            else
            {
                decimal imc = Imc(peso, altura);
                calculoText.Text = imc.ToString("0.0");
                classificacaoText.Text = Classificacao(imc);
            }

            pnlResultado.Visible = true;
        }

        private void numAltura_ValueChanged(object sender, EventArgs e)
        {
            if (numAltura.Value == 0)
                btCalcular.Enabled = false;
            else
                btCalcular.Enabled = true;
        }
    }
}
