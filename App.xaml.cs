using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace lmi_3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// public class Human
    //public class Human
    //{
    //    string name, sur_name, birthday;

    //    public Human(string a = "__", string b = "__", string c = "__")
    //    {
    //        name = a;
    //        sur_name = b;
    //        birthday = c;
    //    }
    //    public Human(Human a)
    //    {
    //        name = a.name;
    //        sur_name = a.sur_name;
    //        birthday = a.birthday;
    //    }

    //    public void set_name()
    //    {
    //        name = Console.ReadLine();
    //    }
    //    public void set_sur_name()
    //    {
    //        sur_name = Console.ReadLine();
    //    }
    //    public void set_birthday()
    //    {
    //        birthday = Console.ReadLine();
    //    }

    //    public string get_name()
    //    {
    //        return name;
    //    }
    //    public string get_sur_name()
    //    {
    //        return sur_name;
    //    }
    //    public string get_birthday()
    //    {
    //        return birthday;
    //    }

    //    public virtual void SET_ALL()
    //    {
    //        Console.WriteLine("\nSet_Name >> ");
    //        set_name();
    //        Console.WriteLine("\nSet_Sur_Name >> ");
    //        set_sur_name();
    //        Console.WriteLine("\nSet_Birth_Data >> ");
    //        set_birthday();
    //    }

    //    public virtual void ShowInfo()
    //    {
    //        Console.WriteLine("\nName >> " + get_name());

    //        Console.WriteLine("\nSur_Name >> " + get_sur_name());

    //        Console.WriteLine("\nBirth_Data >> " + get_birthday());
    //    }

    //}
    //public class Student2 : Human
    //{
    //    float kyrs;
    //    string group, fakul, osvit_zakld;
    //    public void set_kyrs()
    //    {
    //        kyrs = float.Parse(Console.ReadLine());
    //    }
    //    public void set_group()
    //    {
    //        group = Console.ReadLine();
    //    }
    //    public void set_fakul()
    //    {
    //        fakul = Console.ReadLine();
    //    }
    //    public void set_osvit_zakld()
    //    {
    //        osvit_zakld = Console.ReadLine();
    //    }

    //    public float get_kyrs()
    //    {
    //        return kyrs;
    //    }
    //    public string get_group()
    //    {
    //        return group;
    //    }
    //    public string get_fakul()
    //    {
    //        return fakul;
    //    }

    //    public string get_osvit_zakld()
    //    {
    //        return osvit_zakld;
    //    }


    //    public override void SET_ALL()
    //    {
    //        base.SET_ALL();
    //        Console.WriteLine("\nset_group >> ");
    //        set_group();
    //        Console.WriteLine("\nset_fakul >> ");
    //        set_fakul();
    //        Console.WriteLine("\nset_osvit_zakld >> ");
    //        set_osvit_zakld();
    //    }
    //    public override void ShowInfo()
    //    {
    //        base.ShowInfo();
    //        Console.WriteLine("\nget_kyrs >> " + get_kyrs());
    //        Console.WriteLine("\nget_group >> " + get_group());
    //        Console.WriteLine("\nget_fakul >> " + get_fakul());
    //        Console.WriteLine("\nget_osvit_zakld >> " + get_osvit_zakld());
    //    }

    //}

    class Student : INotifyPropertyChanged
    {
        private string group;
        private string osvit_zakld;
        private int kyrs;

        public string Group
        {
            get { return group; }
            set
            {
                group = value;
                OnPropertyChanged("group");
            }
        }
        public string Osvit_zakld
        {
            get { return osvit_zakld; }
            set
            {
                osvit_zakld = value;
                OnPropertyChanged("osvit_zakld");
            }
        }
        public int Kyrs
        {
            get { return kyrs; }
            set
            {
                kyrs = value;
                OnPropertyChanged("kyrs");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public partial class App : Application
    {
        ObservableCollection<Student> users = new ObservableCollection<Student>
        {
            
                
                
        };

    }

};
