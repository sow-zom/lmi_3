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
using System.Collections.ObjectModel;

namespace lmi_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> Studentname;
        ObservableCollection<string> Studentsurname;
        ObservableCollection<string> Studentkyrs;
        ObservableCollection<string> Studentprof;
        public MainWindow()
        {
            InitializeComponent();

            Studentname = new ObservableCollection<string>();
            Studentsurname = new ObservableCollection<string>();
            Studentkyrs = new ObservableCollection<string>();
            Studentprof = new ObservableCollection<string>();
            StudentnameList.ItemsSource = Studentname;
            StudentsurnameList.ItemsSource = Studentsurname;
            StudentkyrsList.ItemsSource = Studentkyrs;
            StudentprofList.ItemsSource = Studentprof;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Studentname2 stud = new Studentname2();
            stud.set_name(StudentnameTextBox.Text);
            stud.set_sur_name(StudentsurnameTextBox.Text);
            stud.set_kyrs(StudentkyrsTextBox.Text);
            stud.set_prof(StudentprofTextBox.Text);
           
            Studentname.Add(stud.get_name());
            Studentsurname.Add(stud.get_sur_name());
            Studentkyrs.Add(stud.get_kyrs());
            Studentprof.Add(stud.get_prof());


        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Studentname.Clear();
            Studentsurname.Clear();
            Studentkyrs.Clear();
            Studentprof.Clear();
        }
        public class Human
        {
            string name, sur_name;

            public Human(string a = "__", string b = "__")
            {
                name = a;
                sur_name = b;
               
            }
            public Human(Human a)
            {
                name = a.name;
                sur_name = a.sur_name;
               
            }

            public void set_name(string name2)
            {
                name = name2;
            }
            public void set_sur_name(string sur_name2)
            {
                sur_name = sur_name2;
            }
            

            public string get_name()
            {
                return name;
            }
            public string get_sur_name()
            {
                return sur_name;
            }

        }
        public class Studentname2 : Human
        {
            string kyrs;
            string prof;
            public void set_kyrs(string kyrs2)
            {
                kyrs = kyrs2;
            }
            public void set_prof(string prof2)
            {
                prof = prof2;
            }


            public string get_kyrs()
            {
                return kyrs;
            }
            public string get_prof()
            {
                return prof;
            }

        }

        private void StudentnameList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
