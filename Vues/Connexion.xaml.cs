using Microsoft.Maui.Controls;
using System.Text.Json;
using Microsoft.Maui.Controls;
using System.Text.Json;
using System.Text;
using aptruc.Vues;
using Android.Telecom;
namespace aptruc.Vues;

public partial class Connexion : ContentPage
{
    public Connexion()
    {
        InitializeComponent();

    }
        public readonly HttpClient _httpClient = new HttpClient();

    private async Task ConnexionUtilisateur()
    {
        try
        {
            var COnnexionnRequest = new
            {
                email = EntryEmail.Text,    
                password = EntryMdp.Text
            };

            var jsonRequest = JsonSerializer.Serialize(inscriptionRequest);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("http://172.17.0.62:8082/api/mobile/GetConnexion", content);

            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Reussite", "Connexion réalisé", "OK");
            }
            else
            {
                await DisplayAlert("Erreur", "Erreur lors de la connexion", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
        }
    }
}