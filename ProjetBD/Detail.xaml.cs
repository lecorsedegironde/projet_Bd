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
        private readonly Album _selectedAlbum;
        public Detail(Album a)
        {
            InitializeComponent();
            _selectedAlbum = a;
            NomAlbum.Text = _selectedAlbum.Titre_Album;
            AlbumImage.Source = ImageConverter.ByteToImage(_selectedAlbum.Pochette);
            Fournisseur f = new Fournisseur();
            LMorceaux.ItemsSource = f.GetEnregistrements(_selectedAlbum.Code_Album);
        }

        private void AcheterButton_Click(object sender, RoutedEventArgs e)
        {
            Abonné acheteur = (Abonné) LAbonnés.SelectedItem;
            Enregistrement enregistrement = (Enregistrement) LMorceaux.SelectedItem;
            if (acheteur != null && enregistrement != null)
            {
                string messageAchat = "Vous avez acheté " + enregistrement.Titre + " au prix de : " + enregistrement.Prix + "€";
                Acheter achat = new Acheter();
                achat.Code_Abonné = acheteur.Code_Abonné;
                achat.Code_Enregistrement = enregistrement.Code_Enregistrement;
                ClassiqueEntities context = new ClassiqueEntities();
                context.Acheter.Add(achat);
                context.SaveChanges();
                MessageBox.Show(messageAchat, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un abonné et un enregistrement", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EmprunterButton_Click(object sender, RoutedEventArgs e)
        {
            Abonné emprunteur = (Abonné) LAbonnés.SelectedItem;
            if (emprunteur != null)
            {
                string messageEmprunt = "Vous avez emprunté " + _selectedAlbum.Titre_Album + ".";
                Emprunter emprunt = new Emprunter();
                emprunt.Code_Abonné = emprunteur.Code_Abonné;
                emprunt.Code_Album = _selectedAlbum.Code_Album;
                emprunt.Date_Emprunt = DateTime.Now;
                ClassiqueEntities context = new ClassiqueEntities();
                context.Emprunter.Add(emprunt);
                context.SaveChanges();
                MessageBox.Show(messageEmprunt, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un abonné", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
