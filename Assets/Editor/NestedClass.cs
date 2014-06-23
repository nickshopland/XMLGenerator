using UnityEngine;
using System;
using UnityEditor;

[Serializable]
public class NestedClass : ScriptableObject
{
	[SerializeField]
	float m_ClassFloat;

	public bool copied { get; set; }

	public void OnGUI()
	{
		m_ClassFloat = EditorGUILayout.FloatField("Class Float " + (copied ? "copied" : "unique"), m_ClassFloat);
	}
}
