using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromsClient
{
    public partial class Form1 : Form
    {
        private static int MessageID;
        private static string UserName;
        private static MessangerClientAPI API = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var getMessage = new Func<Task>(async () =>
            {
                var msg = await API.GetMessageHTTPAsync(MessageID);
                if (msg != null)
                {
                    MessageID++;
                    Console.WriteLine(msg);
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
}
