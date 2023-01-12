using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PasswordGenerator
{
    public partial class MainWindow : Window
    {
        private readonly Generator _generator;
        private readonly OptionsManager _optionsManager;

        public MainWindow()
        {
            _generator = new Generator();
            _optionsManager = _generator.GetOptionsManager();

            InitializeComponent();
            DefaultOptionsLoader();
        }

        private void OnGenerateClick(object sender, RoutedEventArgs e)
        {
            Func<CheckBox, bool> optionValue = (checkbox) => checkbox.IsChecked.Value;

            _optionsManager.SetOption(OptionsType.NUMBERS, optionValue(checkBox));
            _optionsManager.SetOption(OptionsType.CHARACTERS, optionValue(checkBox2));
            _optionsManager.SetOption(OptionsType.SYMBOLS, optionValue(checkBox3));

            var options = _optionsManager.GetOptionsList().Where(all => all.IsEnabled()).ToList();

            if (options.Count == 0)
            {
                actionMessage.Content = "Password could not be generated.";
                return;
            }

            _generator.Generate();

            actionMessage.Content = "Password successfully generated.";
            resultLine.Text = _generator.GetGeneratedPassword();
        }

        private void OnCopyClick(object sender, RoutedEventArgs e) 
        {
            if (string.IsNullOrEmpty(resultLine.Text)) 
            {
                actionMessage.Content = "Password could not be copied.";
                return;
            }

            actionMessage.Content = "Password successfully copied.";

            Clipboard.SetDataObject(resultLine); // Clipboard#SetText never use!
        }

        private void OnSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int length = (int)e.NewValue;

            lengthMessage.Content = length;
            _generator.ChangeLength(length);
        }

        private void DefaultOptionsLoader() 
        {
            grid.Children.OfType<CheckBox>().ToList()
                .ForEach(options => options.IsChecked = true);
        }
    }
}