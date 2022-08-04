using MyMessager;
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
using System.Windows.Threading;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int MessageID = 0;
        private static string UserName;
        private static MessangerClientAPI API = new();
        DispatcherTimer timer;
        
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 1) }; // 1 second
            timer.Tick += timerTick;
            timer.Start();
        }

        private async void timerTick(object? sender, EventArgs e)
        {
            Message? msg = await API.GetMessageHTTPAsync(MessageID);
            while (msg != null)
            {
                MessagesLB.Items.Add(msg);
                MessageID++;
                msg = await API.GetMessageHTTPAsync(MessageID);
            }
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = UserNameTB.Text;
            string message = MessageTB.Text;
            MessageTB.Text = string.Empty;
            if ((userName.Length > 0) && (message.Length > 0))
            {
                Message msg = new Message(userName: userName, messageText: message, timeStamp: DateTime.UtcNow);
                API.SendMessage(msg);
            }
        }

        private void MessagesLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
