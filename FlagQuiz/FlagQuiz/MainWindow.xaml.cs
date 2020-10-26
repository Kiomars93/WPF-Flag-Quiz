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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlagQuiz
{
    public partial class MainWindow : Window
    {
        Frame frame;
        public MainWindow()
        {
            InitializeComponent();
            Start();

            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //frame.NavigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
            frame.NavigationService.Navigate(new Page1());
        }

        private void Start()
        {
            // Window options
            Title = "GUI App";
            Width = 400;
            Height = 300;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            // Scrolling
            ScrollViewer root = new ScrollViewer();
            root.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            Content = root;

            // Main grid
            Grid grid = new Grid();
            root.Content = grid;
            grid.Margin = new Thickness(5);
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            frame = new Frame
            {
                Content = "Frame in da brain",
                NavigationUIVisibility = NavigationUIVisibility.Hidden
            };
            grid.Children.Add(frame);
        }
    }
}
