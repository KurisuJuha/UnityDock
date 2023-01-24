using UnityEngine.UIElements;

namespace JuhaKurisu.UnityDock
{
    public abstract class Tab
    {
        public abstract string name { get; }

        public virtual void OnGUI()
        {
        }
    }
}