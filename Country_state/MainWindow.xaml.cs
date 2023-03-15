using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace Country_state
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

       
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
           // ComboBoxItem typeItem = (ComboBoxItem)State.SelectedItem;
          //  string value = typeItem.Content.ToString();
            //String combo = State.SelectedIndex.ToString();
            //Console.Write(value);
                 Dictionary<string, string> state = new Dictionary<string, string>();
            string dir = System.IO.Directory.GetCurrentDirectory();
            string filename = "State_City.gz";  //"test_project.gz";
            string path = "Country_state\\Country_state\\" + filename;

            EDSEngine knowledge = new EDSEngine(path);

                    knowledge = new EDSEngine(filename);
            /*       if (knowledge.IsOpen() == false)
                 {
                     Console.WriteLine("FAILURE: Could not open rules xml file: " + filename);

                    // Quit();
                 }
             }

             if (knowledge.IsOpen() == true)

             Console.WriteLine("OK: File opened");

             knowledge.SetMaxThreads(2);

           //  knowledge.DebugDelegate = write_debug;
             knowledge.EnableRemoteDebugger(false);

             InputValueGetterDelegate getValueDelegate = (string attrName, object context) =>
             {
                 if (state.ContainsKey(attrName))
                     return state[attrName];
                 else
                     return "";
             };
             knowledge.InputGetterDelegate = getValueDelegate;

             var cnt = knowledge.TableCount();
             if (cnt == 1)
             {
                 Console.WriteLine("OK: 1 Tables loaded");
             }
             else
             {
                 Console.WriteLine("FAILURE: Not all tables loaded: " + cnt.ToString());
             }
             string tableName = "testtable1";
             Console.WriteLine("Loading attr output names for " + tableName);
             var allOutputNames = knowledge.GetOutputAttrs(tableName);
             for (var i = 0; i < allOutputNames.Length; i++)
             {
                 Console.WriteLine(allOutputNames[i]);
             }
             if (allOutputNames.Length == 2 && allOutputNames[0] == "anotherOutput" && allOutputNames[1] == "outputAttr1")
             {
                 Console.WriteLine("OK");
             }
             else
             {
                 Console.WriteLine("FAILURE: Did not load all the output names");
             }

             Console.WriteLine("Loading attr input names for " + tableName);
             var allInputNames = knowledge.GetInputAttrs(tableName);
             for (var i = 0; i < allInputNames.Length; i++)
             {
                 Console.WriteLine(allInputNames[i]);
             }
             if (allInputNames.Length == 2 && allInputNames[0] == "inputAttr1" && allInputNames[1] == "inputAttr2")
             {
                 Console.WriteLine("OK");
             }
             else
             {
                 Console.WriteLine("FAILURE: Did not load all the input names");
             }

             Console.WriteLine("Loading dependency names for " + tableName);
             var allDepNames = knowledge.GetInputDependencies(tableName);
             for (var i = 0; i < allDepNames.Length; i++)
             {
                 Console.WriteLine(allDepNames[i]);
             }
             if (allDepNames.Length == 3 && allDepNames[0] == "inputAttr1" &&
                 allDepNames[1] == "inputAttr2" &&
                 allDepNames[2] == "outsideAttr1")
             {
                 Console.WriteLine("OK");
             }
             else
             {
                 Console.WriteLine("FAILURE: Did not load all the dependency names");
             }

             var outputAttr = "outputAttr1";
             City.Items.Add(outputAttr);
             */
        }
    }
}