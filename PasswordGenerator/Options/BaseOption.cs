
namespace PasswordGenerator
{
    public class BaseOption
    {
        private bool _enable;

        public BaseOption()
        {
            _enable = false;
        }

        public void SetEnable(bool enable) 
        {
            _enable = enable;
        }

        public bool IsEnabled() => _enable;

        public virtual string GetOptionDetails() => "Base option";

        public virtual OptionsType GetOptionsType() => OptionsType.OTHER;
    }
}
