namespace Intro_MAUI.Pages;

public partial class Suma : ContentPage
{
	public Suma()
	{
		InitializeComponent();
	}

    private void btnSumar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Sumar suma = new Sumar();

            if (validarCampos())
            {
                suma.N1 = Double.Parse(txtN1.Text);
                suma.N2 = Double.Parse(txtN2.Text);

                txtResultado.Text = $"La suma es: {suma.Calcular()}";
            }
        } catch(Exception ex) {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtN1.Text = "";
        txtN2.Text = "";
        txtResultado.Text = "";
    }

    private bool validarCampos()
    {
        if (txtN1.Text == null || txtN1.Text == "")
        {
            DisplayAlert("Advertencia", "Primer número en blanco", "Aceptar");
            return false;
        }
        else if (txtN2.Text == null || txtN1.Text == "")
        {
            DisplayAlert("Advertencia", "Segundo número en blanco", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }
    }

}