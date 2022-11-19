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
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            Func<CheckBox, bool> optionValue = (checkbox) => checkbox.IsChecked.Value;

            optionsManager.SetOption(OptionsType.NUMBERS, optionValue(checkBox));
            optionsManager.SetOption(OptionsType.CHARACTERS, optionValue(checkBox2));
            optionsManager.SetOption(OptionsType.SYMBOLS, optionValue(checkBox3));

            var options = optionsManager.GetOptionsList().Where(all => all.IsEnabled()).ToList();

            if (options.Count == 0)
            {
                errorMessage.Content = "Password could not be generated.";
                return;
            }

            generator.Generate();

            errorMessage.Content = "Password generated and copied.";
            resultLine.Text = generator.GetGeneratedPassword();
        }

        private void OnSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int length = (int)e.NewValue;

            lengthMessage.Content = length;
            generator.ChangeLength(length);
        }

        private void OnTextBoxChanged(object sender, TextChangedEventArgs e)
        {
            Clipboard.SetText(resultLine.Text);
        }
    }
}