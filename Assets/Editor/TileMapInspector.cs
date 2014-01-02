using UnityEditor;
using UnityEngine;
using System.Collections;


[CustomEditor(typeof(TileMap))]
public class TileMapInspector : Editor {
 
	float v;

	public override void OnInspectorGUI(){
		//base.OnInspectorGUI();
		DrawDefaultInspector ();

		EditorGUILayout.BeginVertical ();
		v = EditorGUILayout.Slider (v, 0, 2.0f);
		EditorGUILayout.EndVertical ();


		if (GUILayout.Button ("Regenerate")) {
			TileMap tileMap = (TileMap)target;
			tileMap.BuildMesh();
		}
	}
}
