using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Windows.Forms;

namespace webSocketChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            string username = txt_User.Text;
            MessageReceived msg = new MessageReceived(txt_Message.Text, username);
            txt_ChatMessages.AppendText(String.Format("{0}: {1} \n", msg.Username, msg.Message));
        }

        private void txt_ChatMessages_TextChanged(object sender, EventArgs e)
        {
            this.txt_ChatMessages.Enabled = true;
            this.txt_ChatMessages.ReadOnly = true;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
           string userName = txt_User.Text;

        }
    }

    public class Echo : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine("Received message from Echo client: " + e.Data);
            Send(e.Data);
        }
    }

    public class EchoAll : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine("Received message from EchoAll client: " + e.Data);
            Sessions.Broadcast(e.Data);
        }
    }

    public class Default : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine("Mensagem recebida por default no servidor ws." + e.Data);

            MessageReceived msg = new MessageReceived("msg teste 123", "usuário");

            var serializedContent = JsonConvert.SerializeObject(msg);
            StringContent content = new StringContent(serializedContent, Encoding.UTF8, "application/json");

            byte[] dataBytes = Encoding.Default.GetBytes(serializedContent);
            Console.WriteLine("JSON" + serializedContent + "/n");

            string ServerResponse = "WebSocket Servidor => Client messagem.";
            Sessions.Broadcast(dataBytes);
        }
    }

    public class MessageReceived
    {
        public string Message { get; set; }
        public string Username { get; set; }

        public MessageReceived(string message, string username)
        {
            Message = message;
            Username = username;
        }
    }

    public class Server
    {
        static void ServerOpen(string[] args)
        {
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());

            IPAddress ippaddress = ipEntry.AddressList
            .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

            int port = 14150;


            WebSocketServer wssv = new WebSocketServer("ws://127.0.0.1:7890");

            wssv.AddWebSocketService<Default>("/");
            wssv.AddWebSocketService<Echo>("/Echo");
            wssv.AddWebSocketService<EchoAll>("/EchoAll");

            wssv.Start();

            Console.WriteLine($"WS server started on ws://{ippaddress}:{port}/");
            Console.WriteLine($"WS server started on ws://{ippaddress}:{port}/Echo");
            Console.WriteLine($"WS server started on ws://{ippaddress}:{port}/EchoAll");

            Console.ReadKey();
            wssv.Stop();
        }
    }
}
