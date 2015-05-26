using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ProjetBD
{
    class ImageConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            if (value != null && value is byte[])
            {
                MemoryStream stream = new MemoryStream((byte []) value);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = stream;
                image.EndInit();
                return image;
            }
            if (value == null)
            {
                BitmapImage image = new BitmapImage();
                // On affiche "pas d'image"
                return image;
            }
            return null;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            throw new Exception("Pas encore implémenté");
        }
    }
}
