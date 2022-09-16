using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;

namespace BestJump
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "sky";

        public override string Name { get; } = "BetterJump";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } =new Version(5,3,0);

        public Plugin Singleton;

        public override void OnEnabled()
        {
            Singleton = this;
            Exiled.Events.Handlers.Player.Jumping += OnJump;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Jumping -= OnJump;
            Singleton = null;
            base.OnDisabled();
        }

        public void OnJump(JumpingEventArgs ev)
        {
            if (ev.Player is null) return;
            ev.Player.Stamina.RemainingStamina -= Singleton.Config.RemoveStamina;
        }
    }
}
