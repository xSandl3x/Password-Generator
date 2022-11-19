
namespace PasswordGenerator
{
    public class BaseOption
    {
        private bool enable;

        public BaseOption()
        {
            this.enable = false;
        }

        public void SetEnable(bool enable) 
        {
            this.enable = enable;
        }

        public bool IsEnabled() => enable;

        public virtual string GetOptionDetails() => "Base option";

        public virtual OptionsType GetOptionsType() => OptionsType.NONE;
    }
}
