namespace calcul_de_nomina
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Restablecer todos los TextBoxes a 0
			textBoxNombre.Text = "0";
			textBoxHorasTrabajadas.Text = "0";
			textBoxHorasExtras.Text = "0";
			textBoxSalarioBruto.Text = "0";
			textBoxImpuesto.Text = "0";
			textBoxSalarioNeto.Text = "0";

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Inicializar TextBoxes con valor 0 al cargar el formulario
			textBoxNombre.Text = "0";
			textBoxHorasTrabajadas.Text = "0";
			textBoxHorasExtras.Text = "0";
			textBoxSalarioBruto.Text = "0";
			textBoxImpuesto.Text = "0";
			textBoxSalarioNeto.Text = "0";

		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Mostrar mensaje de confirmación personalizado antes de cerrar la aplicación
			MessageBox.Show($"{textBoxNombre.Text} ha elegido salir de la aplicación.", "Confirmación de Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void textBoxSalarioBruto_TextChanged(object sender, EventArgs e)
		{


		}

		private void textBoxSalarioNeto_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			
			
		

			// Calcular el salario bruto
			double costoHora = 10; // Costo de la hora (valor de ejemplo)
			double horasTrabajadas = Convert.ToDouble(textBoxHorasTrabajadas.Text);
			double horasExtras = Convert.ToDouble(textBoxHorasExtras.Text);
			double salarioBruto = (costoHora * horasTrabajadas) + ((costoHora * 2) * horasExtras);

			// Calcular el impuesto (valor fijo)
			double impuesto = salarioBruto * 0.2; // 20% de impuesto (valor de ejemplo)

			// Calcular el salario neto
			double salarioNeto = salarioBruto - impuesto;

			// Mostrar resultados en TextBoxes
			textBoxSalarioBruto.Text = salarioBruto.ToString("0.00");
			textBoxImpuesto.Text = impuesto.ToString("0.00");
			textBoxSalarioNeto.Text = salarioNeto.ToString("0.00");

			
			
		}





	}
}
