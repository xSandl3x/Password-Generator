using System;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    public sealed class Generator : IGeneratable
    {
        private int passwordLength;

        private string generatedPassword;

        private OptionsManager optionsManager;

        public Generator() 
        {
            this.optionsManager = new OptionsManager();
            this.passwordLength = 4;
        }

        public void ChangeLength(int passwordLength)
        {
            this.passwordLength = passwordLength;
        }

        public void Generate()
        {
            var rand = new Random();
            var stringBuilder = new StringBuilder();
            var options = optionsManager.GetOptionsList().Where(all => all.IsEnabled()).ToList();

            for (int i = 0; i < this.passwordLength; i++) 
            {
                int optionId = rand.Next(options.Count);

                string details = options.ElementAt(optionId).GetOptionDetails();

                int detailsId = rand.Next(details.Length);

                if (i % 3 != 2)
                    stringBuilder.Append(details.ToLower()[detailsId]);
                else
                    stringBuilder.Append(details[detailsId]);
            }

            this.generatedPassword = stringBuilder.ToString();
        }

        public OptionsManager GetOptionsManager() => this.optionsManager;

        public string GetGeneratedPassword() => this.generatedPassword;
    }
}