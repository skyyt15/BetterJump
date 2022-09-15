using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestJump
{
    public class Plugin:Plugin<Config>
    {
        public override string Author { get; } = "sky";

        public override string Name { get; } = "BetterJump";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } =new Version(5,3,0);

        public Plugin Singleton;

        public override void OnEnabled()
        {
            Singleton = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }

        public void OnJump(JumpingEventArgs ev)
        {
            if (ev != null)
            {
                ev.Player.Stamina.RemainingStamina -= Singleton.Config.RemoveStamina;
            }
        }
    }
}
