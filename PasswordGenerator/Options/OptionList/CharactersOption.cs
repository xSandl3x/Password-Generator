
namespace PasswordGenerator
{
    public class CharactersOption : BaseOption
    {
        public override string GetOptionDetails() => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public override OptionsType GetOptionsType() => OptionsType.CHARACTERS;
    }
}
