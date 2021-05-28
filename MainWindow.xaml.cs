using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Threading;
using System.Windows.Media;

namespace MouseMover
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Initalset General
        public static bool running = false;
        public static bool smooth = false;
        public static int seconds = 0;
        public static int MoveSteps = 100;
        Thread t1;
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            #region Initalset WPF
            input_str.IsEnabled = true;
            start_btn.IsEnabled = true;
            seconds_label.Opacity = 0;
            Status.Fill = new SolidColorBrush(Colors.Red);
            #endregion

        }

        private void start_btn_Click(object sender, RoutedEventArgs e)
        {
            if (running == false)
            {
                if(seconds >= 5)
                {
                    input_str.IsEnabled = false;
                    seconds_label.Opacity = 0;
                    running = true;
                    start_btn.Content = "Stopp Idle";
                    Status.Fill = new SolidColorBrush(Colors.Green);
                    t1 = new Thread(new ThreadStart(Moving.Move));
                    t1.Start();
                }
                else
                {
                    seconds_label.Opacity = 100;
                }
            }
            else
            {
                input_str.IsEnabled = true;
                running = false;
                start_btn.Content = "Start Idle";
                Status.Fill = new SolidColorBrush(Colors.Red);
            }
        }
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void input_str_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (input_str.Text != null)
            {
                start_btn.IsEnabled = true;
                seconds = int.Parse(input_str.Text);
            }
            else
            {
                start_btn.IsEnabled = false;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            smooth = (bool)Smooth_Mouse.IsChecked;
        }
    }
}
