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
using EDSNET;


namespace State_city_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> applicationState = new Dictionary<string, string>();
        public MainWindow()
        {
            InitializeComponent();
            string dir = System.IO.Directory.GetCurrentDirectory();
            string filename = "rules/State_City.xml";
            EDSEngine knowledge = new EDSEngine(filename);
            knowledge = new EDSEngine(filename);
            // get the states and populate it
            knowledge.InputGetterDelegate = delegate (string key, object obj)
            {
                if (applicationState.ContainsKey(key))
                    return applicationState[key];
                else
                    return string.Empty;
            };

            Dictionary<string, string[]> outputDict = new Dictionary<string, string[]>();
            applicationState["State"] = "Delhi";
            outputDict = knowledge.EvaluateTable("Cities", true);
            List<string> stateList = new List<string>();
            stateList.AddRange(outputDict["State"]);
            State.ItemsSource = stateList;
        }

        private void State_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add the selected state to the ApplicationState Data Structure
            ComboBox cb = sender as ComboBox;
            string stateStr = (string)cb.SelectedValue;
            if(!applicationState.ContainsKey("State"))applicationState.Add("State", stateStr);
            // Evaluate the Cities Table and get the list of cities
        }
    }
}
