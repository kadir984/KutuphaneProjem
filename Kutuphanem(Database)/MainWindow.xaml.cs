using System;
using System.Collections;
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
using Kutuphanem_Database;
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
        List<Author> authors = new List<Author>();
        List<Book> books = new List<Book>();

        private void BtnAddCategory_Click(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            category.Id = Convert.ToInt32(tbCategoryId.Text);
            category.Name = (tbCategoryName.Text);
            categories.Add(category);
            //DgCategoryDoldur();
            //cbOtoDoldur(cbBookCategoryId,categories);
            OtoDoldur.DgOtoDoldur(dgCategory, categories);
            OtoDoldur.cbOtoDoldur(cbBookCategoryId, categories);

        }
        private void BtnAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            Author author = new Author();
            author.Id= Convert.ToInt32(tbAuthorId.Text);
            author.Name = tbAuthorFirstName.Text;
            author.LastName = tbAuthorLastName.Text;
            author.Country = tbAuthorCountry.Text;
            authors.Add(author);
            //DgAuthorDoldur();
            //cbAuthorDoldur();
            OtoDoldur.DgOtoDoldur(dgAuthor, authors);
            OtoDoldur.cbOtoDoldur(cbBookAuthorId, authors);
        }
        private void BtnAddBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            book.Id = Convert.ToInt32(tbBookId.Text);
            book.CategoryId = ((Category)cbBookCategoryId.SelectedItem).Id;
            book.AuthorId = ((Author)cbBookAuthorId.SelectedItem).Id;
            book.Name = tbBookName.Text;
            book.Isbn = Convert.ToInt32(tbBookIsbn.Text);
            books.Add(book);
            //DgBookDoldur();
            OtoDoldur.DgOtoDoldur(dgBook, books);
        }
        
    }
}
