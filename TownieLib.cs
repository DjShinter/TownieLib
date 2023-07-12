using System;

namespace TownieLib
{
    using BepInEx;
    using BepInEx.Logging;
    using HarmonyLib;

    internal static class ModBuildInfo
    {
        public const string Name = "TownieLib";
        public const string Author = "Shin";
        public const string GUID = "dev.shinter.tos2.townielib";
        public const string Version = "0.0.1";
        public const string DownloadLink = "https://github.com/DjShinter/TownieLib/releases";
    }
    [BepInPlugin(ModBuildInfo.GUID, ModBuildInfo.Name, ModBuildInfo.Version)]
    [BepInProcess("TownOfSalem2.exe")]
    internal class LoadedTownieLib : BaseUnityPlugin
    {
        internal static LoadedTownieLib Instance;

        internal static void LogInfo(object data)
        {
            Instance.Logger.LogInfo(data);
        }

        internal static void LogError(object data)
        {
            Instance.Logger.LogInfo(data);
        }

        private LoadedTownieLib()
        {
            if (Instance != null)
            {
                string errMsg = "This plugin should only have a single instance";
                LogError(errMsg);
                throw new System.InvalidOperationException(errMsg);
            }
            Instance = this;
        }
        public void Awake()
        {
            try
            {
                Harmony.CreateAndPatchAll(typeof(TownieApi));
                LogInfo($"{nameof(LoadedTownieLib)} started successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
