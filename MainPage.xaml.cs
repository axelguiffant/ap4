using aptruc.Modèles;
using aptruc.Vues;

namespace aptruc;

public partial class MainPage : ContentPage
{

    public Utilisateur UtilisateurCourant = new Utilisateur();

    public MainPage()
	{
		InitializeComponent();
	


    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new inscription());


    }
}

