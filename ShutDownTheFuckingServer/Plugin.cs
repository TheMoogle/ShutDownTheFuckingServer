using EXILED;
using System.Diagnostics;

namespace ShutDownTheFuckingServer
{
    public class Plugin : EXILED.Plugin
    {
        bool isEnabled;

        public override void OnEnable()
        {
            LoadConfigs();

            if (!isEnabled) return;

            Log.Debug("Epic Server Shutdown/Bootloop brought to you by That Moogle!");
            Log.Debug(":D");
            Process.GetCurrentProcess().Kill();
        }

        public override void OnDisable()
        {
            Log.Debug(":)");
        }

        public override void OnReload()
        {
            Log.Debug("Why?");
        }

        private void LoadConfigs()
        {
            isEnabled = Config.GetBool("sdtfs_enabled", true);
        }


        public override string getName { get; } = "Shut Down The Fucking Server";
    }
}
