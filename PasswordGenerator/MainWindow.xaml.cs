using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PasswordGenerator
{
    public partial class MainWindow : Window
    {
        private Generator generator;
        private OptionsManager optionsManager;

        public MainWindow()
        {
            this.generator = new Generator();
            this.optionsManager = generator.GetOptionsManager();

            this.InitializeComponent();
            this.DefaultOptionsLoader();
        }

        private void OnGenerateClick(object sender, RoutedEventArgs e)
        {
            Func<CheckBox, bool> optionValue = (checkbox) => checkbox.IsChecked.Value;

            optionsManager.SetOption(OptionsType.NUMBERS, optionValue(checkBox));
            optionsManager.SetOption(OptionsType.CHARACTERS, optionValue(checkBox2));
            optionsManager.SetOption(OptionsType.SYMBOLS, optionValue(checkBox3));

            var options = optionsManager.GetOptionsList().Where(all => all.IsEnabled()).ToList();

            if (options.Count == 0)
            {
                actionMessage.Content = "Password could not be generated.";
                return;
            }

            generator.Generate();

            actionMessage.Content = "Password successfully generated.";
            resultLine.Text = generator.GetGeneratedPassword();
        }

        private void OnCopyClick(object sender, RoutedEventArgs e) 
        {
            if (string.IsNullOrEmpty(resultLine.Text)) 
            {
                actionMessage.Content = "Password could not be copied.";
                return;
            }

            actionMessage.Content = "Password successfully copied.";

            Clipboard.SetText(resultLine.Text);
        }

        private void OnSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int length = (int)e.NewValue;

            lengthMessage.Content = length;
            generator.ChangeLength(length);
        }

        private void DefaultOptionsLoader() 
        {
            grid.Children.OfType<CheckBox>().ToList()
                .ForEach(options => options.IsChecked = true);
        }
    }
}