namespace Gasolinera;
///<Summary>
///<Createddate>2023/06/30</Createddate>
///<company>SandBox</company>
///<lastmodificationdate>2023/07/01</lastmodificationdate>
///<lastmodificationdescription>
///Agregar la documentacion y la imagen
///</lastmodificationdescription>
///<lastmodifierautor>Lorena Vasquez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{ 
/// <summary>
/// constructor de la clase
/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		///multiplicaremos galo(o sea los galones) x 3.78541, para luego imprimir el resultado con lit,
		///en litros, si el campo esta vacio se enviara un mensaje de error
		if (!string.IsNullOrEmpty(Gal.Text))
		{
			double galo, Lit;
			galo=Convert.ToDouble(Gal.Text);

			Lit = galo * 3.78541;
			litro.Text = Lit.ToString("N2");
		}
		else
		{
			DisplayAlert("ERROR", "Es necesario ingresar los datos","Oki DOki Yo");
		}


	}
}

