using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using System.Diagnostics;

namespace ShutDownTheFuckingServer
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Shut down the Fucking Server";
        public override string Prefix { get; } = "SDTFS";
        public override string Author { get; } = "TheMoogle";
        public override Version Version { get; } = new Version(2, 0, 0);
        public override PluginPriority Priority { get; } = PluginPriority.First;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Log.Debug("Epic Server Shutdown/Bootloop brought to you by That Moogle!");
            Log.Debug(":D");
            Process.GetCurrentProcess().Kill();
        }
    }
}
