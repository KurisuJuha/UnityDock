using System;
using UnityEditor;
using UnityEngine;

namespace JuhaKurisu.UnityDock
{
    public class DockWindow : EditorWindow
    {
        private static DockWindow dockWindow;
        private readonly string[] tabContents = { "Packages", "ColorScheme" };
        private readonly Action[] tabOnGUIFuncs;

        public DockWindow()
        {
            tabOnGUIFuncs = new Action[] { PackagesTab, ColorSchemeTab };
        }

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
                tabIndex = GUILayout.Toolbar(tabIndex, tabContents, new GUIStyle(EditorStyles.toolbarButton), GUI.ToolbarButtonSize.Fixed);
            }
            tabOnGUIFuncs[tabIndex].Invoke();
        }

        private void PackagesTab()
        {

        }

        private void ColorSchemeTab()
        {

        }
    }
}