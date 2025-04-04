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

namespace TK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int MaxModule1 = 22;
        private const int MaxModule2 = 38;
        private const int MaxModule3 = 20;

        public MainWindow()
        {
            InitializeComponent();
        }



        public bool Calculatee(string value1, string value2, string value3) 
        {
            try
            {
                int m1 = int.Parse(value1);
                int m2 = int.Parse(value2);
                int m3 = int.Parse(value3);

                if (m1 > MaxModule1 || m2 > MaxModule2 || m3 > MaxModule3)
                {
                    MessageBox.Show("Превышено допустимое количество баллов в одном из модулей!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }

                int total = m1 + m2 + m3;
                string grade = GetGrade(total);

                TotalScoreTextBlock.Text = $"Общая сумма баллов: {total} из 80";
                GradeTextBlock.Text = $"Оценка: {grade}";
            }
            catch
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            Module1TextBox.Clear();
            Module2TextBox.Clear(); 
            Module3TextBox.Clear();
            return true;
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            Calculatee(Module1TextBox.Text, Module2TextBox.Text, Module3TextBox.Text);

        }

        private string GetGrade(int total)
        {
            if (total >= 56) return "5 (отлично)";
            else if (total >= 32) return "4 (хорошо)";
            else if (total >= 16) return "3 (удовлетворительно)";
            else return "2 (неудовлетворительно)";
        }
    }
}
