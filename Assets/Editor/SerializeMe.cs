using UnityEditor;
using System;
using UnityEngine;

[Serializable]
public struct NestedStruct
{
	[SerializeField]
	float m_StructFloat;

	public void OnGUI ()
	{
		m_StructFloat = EditorGUILayout.FloatField("Struct Float", m_StructFloat);
	}
}

[Serializable]
public class SerializeMe : ScriptableObject
{
	[SerializeField]
	string m_Name;

	[SerializeField]
	int m_Value;

	[SerializeField]
	NestedStruct m_Struct;

	public SerializeMe ()
	{
		m_Struct = new NestedStruct();

		m_Name = "";
	}

	
	[SerializeField]
	NestedClass m_Class;
	
	[SerializeField]
	NestedClass m_Class1;
	
	[SerializeField]
	NestedClass m_Class2;
	
	public void OnEnable()
	{
		hideFlags = HideFlags.HideAndDontSave;
		
		m_Class = ScriptableObject.CreateInstance<NestedClass>();

		if (m_Class1 == null)
		{
			m_Class1 = CreateInstance<NestedClass>();
			m_Class1.copied = true;
			m_Class2 = m_Class1;
		}
	}

	public void OnGUI ()
	{
		m_Name = EditorGUILayout.TextField( "Name", m_Name);
		m_Value = EditorGUILayout.IntSlider ("Value", m_Value, 0, 10);
		
		m_Struct.OnGUI();

		m_Class.OnGUI();

		m_Class1.OnGUI();
		m_Class2.OnGUI();	
	}
}
