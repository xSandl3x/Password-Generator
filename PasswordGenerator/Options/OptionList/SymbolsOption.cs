
namespace PasswordGenerator
{
    public class SymbolsOption : BaseOption
    {
        public override string GetOptionDetails() => "-!@#$^%&=";

        public override OptionsType GetOptionsType() => OptionsType.SYMBOLS;
    }
}
