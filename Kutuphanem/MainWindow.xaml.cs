﻿using System;
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
            DgOtoDoldur(dgCategory, categories);
            cbOtoDoldur(cbBookCategoryId, categories);

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
            DgOtoDoldur(dgAuthor, authors);
            cbOtoDoldur(cbBookAuthorId, authors);
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
            DgOtoDoldur(dgBook, books);
        }
        //#region DgDoldur eski yöntem
        //private void DgCategoryDoldur()
        //{
        //    dgCategory.ItemsSource = null;
        //    dgCategory.ItemsSource = categories;

        //}
        //private void DgAuthorDoldur()
        //{
        //    dgAuthor.ItemsSource = null;
        //    dgAuthor.ItemsSource = authors;

        //}
        //private void DgBookDoldur()
        //{
        //    dgBook.ItemsSource = null;
        //    dgBook.ItemsSource = books;

        //}
        //#endregion
        private void DgOtoDoldur(DataGrid dataGridDoldur ,IEnumerable list)
        {
            dataGridDoldur.ItemsSource = null;
            dataGridDoldur.ItemsSource = list;

        }
        //#region CbDoldur eski yöntem
        //private void cbCategorydoldur()
        //{
        //    cbBookCategoryId.ItemsSource = categories;
        //    cbBookCategoryId.DisplayMemberPath = "Name";
        //    cbBookCategoryId.SelectedIndex = 0;
        //}

        //private void cbAuthorDoldur()
        //{
        //    cbBookAuthorId.ItemsSource = authors;
        //    cbBookAuthorId.DisplayMemberPath = "Name";
        //    cbBookAuthorId.SelectedIndex = 0;
        //}
        //#endregion
        private void cbOtoDoldur(ComboBox comboBoxDoldur,IEnumerable list)
        {
            comboBoxDoldur.ItemsSource = list;
            comboBoxDoldur.DisplayMemberPath = "Name";
            comboBoxDoldur.SelectedIndex = 0;
        }//düzenlenecek
    }
}
