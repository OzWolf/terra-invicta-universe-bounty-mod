using UnityModManagerNet;

namespace UniverseBounty
{
    public class Settings : UnityModManager.ModSettings
    {
        public int SelectedTab = 0;
        public bool Enabled = true;
        public int HabModuleBuildBoosts = 0;

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }
    }
}