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
                            var style = new GUIStyle(EditorStyles.label);
                            style.richText = true;

                            EditorGUILayout.LabelField("<size=30>Test</size>", style, GUILayout.Height(30));
                            EditorGUILayout.LabelField("テステスのテスト");
                        }

                        GUILayout.FlexibleSpace();

                        using (new EditorGUILayout.VerticalScope("Box", GUILayout.Height(50)))
                        {
                            GUILayout.FlexibleSpace();
                            GUILayout.Button("hoge");
                            GUILayout.FlexibleSpace();
                        }
                    }
                }
            }
        }
    }
}