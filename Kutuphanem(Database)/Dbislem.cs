using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace Kutuphanem_Database_
{
    class Dbislem
    {
        SqlConnection baglanti = new SqlConnection(@"Server=.\MANAS_SQLSERVER;Database=Kutuphanem;User ID=sa;Password=123456Aa;");

        public void Baglan()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            else
            {
                MessageBox.Show("Veritabanı bağlantısı zaten açık.");
            }
        }

        public void Ekle(string tablo,string dbdeger)
        {
            baglanti.Open();
            string ekleString = "INSERT INTO "+tablo+"(name) VALUES('" + dbdeger + "')";
            SqlCommand eklesql = new SqlCommand(ekleString, baglanti);
            eklesql.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Duzelt(string dbdeger, string id)
        {
            baglanti.Open();
            string duzeltString = "UPDATE Category SET name=('" + dbdeger + "') WHERE id =('" + id + "')";
            SqlCommand duzeltsql = new SqlCommand(duzeltString, baglanti);
            duzeltsql.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil(string id)
        {
            baglanti.Open();
            string silString = "DELETE FROM Category WHERE id =('" + id + "')";
            SqlCommand silsql = new SqlCommand(silString, baglanti);
            silsql.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
