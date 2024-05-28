using aptruc.Modèles;
//using Bumptech.Glide.Util;
//using MainPage.xaml.cs;

namespace aptruc.Vues;

public partial class offres_spéciales : ContentPage
{
	public offres_spéciales()
	{
        offres lundifolies = new offres(1, "lundi folies", "le lundi c'est le retour des cours c'est bien embettant, alors SLAM burger vous propose -20% sur tout ses produits", "Lundi");
        offres mardifris = new offres(2, "mardi frits", "le mardi pour bien commencer la journée SLAM burger vous propose un mardi où les frites sont a -50%", "Mardi");
        offres Vendredifinis = new offres(3, "vendredi la semaine est finie", "vendredi la semainne se fini, alors pour finir en beauté -30% sur tout nos produits", "Vendredi");
        string nomJour = DateTime.Now.ToString("dddd");
        offres Journée = new offres(4, "Rien aujourd'hui", "aujourd'hui aucune offre prticulière revenez demain !", DateTime.Now.ToString("dddd"));

        switch (nomJour)
        {
            case "Lundi":
                Journée.Jour = lundifolies.Jour;
                Journée.Description = lundifolies.Description;
                Journée.Id = lundifolies.Id;
                Journée.Name = lundifolies.Name;
                break;
            case "Mardi":
                Journée.Jour = mardifris.Jour;
                Journée.Description = mardifris.Description;
                Journée.Id = mardifris.Id;
                Journée.Name = mardifris.Name;
                break;
            case "Vendredi":
                Journée.Jour = Vendredifinis.Jour;
                Journée.Description = Vendredifinis.Description;
                Journée.Id = Vendredifinis.Id;
                Journée.Name = Vendredifinis.Name;
                break;
            default:
                break;
        }
        InitializeComponent();
        string Descr = Journée.Description;
        string Jourajd = DateTime.Now.ToString("dddd");
        int pt = 7; 


    }
}