namespace EjerciciosSemana1
{
    public partial class Form1 : Form
    {
        int intentos = 3;
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conversion = CbConversion.Text;
            float temperatura;
            float resultado = 0;

            if (!float.TryParse(TbTemperatura.Text, out temperatura))
            {
                MessageBox.Show(
                    "Ingrese una temperatura valida.",
                    "Temperatura invalida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (string.IsNullOrEmpty(conversion))
            {
                MessageBox.Show(
                    "Seleccione un tipo de conversión.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            switch (conversion)
            {
                case "Celcius a Farenheit":
                    resultado = (temperatura * 9 / 5) + 32;

                    MessageBox.Show(
                        $"Resultado: {temperatura} °C = {resultado:F2} °F",
                        "Resultado de la conversion.",
                        MessageBoxButtons.OK
                    );
                    break;

                case "Farenheit a Celcius":
                    resultado = (temperatura - 32) * 5 / 9;

                    MessageBox.Show(
                        $"Resultado: {temperatura} °F = {resultado:F2} °C",
                        "Resultado de la conversion.",
                        MessageBoxButtons.OK
                    );
                    break;
            }

        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text;
            string clave = TbContraseña.Text;

            if (usuario == "" || clave == "")
            {
                MessageBox.Show(
                    "El usuario y la clave son campos obligatorios, no pueden estar vacios!!",
                    "Campos Vacios.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (usuario != "admin" || clave != "admin123")
            {
                intentos--;

                if (intentos == 0)
                {
                    MessageBox.Show(
                        "A sobrepasado el limite.",
                        "Limite de intentos sobrepasado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    Close();
                }
                else
                {
                    MessageBox.Show(
                        $"Credenciales incorrectas, vuelve a intentarlo, te quedan {intentos} intentos.",
                        "Credenciales incorrectas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    $"Inicio de sesion exitoso, bienvenido {usuario}.",
                    "Inicio de sesion exitoso.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Close();
            }
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            float altura;
            float peso;
            float imc = 0;

            if (!float.TryParse(TbAltura.Text, out altura))
            {
                MessageBox.Show(
                    "Ingrese un dato valido.",
                    "Dato invalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (altura <= 0)
            {
                MessageBox.Show(
                    "La altura debe ser mayor que 0.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (!float.TryParse(TbPeso.Text, out peso))
            {
                MessageBox.Show(
                    "Ingrese un dato valido.",
                    "Dato invalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (peso <= 0)
            {
                MessageBox.Show(
                    "El peso debe ser mayor que 0.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            imc = peso / (altura * altura);

            string categoria;

            if (imc < 18.5f)
            {
                categoria = "Bajo peso";
            }
            else if (imc < 25f)
            {
                categoria = "Normal";
            }
            else if (imc < 30f)
            {
                categoria = "Sobrepeso";
            }
            else if (imc < 35f)
            {
                categoria = "Obesidad grado I";
            }
            else if (imc < 40f)
            {
                categoria = "Obesidad grado II";
            }
            else
            {
                categoria = "Obesidad grado III";
            }

            MessageBox.Show(
                $"Tu IMC es {imc:F2}\nCategoría: {categoria}",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtClick_Click(object sender, EventArgs e)
        {
            contador++;
            Display.Text = contador.ToString();
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            contador = 0;
            Display.Text = contador.ToString();
        }
    }
}
