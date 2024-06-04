namespace NerdStudios.CustomHeader.Editor
{
    using UnityEngine;
    using UnityEditor;

    [CustomPropertyDrawer(typeof(CustomHeaderAttribute))]
    public class CustomHeaderDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            CustomHeaderAttribute headerAttribute = (CustomHeaderAttribute)attribute;
            GUIStyle headerStyle = new GUIStyle(EditorStyles.boldLabel)
            {
                fontSize = headerAttribute.fontSize,
                normal = new GUIStyleState()
                {
                    textColor = Color.white,
                    background = Texture2D.whiteTexture
                }
            };

            // Set background color
            Color originalColor = GUI.backgroundColor;
            GUI.backgroundColor = headerAttribute.backgroundColor;

            // Draw background
            Rect backgroundRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight + 4);
            EditorGUI.DrawRect(backgroundRect, headerAttribute.backgroundColor);

            // Draw header text
            Rect headerRect = new Rect(position.x + 4, position.y + 2, position.width, EditorGUIUtility.singleLineHeight);
            EditorGUI.LabelField(headerRect, headerAttribute.header, headerStyle);

            // Reset background color
            GUI.backgroundColor = originalColor;

            // Draw property field
            position.y += EditorGUIUtility.singleLineHeight + 4;
            EditorGUI.PropertyField(position, property, label, true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property) + EditorGUIUtility.singleLineHeight + 4;
        }
    }
}
