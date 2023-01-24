using UnityEngine;
using UnityEditor;

namespace JuhaKurisu.UnityDock
{
    public class PackagesTab : Tab
    {
        public override string name => "Packages";
        private Vector2 scrollPosition;

        public override void OnGUI()
        {
            using (var scrollView = new EditorGUILayout.ScrollViewScope(scrollPosition))
            {
                scrollPosition = scrollView.scrollPosition;

                for (int i = 0; i < 50; i++)
                {
                    using (new EditorGUILayout.HorizontalScope("Box"))
                    {
                        using (new EditorGUILayout.VerticalScope())
                        {
                            GUILayout.Button("test");
                            GUILayout.Button("test");
                            GUILayout.Button("test");
                            GUILayout.Button("test");
                        }
                    }
                }
            }
        }
    }
}