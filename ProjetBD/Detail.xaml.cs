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
    public partial class Detail : Window
    {
        public Detail(Album selectedAlbum)
        {
            InitializeComponent();
            NomAlbum.Text = selectedAlbum.Titre_Album;
            AlbumImage.Source = ImageConverter.ByteToImage(selectedAlbum.Pochette);
            Fournisseur f = new Fournisseur();
            LMorceaux.ItemsSource = f.GetEnregistrements(selectedAlbum.Code_Album);
        }
    }
}
