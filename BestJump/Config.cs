using Exiled.API.Interfaces;

namespace BestJump
{
    public class Config:IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public float RemoveStamina { get; set; } = 0.1f;
    }
}
