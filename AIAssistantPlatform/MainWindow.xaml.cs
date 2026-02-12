using System.Collections.Generic;
using System.Windows;
using AIAssistantPlatform.Core.Interfaces;
using AIAssistantPlatform.Core.Services;

namespace AIAssistantPlatform
{
    public partial class MainWindow : Window
    {
        private Chatbot _bot;

        public MainWindow()
        {
            InitializeComponent();

            var plugins = new List<IPlugin>();
            _bot = new Chatbot(plugins);
        }
        private void Send_Click(object sender, RoutedEventArgs e)
        {
            string response = _bot.HandleMessage(InputBox.Text);

            OutputText.Text = response;
        }
    }
}
