using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Harita
{
    public partial class MainWindow : Window
    {
        private readonly Veri veri;

        public MainWindow()
        {
            InitializeComponent();
            veri = new Veri();
        }

        private void Document_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AddHandler(MouseLeftButtonUpEvent, new RoutedEventHandler(Tıkla));
        }

        private void Tıkla(object x, RoutedEventArgs e)
        {
            if (!(e.OriginalSource is Path))
            {
                _ = MessageBox.Show("İllerin Üzerine Tıklayın.");
                return;
            }
            if (e.OriginalSource is Path p && tbilismi.Text == p.Name)
            {
                _ = MessageBox.Show("Tebrikler Bildin.");
                p.Visibility = Visibility.Collapsed;
                _ = Veri.iller.Remove(p.Name);
                if (Veri.iller.Count > 0)
                {
                    Veri.Yeniİl(this);
                }
                else
                {
                    _ = MessageBox.Show("Bitti.");
                }
            }
            else
            {
                _ = MessageBox.Show("Cevap Yanlış.");
            }

            e.Handled = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Veri.Yeniİl(this);
        }
    }
}