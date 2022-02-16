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

            MessageReceived pessoa = new MessageReceived("msg teste 123");

            var serializedContent = JsonConvert.SerializeObject(pessoa);
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

        public MessageReceived(string message)
        {
            Message = message;
        }
        public MessageReceived()
        {

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
