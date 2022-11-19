
namespace PasswordGenerator
{
    public class NumbersOption : BaseOption
    {
        public override string GetOptionDetails() => "0123456789";

        public override OptionsType GetOptionsType() => OptionsType.NUMBERS;
    }
}
