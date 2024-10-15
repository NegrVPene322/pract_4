using Lib_9;
using LibMas;
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
using static Lib_9.Class_9;
using static LibMas.ClassMas;
namespace Практическая_3
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
        int[,] mas;
        private void bt_input_Click(object sender, RoutedEventArgs e)
        {
            bool f1,f2;
            int n,m;
            f1 = Int32.TryParse(tb_in_n.Text, out n);
            f2 = Int32.TryParse(tb_in_m.Text, out m);
            if (f1 && f2)
            {
                Class_9 aaa = new Class_9();
                mas = aaa.Func_Input(n,m);
                dtgrid.ItemsSource = ClassMas.ToDataTable(mas).DefaultView;
            }
            else MessageBox.Show("Неправильное значение");
        }

        private void bt_calc_Click(object sender, RoutedEventArgs e)
        {
            if (mas != null)
            {
                Class_9 aaa = new Class_9();
                int maxsum;
                int maxRow;
                aaa.Func_Calc(mas,out maxsum,out maxRow);
                
                tb_rez_1.Text = maxRow.ToString();
                tb_rez_2.Text = maxsum.ToString();
            }
            else MessageBox.Show("Матрица пуста");
        }

        private void bt_save_Click(object sender, RoutedEventArgs e)
        {
            if (mas != null)
            {
                Func_Save(mas);
            }
            else MessageBox.Show("Матрица пуста");

        }

        private void bt_open_Click(object sender, RoutedEventArgs e)
        {
            mas = Func_Open();
            dtgrid.ItemsSource = ClassMas.ToDataTable(mas).DefaultView;
        }

        private void bt_clear_Click(object sender, RoutedEventArgs e)
        {
            mas = null;
            dtgrid.ItemsSource = null;
        }

        private void bt_cl_Click(object sender, RoutedEventArgs e)
        {
            tb_in_n.Clear();
            tb_in_m.Clear();
            tb_rez_1.Clear();
            tb_rez_2.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разраб Карпушин А.Д ИСП-31 \n вариант 9, практическая №3 \n Дана матрица размера M × N. Найти номер ее строки с наибольшей суммой \r\nэлементов и вывести данный номер, а также значение наибольшей суммы.  ", "Информация о программе");
        }

        private void bt_esc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}