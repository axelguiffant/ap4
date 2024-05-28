using Microsoft.Maui.Controls;
using System.Text.Json;
using System.Text;
using aptruc.Vues;
using Android.Telecom;

namespace aptruc;

public partial class inscription : ContentPage
{
    public inscription()
    {
        InitializeComponent();
        _client = new HttpClient();
    }
    private async void TentativeInscription(object sender, EventArgs e)
    {
        await InscrireUtilisateur();
    }
    private async void Onconnecterclick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Connection());
    }
    private async Task InscrireUtilisateur()
    {
        try
        {
            var inscriptionRequest = new
            {
                email = EntryEmail.Text,
                nom = EntryNom.Text,
                prenom = EntryPrenom.Text,
                password = EntryMdp.Text,
                telephone = EntryTel.Text,
                datenaissance = EntryDateNaissance.Text
            };

            var jsonRequest = JsonSerializer.Serialize(inscriptionRequest);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("http://172.17.0.62:8082/api/mobile/setInscription", content);

            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Reussite", "Inscription réalisé", "OK");
            }
            else
            {
                await DisplayAlert("Erreur", "Erreur lors de l'inscription", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
        }
    }
}