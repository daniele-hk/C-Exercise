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

namespace WPF04_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<LearningSkillList> skills = new List<LearningSkillList>();
            skills.Add(new LearningSkillList() { SkillTitle = "HTML Basics", Completion = 100, TimeSpent = 10 });
            skills.Add(new LearningSkillList() { SkillTitle = "CSS Basics", Completion = 100 });
            skills.Add(new LearningSkillList() { SkillTitle = "JavaScript Basics", Completion = 50 });
            skills.Add(new LearningSkillList() { SkillTitle = "Angular Basics", Completion = 100, TimeSpent = 147 });
            skills.Add(new LearningSkillList() { SkillTitle = "C# Basics", Completion = 70, TimeSpent = 78 });

            lbLearningList.ItemsSource = skills;
        }

        private void Show_Time_Detail(object sender, RoutedEventArgs e)
        {
            if(lbLearningList.SelectedItem != null)
            {
                MessageBox.Show("Hours of time spent learning: " + (lbLearningList.SelectedItem as LearningSkillList).TimeSpent);
            }
        }
    }
}
