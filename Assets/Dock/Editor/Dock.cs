using System.Linq;
using UnityEditor;
using UnityEngine;

namespace JuhaKurisu.UnityDock
{
    public class DockWindow : EditorWindow
    {
        private static DockWindow dockWindow;
        private readonly Tab[] tabs = new Tab[] { new PackagesTab() };
        int tabIndex;

        [MenuItem("Tools/Dock")]
        private static void Create()
        {
            if (dockWindow != null) return;
            dockWindow = GetWindow<DockWindow>("Dock");
        }

        private void OnGUI()
        {
            using (new EditorGUILayout.HorizontalScope(EditorStyles.toolbar))
            {
                tabIndex = GUILayout.Toolbar(tabIndex, tabs.Select(t => t.name).ToArray(), new GUIStyle(EditorStyles.toolbarButton), GUI.ToolbarButtonSize.Fixed);
            }
            tabs[tabIndex].OnGUI();
        }
    }
}