using System.Windows;
using System.Windows.Controls;

namespace WpfDemoWithInheritance
{
    // BaltInheritance "is a" StackPanel
    class ButtonAndLabelPanel : StackPanel
    {
        private int _counter = 0;
        private Label _label;

        public ButtonAndLabelPanel()
        {
            var button = new Button();
            button.Content = "Trykk på meg!";
            button.Click += ButtonClick;
            _label = new Label();

            Orientation = Orientation.Horizontal;
            Children.Add(button);
            Children.Add(_label);
            Margin = new Thickness(10, 10, 50, 10);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _counter++;
            _label.Content = _counter;
        }
    }
}
