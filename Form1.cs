namespace MiAppWinforms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSumar_Click(object sender, EventArgs e)
    {
        if (double.TryParse(txtNum1.Text, out double n1) && double.TryParse(txtNum2.Text, out double n2))
        {
            double res = n1 + n2;
            lblResultado.Text = "Resultado: " + res.ToString();
        }
        else
        {
            lblResultado.Text = "Ingrese números válidos";
        }
    }
}