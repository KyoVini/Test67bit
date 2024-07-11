using System;
using System.Linq;
namespace GymBeastLike
{
    public static class LayerChange
    {
        private static string[] layersname = { "Default", "TransparentFX", "Ignore Raycast", "Enemies", "Water", "UI" };
        public static int GetLayer(string _layer = "Default")
        {
            if (layersname.Contains(_layer))
            {
                return Array.IndexOf(layersname, _layer);
            }
            else
            {
                return -1;
            }
        }
    }
}
