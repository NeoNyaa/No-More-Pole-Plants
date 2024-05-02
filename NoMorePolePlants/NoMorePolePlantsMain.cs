using BepInEx;

namespace NoMorePolePlants
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class NoMorePolePlantsMain : BaseUnityPlugin {

        public const string PLUGIN_GUID = "NeoNyaa.NoMorePolePlants";
        public const string PLUGIN_NAME = "No More Pole Plants";
        public const string PLUGIN_VERSION = "1.0.0";

        public void OnEnable() {
            On.PoleMimic.Initiate += PoleMimicInitHook;
            On.PoleMimic.Update += PoleMimicUpdateHook;
        }

        void PoleMimicInitHook(On.PoleMimic.orig_Initiate orig, PoleMimic self) {
            
        }

        void PoleMimicUpdateHook( On.PoleMimic.orig_Update orig, PoleMimic self, bool eu ) {

        }
    }
}
