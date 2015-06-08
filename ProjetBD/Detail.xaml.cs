using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetBD
{
    /// <summary>
    /// Logique d'interaction pour Detail.xaml
    /// </summary>
    public partial class Detail
    {
        public Detail(Album selectedAlbum)
        {
            InitializeComponent();
            NomAlbum.Text = selectedAlbum.Titre_Album;
            AlbumImage.Source = ImageConverter.ByteToImage(selectedAlbum.Pochette);
            Fournisseur f = new Fournisseur();
            LMorceaux.ItemsSource = f.GetEnregistrements(selectedAlbum.Code_Album);
        }

        private void AcheterButton_Click(object sender, RoutedEventArgs e)
        {
            Abonné acheteur = (Abonné) LAbonnés.SelectedItem;
            Enregistrement enregistrement = (Enregistrement) LMorceaux.SelectedItem;
            if (acheteur != null && enregistrement != null)
            {
                Acheter achat = new Acheter();
                achat.Code_Abonné = acheteur.Code_Abonné;
                achat.Code_Enregistrement = enregistrement.Code_Enregistrement;
                ClassiqueEntities context = new ClassiqueEntities();
                context.Acheter.Add(achat);
                //A revoir, plante
                //context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un abonné et un enregistrement", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
