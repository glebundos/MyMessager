using MyMessager;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private static int MessageID = 0;
        private static string UserName;
        private static MessangerClientAPI API = new();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var getMessage = new Func<Task>(async () =>
            {
                var msg = await API.GetMessageHTTPAsync(MessageID);
                while (msg != null)
                {
                    MessagesLB.Items.Add(msg);
                    MessageID++;
                    msg = await API.GetMessageHTTPAsync(MessageID);
                }
            });
            getMessage.Invoke();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTB.Text;
            string message = MessageTB.Text;
            MessageTB.Text = string.Empty;
            if ((userName.Length > 0) && (message.Length > 0))
            {
                MyMessager.Message msg = new MyMessager.Message(userName: userName, messageText: message, timeStamp: DateTime.UtcNow);
                API.SendMessage(msg);
            }
        }
    }
}