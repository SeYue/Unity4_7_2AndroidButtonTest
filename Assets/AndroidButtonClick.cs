using UnityEngine;
using System.Collections;

public class AndroidButtonClick : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	string m_label = "";

	void OnGUI()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			m_label = "退出";
		}
		if (Input.GetKeyDown(KeyCode.Home))
		{
			m_label = "Home";
		}
		if (GUILayout.Button("退出", GUILayout.ExpandWidth(false)))
		{
			m_label = "退出";
		}
		if (GUILayout.Button("Home", GUILayout.ExpandWidth(false)))
		{
			m_label = "Home";
		}
		GUILayout.Label(m_label, GUILayout.ExpandWidth(false));
	}
}
