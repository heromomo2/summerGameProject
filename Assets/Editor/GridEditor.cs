using UnityEngine;
using UnityEditor;

using System.Collections;

[CustomEditor(typeof(Grid))]

public class GridEditor : Editor {
	Grid grid;


	void OnEnable(){
		grid = (Grid)target;
	}

	public override void OnInspectorGUI(){
		//base.OnInspectorGUI ();
		GUILayout.BeginHorizontal();
		GUILayout.Label ("Grid Width");
		grid.width = EditorGUILayout.Slider (grid.width, 1.0f, 100.0f, null);
		GUILayout.EndHorizontal ();
		
	}
	private float createslider(string LabelName,){
	}

}
