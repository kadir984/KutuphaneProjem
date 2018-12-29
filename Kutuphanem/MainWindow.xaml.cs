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
using KutuphanemLib;

namespace Kutuphanem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Category> categories = new List<Category>();
        private void BtnAddCategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(tbCategoryId.Text);
                category.Name = (tbCategoryName.Text);
                categories.Add(category);
                DgCategoryDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void DgCategoryDoldur()
        {
            dgCategory.ItemsSource = null;
            dgCategory.ItemsSource = categories;

        }

        private void BtnAddAuthor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddBook_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
