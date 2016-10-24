using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HappyTechFeedback
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = HappyTechFeedback.Template.CurrentTemplate();

            //just the test:
            //MessageBox.Show(HappyTechFeedback.Template.CurrentTemplate().sectionList[0].Title + Environment.NewLine +
            //        HappyTechFeedback.Template.CurrentTemplate().sectionList[1].Title + Environment.NewLine +
            //      HappyTechFeedback.Template.CurrentTemplate().sectionList[2].Title, "Section Titles");


            Loaded += MainWindow_Loaded;



        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //this will execute once the main windows is loaded
            //this wont be needed as we are using custom data binding
            //string connectionString = Properties.Settings.Default.DBConnection;
            //DBHandler dbConnection = new DBHandler(connectionString);
            // dbConnection.openConnection();
            //DataSet dataSet = dbConnection.getDataSet(Constants.selectAll);
            //DataTable table = dataSet.Tables[0];



            section0Title.Text = HappyTechFeedback.Template.CurrentTemplate().sectionList[0].Title;
            section1Title.Text = HappyTechFeedback.Template.CurrentTemplate().sectionList[1].Title;
            section0Code0Title.Text = HappyTechFeedback.Template.CurrentTemplate().sectionList[0].CodeList()[0].Title;
            section0Code0Content.Text = HappyTechFeedback.Template.CurrentTemplate().sectionList[0].CodeList()[0].Content;

            HappyTechFeedback.Template.CurrentTemplate().sectionList.Move(0, ListManipulation.MoveDirection.Up);


        }

        private void AddSectionButton_Click(object sender, RoutedEventArgs e)
        {
            HappyTechFeedback.Template.CurrentTemplate().AddSection(HappyTechFeedback.Template.sectionTypes.complexSection);
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            HappyTechFeedback.Template.CurrentTemplate().sectionList.Move(0, ListManipulation.MoveDirection.Down);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void section0Title_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            HappyTechFeedback.Template.CurrentTemplate().sectionList.RemoveAt(0);
            
        }
    }

}
