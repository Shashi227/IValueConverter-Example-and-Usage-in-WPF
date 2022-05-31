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

namespace IvalueConveter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //new record of Employee
            Employee shashi = new Employee();
            shashi.firstname = "1";
            shashi.middlename = "Shashi Kumar";
            shashi.lastname = "DHS";
            

            Emp_dataGrid.Items.Add(shashi);

            Employee saikh = new Employee();
            saikh.firstname = "2";
            saikh.middlename = "Saikh ";
            saikh.lastname = "DHS";
            

            Emp_dataGrid.Items.Add(saikh);

            Employee madhavi = new Employee();
            madhavi.firstname = "3";
            madhavi.middlename = "Madhavi R";
            madhavi.lastname = "DHS";
            

            Emp_dataGrid.Items.Add(madhavi);

            Employee barinder = new Employee();
            barinder.firstname = "";
            barinder.middlename = "Barinderjeet";
            barinder.lastname = "DHS";
            

            Emp_dataGrid.Items.Add(barinder);
        }
        public class Employee
        {
            public string firstname { get; set; }
            public string middlename { get; set; }
            public string lastname { get; set; }
            

        }

    }
}
