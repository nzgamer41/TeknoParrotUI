using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeknoParrotUi.Common;
using Path = System.IO.Path;

namespace TeknoParrotUi.Views
{
    /// <summary>
    /// Interaction logic for tenFootLibrary.xaml
    /// </summary>
    public partial class tenFootLibrary : UserControl
    {
        public tenFootLibrary()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //time to get count of games
            int imagesToCreate = GameProfileLoader.UserProfiles.Count;
            for (var i = 0; i < imagesToCreate; i++)
            {
                var iconPath = Path.Combine("Icons", GameProfileLoader.UserProfiles[i].IconName.Split('/')[1]);
                BitmapImage iconimage = new BitmapImage();

                using (var file = File.OpenRead(iconPath))
                {
                    iconimage.BeginInit();
                    iconimage.CacheOption = BitmapCacheOption.OnLoad;
                    iconimage.StreamSource = file;
                    iconimage.EndInit();
                }

                Image newIMG = new Image();
                newIMG.Margin = new System.Windows.Thickness { Left = 6, Top = 5, Right = 6, Bottom = 5 };
                newIMG.Width = 256;
                newIMG.Height = 256;
                newIMG.Source = iconimage;
                stPanel.Children.Add(newIMG);
                //stPanel.
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
