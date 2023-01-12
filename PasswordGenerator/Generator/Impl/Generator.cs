using System;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    public sealed class Generator : IGeneratable
    {
        private int _passwordLength;
        private string _generatedPassword;

        private OptionsManager _optionsManager;

        public Generator() 
        {
            _optionsManager = new OptionsManager();
            _passwordLength = 4;
        }

        public void ChangeLength(int passwordLength)
        {
            _passwordLength = passwordLength;
        }

        public void Generate()
        {
            var rand = new Random();
            var stringBuilder = new StringBuilder();
            var options = _optionsManager.GetOptionsList().Where(all => all.IsEnabled()).ToList();

            for (int i = 0; i < _passwordLength; i++) 
            {
                int optionId = rand.Next(options.Count);

                string details = options.ElementAt(optionId).GetOptionDetails();

                int detailsId = rand.Next(details.Length);

                if (i % 3 != 2)
                    stringBuilder.Append(details.ToLower()[detailsId]);
                else
                    stringBuilder.Append(details[detailsId]);
            }

            _generatedPassword = stringBuilder.ToString();
        }

        public OptionsManager GetOptionsManager() => _optionsManager;

        public string GetGeneratedPassword() => _generatedPassword;
    }
}