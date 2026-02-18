using System.Collections.Generic;
using System.Windows;
using AIAssistantPlatform.Core.Interfaces;
using AIAssistantPlatform.Core.Services;
using AIAssistantPlatform.Plugins;

namespace AIAssistantPlatform
{
    public partial class MainWindow : Window
    {
        private Chatbot _bot;
        private IResponseStrategy _strategy;

        public MainWindow()
        {
            InitializeComponent();

            // =========================
            // 1️⃣ FACTORY METHOD
            // =========================
            PluginCreator creator = new WeatherPluginCreator();
            IPlugin pluginFromFactoryMethod = creator.CreatePlugin();

            // =========================
            // 2️⃣ ABSTRACT FACTORY
            // =========================
            IAssistantFactory assistantFactory = new FriendlyAssistantFactory();

            IPlugin pluginFromAbstractFactory = assistantFactory.CreatePlugin();
            _strategy = assistantFactory.CreateResponseStrategy();

            // Alegem ce plugin folosim (demonstrativ folosim cel din Factory Method)
            var plugins = new List<IPlugin> { pluginFromFactoryMethod };

            _bot = new Chatbot(plugins);
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            string rawResponse = _bot.HandleMessage(InputBox.Text);

            // aplicăm strategia din Abstract Factory
            string finalResponse = _strategy.GenerateResponse(rawResponse);

            OutputText.Text = finalResponse;
        }
    }
}
