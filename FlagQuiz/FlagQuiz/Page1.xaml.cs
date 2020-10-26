using System;
using System.Collections.Generic;
using System.Text;
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
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            // Window options
            Title = "GUI App";
            Width = 400;
            Height = 300;

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

            var testButton = new Button
            {
                Content = "Test Button"
            };
            grid.Children.Add(testButton);

            testButton.Click += ButtonClick;
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }
    }
}
