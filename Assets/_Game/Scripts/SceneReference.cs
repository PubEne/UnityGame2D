using System;
using JetBrains.Annotations;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

#endif

[Serializable]
public sealed class SceneReference : ISerializationCallbackReceiver
{
#if UNITY_EDITOR
    [SerializeField]
    private SceneAsset _asset; // hidden by the drawer
#endif

    [SerializeField]
    private string _path; // hidden by the drawer

    [PublicAPI]
    public string Path => _path;

    #region ISerializationCallbackReceiver Members

    public void OnAfterDeserialize()
    {
#if UNITY_EDITOR
        EditorApplication.delayCall += () => { _path = _asset == null ? string.Empty : AssetDatabase.GetAssetPath(_asset); };
#endif
    }

    public void OnBeforeSerialize()
    {
    }

    #endregion

    #region Nested type: SceneReferencePropertyDrawer

#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(SceneReference))]
    internal sealed class SceneReferencePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var relative = property.FindPropertyRelative(nameof(_asset));

            var content = EditorGUI.BeginProperty(position, label, relative);

            EditorGUI.BeginChangeCheck();

            var source = relative.objectReferenceValue;
            var target = EditorGUI.ObjectField(position, content, source, typeof(SceneAsset), false);

            if (EditorGUI.EndChangeCheck())
                relative.objectReferenceValue = target;

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight;
        }
    }
#endif

    #endregion
}