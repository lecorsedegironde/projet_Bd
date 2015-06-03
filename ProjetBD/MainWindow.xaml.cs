using System.Windows;

namespace ProjetBD
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LAlbums_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Album alb = (Album) LAlbums.SelectedItem;
            Detail dt = new Detail();

            dt.Show();
        }

        private void LMusicien_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (LMusicien.SelectedItem == null) return;
            Fournisseur f = new Fournisseur();
            Musicien m = (Musicien) LMusicien.SelectedItem;
            LAlbums.ItemsSource = f.GetAlbums(m.Code_Musicien);
        }
    }
}
