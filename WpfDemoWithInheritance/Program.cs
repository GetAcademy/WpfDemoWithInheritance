using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemoWithInheritance
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var application = new Application();
            var window = new Window();

            var thing1 = new ButtonAndLabelPanel();
            var thing2 = new ButtonAndLabelPanel();
            var thing3 = new ButtonAndLabelPanel();
            var thing4 = new ButtonAndLabelPanel();
            var thing5 = new ButtonAndLabelPanel();

            var layoutPanel = new StackPanel();
            layoutPanel.Children.Add(thing1);
            layoutPanel.Children.Add(thing2);
            layoutPanel.Children.Add(thing3);
            layoutPanel.Children.Add(thing4);
            layoutPanel.Children.Add(thing5);

            window.Content = layoutPanel;
            application.Run(window);
        }

        public static void MainComposition(string[] args)
        {
            var application = new Application();
            var window = new Window();

            var thing1 = new ButtonAndLabelComposition();
            var thing2 = new ButtonAndLabelComposition();
            var thing3 = new ButtonAndLabelComposition();
            var thing4 = new ButtonAndLabelComposition();
            var thing5 = new ButtonAndLabelComposition();

            var layoutPanel = new StackPanel();
            layoutPanel.Children.Add(thing1.Panel);
            layoutPanel.Children.Add(thing2.Panel);
            layoutPanel.Children.Add(thing3.Panel);
            layoutPanel.Children.Add(thing4.Panel);
            layoutPanel.Children.Add(thing5.Panel);

            
            window.Content = layoutPanel;
            application.Run(window);
        }

        private static int _counter = 0;
        private static Label _label;
        public static void OldMain(string[] args)
        {
            var application = new Application();
            var window = new Window();

            var button = new Button();
            button.Content = "Trykk på meg!";
            button.Click += ButtonClick;
            _label = new Label();

            var panel = new StackPanel();
            panel.Orientation = Orientation.Vertical;
            panel.Children.Add(button);
            panel.Children.Add(_label);

            window.Content = panel;
            application.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _counter++;
            _label.Content = _counter;
        }
    }
}
