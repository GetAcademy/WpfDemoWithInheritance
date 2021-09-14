using System.Windows;
using System.Windows.Controls;

namespace WpfDemoWithInheritance
{
    // BaltComposition "has a" counter
    // BaltComposition "has a" StackPanel
    class ButtonAndLabelComposition
    {
        private int _counter = 0;
        private Label _label;
        public StackPanel Panel { get; }

        public ButtonAndLabelComposition()
        {
            var button = new Button();
            button.Content = "Trykk på meg!";
            button.Click += ButtonClick;
            _label = new Label();

            Panel = new StackPanel();
            Panel.Orientation = Orientation.Horizontal;
            Panel.Children.Add(button);
            Panel.Children.Add(_label);
            Panel.Margin = new Thickness(10, 10, 50, 10);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _counter++;
            _label.Content = _counter;
        }
    }
}
