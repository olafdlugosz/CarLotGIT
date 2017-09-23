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
using System.IO;

namespace CarLotGIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CarLot safeHouse = new CarLot(name: "SafeHouse", adress: "Valhallavägen 5");
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method for storing the CarWPF class in a List Collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Store_Car_Click(object sender, RoutedEventArgs e)
        {
            CarWPF car = new CarWPF(Make, Model, Year, Color, RegNumber);
            carListBox.Items.Add(car.DisplayCarInfo());
            safeHouse.carList.Add(car);
        }
        /// <summary>
        /// Getters for class constructor requirements
        /// </summary>
        private string Make => makeTextbox.Text;
        private string Model => modelTextbox.Text;
        private int Year
        {
            get
            {
                int.TryParse(yearTextbox.Text, out int year); return year;
            }
        }
        private string Color => colorTextBox.Text;
        private string RegNumber => RegNumberTextbox.Text;
        /// <summary>
        /// Location of the List storage
        /// </summary>
        private string DataFile => "C:\\Users\\Olaf\\Desktop\\Cars.txt";
        /// <summary>
        /// Method for removing data from both the List and the Listbox
        /// </summary>
        private void RemoveData()
        {
            int index = carListBox.SelectedIndex;
            safeHouse.carList.RemoveAt(index);
            carListBox.Items.RemoveAt(index);
        }
        /// <summary>
        /// Method for storing Car class information in an external .txt file
        /// </summary>
        private void SaveData()
        {
            StreamWriter writer = new StreamWriter(DataFile, false);
            foreach (var car in safeHouse.carList)
            {
                writer.WriteLine(car.DisplayCarInfo());
            }
            writer.Close();
            writer.Dispose();
        }
        /// <summary>
        /// Method for loading the list back into the program from the external .txt file
        /// </summary>
        private void LoadData()

        {
            StreamReader reader = new StreamReader(DataFile);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var fields = line.Split(new[] { ',' });
                CarWPF car = new CarWPF(fields[0], fields[1], int.Parse(fields[2]), fields[3], fields[4]);
                carListBox.Items.Add(car.DisplayCarInfo());
                safeHouse.carList.Add(car);
            }
        }
        private void Save_Data_Click(object sender, RoutedEventArgs e)
        {
            SaveData();
        }

        private void Load_Data_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Remove_Car_Click(object sender, RoutedEventArgs e)
        {
            RemoveData();
        }
    }
}
