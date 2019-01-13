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
    public class Dbislem
    {

        SqlConnection baglanti = new SqlConnection(@"Server=X870\SQLEXPRESS;Database=Kutuphanem;Integrated Security=True;");

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

        public void Ekle(string dbtabloadi,string dbkolon,string dbdeger)
        {
            Baglan();
            string ekleString = "INSERT INTO "+dbtabloadi+"("+dbkolon+") VALUES('"+dbdeger+"')";
            SqlCommand eklesql = new SqlCommand(ekleString, baglanti);
            int etkilenensatirsayisi = eklesql.ExecuteNonQuery();
            baglanti.Close();

            if (etkilenensatirsayisi!=0)
            {
                MessageBox.Show("Etkilenen satır sayısı =" + etkilenensatirsayisi );
            }
            else
            {
                MessageBox.Show("Veritabanını kontrol et.");
            };
        }

        public void Duzelt(string dbtabloadi, string dbkolonadi,string dbkolondeger, string id)
        {
            Baglan();
            string duzeltString = "UPDATE "+dbtabloadi+" SET "+dbkolonadi+"=('"+dbkolondeger+"') WHERE id =('"+id+"')";
            SqlCommand duzeltsql = new SqlCommand(duzeltString, baglanti);
            duzeltsql.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil(string dbtabloadi,string id)
        {
            Baglan();
            string silString = "DELETE FROM "+dbtabloadi+" WHERE id =('" + id + "')";
            SqlCommand silsql = new SqlCommand(silString, baglanti);
            silsql.ExecuteNonQuery();
            baglanti.Close();
        }

        public void ara(string dbtabloadi, string id)// Datagrid eklenmeli 
        {
            Baglan();
            string araString = "SELECT  FROM " + dbtabloadi + " WHERE id =('" + id + "')";
            SqlCommand arasql = new SqlCommand(araString, baglanti);
            SqlDataAdapter sqlData = new SqlDataAdapter(arasql);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            //DataGrid.datasource = dt;
            baglanti.Close();
        }

    }
}
