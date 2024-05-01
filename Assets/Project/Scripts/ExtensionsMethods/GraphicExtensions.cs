using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts.ExtensionsMethods
{
    public static class GraphicExtensions
    {
        public static void SetAlpha(this Graphic graphic, float alpha)
        {
            Color color = graphic.color;
            color.a = alpha;
            graphic.color = color;
        }
    }
}