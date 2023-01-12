using System.Collections.Generic;
using System.Linq;

namespace PasswordGenerator
{
    public sealed class OptionsManager 
    {
        private List<BaseOption> _optionsList;

        public OptionsManager() 
        {
            _optionsList = new List<BaseOption>() 
            {
                new CharactersOption(),
                new NumbersOption(),
                new SymbolsOption()
            };
        }

        public void SetOption(OptionsType optionsType, bool enable) 
        {
            var option = this.SearchByType(optionsType);
            option.SetEnable(enable);
        }

        public BaseOption SearchByType(OptionsType optionsType)
        {
            return _optionsList.Where(all => all.GetOptionsType().Equals(optionsType)).FirstOrDefault();
        }

        public List<BaseOption> GetOptionsList() => _optionsList;

    }
}
