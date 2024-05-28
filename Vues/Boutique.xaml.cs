using Microsoft.Maui.Controls;
using System.Text.Json;
using Microsoft.Maui.Controls;
using System.Text.Json;
using System.Text;
using aptruc.Vues;
using Android.Telecom;
namespace aptruc.Vues;

public partial class Boutique : ContentPage
{
	public Boutique()
	{
		InitializeComponent();
        LoadProduits();
    }
    private void LoadProduits()
    {
        var response = await _client.PostAsync("http://172.17.0.62:8082//api/mobile/GetAllProduits");
        List <Product> produits = JsonConvert.DeserializeObject<List<Product>>(jsonText);

        ProductListBox.ItemsSource = products;
    }
}