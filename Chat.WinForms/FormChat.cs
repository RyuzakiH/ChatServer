using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Chat.WinForms
{
    public partial class FormChat : Form
    {

        ChatClient client;

        private string selectedUser;


        public FormChat()
        {
            InitializeComponent();

            lstConnectedUsers.SelectedIndexChanged += (obj, e) => selectedUser = lstConnectedUsers.SelectedItem?.ToString();

            lstConnectedUsers.SelectedIndexChanged += LstConnectedUsers_SelectedIndexChanged;

            txtChatMessage.TextChanged += (obj, e) => btnChatMessageSend.Enabled = !string.IsNullOrWhiteSpace(txtChatMessage.Text) && lstConnectedUsers.Items.Count > 0;

            CreateChatClient();

            client.ConnectToServer(IPAddress.Parse("127.0.0.1"), 5000);
        }

        private void CreateChatClient()
        {
            client = new ChatClient();

            client.ClientConnected += Client_ClientConnected;

            client.ClientDisconnected += (obj, ev) => Invoke(new MethodInvoker(() => lstConnectedUsers.Items.Remove(ev.Client.Username)));

            client.MessageReceived += (obj, ev) =>
            {
                if (selectedUser == ev.Client.Username)
                    Invoke(new MethodInvoker(() => txtChatMessagesView.AppendText($"{ev.Message.Content} (from {ev.Client.Username}) at {ev.Message.Date.ToString()}\n")));
            };

            client.MessageSent += (obj, ev) =>
                Invoke(new MethodInvoker(() => txtChatMessagesView.AppendText($"{ev.Message.Content} (from {client.Username}) at {ev.Message.Date.ToString()}\n")));
        }

        private void Client_ClientConnected(object sender, ConnectionEventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                lstConnectedUsers.Items.Add(e.Client.Username);

                if (lstConnectedUsers.Items.Count == 1)
                    lstConnectedUsers.SelectedIndex = 0;
            }));
        }

        private void LstConnectedUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtChatMessagesView.Clear();

            var selectedUserChat = client.Chats.FirstOrDefault(c => c.User == selectedUser);

            if (selectedUserChat != null)
            {
                foreach (var message in selectedUserChat.Messages)
                {
                    this.txtChatMessagesView.AppendText($"{message.Content.TrimEnd()} (from {message.Sender}) at {message.Date.ToString()}\n");
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = this.txtLoginUsername.Text;
            var password = this.txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username required");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password required");
                return;
            }

            client.Login(username, password);


            gboxLogin.Hide();
            lblLoggedIn.Text += username;
            lblLoggedIn.Visible = true;

            client.Listen();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            var username = this.txtConnectUsername.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username required");
                return;
            }

            client.ConnectToClient(username);

            this.txtConnectUsername.Clear();
        }

        private void BtnChatMessageSend_Click(object sender, EventArgs e)
        {
            if (client.ConnectedClients.Count > 0)
            {
                var message = this.txtChatMessage.Text;

                var selectedClient = client.ConnectedClients.FirstOrDefault(u => u.Username == selectedUser);

                client.SendToClient(message, selectedClient);

                this.txtChatMessage.Clear();
            }
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
            Application.Exit();
        }
    }
}
