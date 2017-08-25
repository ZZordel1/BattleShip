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
using ZordelZ_BattleShip.Model;
using ZordelZ_BattleShip.Conversion;

namespace ZordelZ_BattleShip
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Cell[,] cell;
        public GameWindow()
        {
            InitializeComponent();
            createGrid(10, 10);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Saving... Saved!");
        }

        public void createGrid(int width, int height)
        {
            if (Board != null)
            {
                Board.Children.Clear();
                width = 10;
                height = 10;

                Board.Columns = width;
                Board.Rows = height;

                cell = new Cell[height, width];


                for (int i = 0; i < Board.Rows; i++)
                {
                    for (int j = 0; j < Board.Columns; j++)
                    {
                        cell[i, j] = new Cell();
                        Rectangle rec = new Rectangle();
                        rec.Width = 35;
                        rec.Height = 35;
                        rec.DataContext = cell[i, j];
                        rec.MouseLeftButtonDown += cell[i, j].Clicked;
                        Binding cellState = new Binding("State");
                        cellState.Source = cell[i, j];
                        cellState.Mode = BindingMode.OneWay;
                        cellState.Converter = (EnumToColor)Application.Current.FindResource("colorChanger");
                        rec.SetBinding(Rectangle.FillProperty, cellState);
                        Board.Children.Add(rec);
                    }
                }
            }
        }
    }
}
