using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kutuphanem_Database
{
    public static class OtoDoldur
    {
        public static void DgOtoDoldur(DataGrid dataGridDoldur, IEnumerable list)
        {
            dataGridDoldur.ItemsSource = null;
            dataGridDoldur.ItemsSource = list;

        }
        public static void cbOtoDoldur(ComboBox comboBoxDoldur, IEnumerable list)
        {
            comboBoxDoldur.ItemsSource = list;
            comboBoxDoldur.DisplayMemberPath = "Name";
            comboBoxDoldur.SelectedIndex = 0;
        }
    }
}
