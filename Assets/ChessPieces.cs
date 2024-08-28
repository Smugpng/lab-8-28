using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ChessPieces : MonoBehaviour
{
    public float value = 7.0f;
    private void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {

            }
        }
    }
}

[CustomEditor(typeof(ChessPieces))]
public class ExampleEditor : Editor
{
    // Custom in-scene UI for when ExampleScript
    // component is selected.
    public void OnSceneGUI()
    {
        var t = target as ChessPieces;
        var tr = t.transform;
        var pos = tr.position;
        // display an orange disc where the object is
        var color = new Color(1, 0.8f, 0.4f, 1);
        Handles.color = color;
        Handles.DrawLine(pos, new Vector3(pos.x, pos.y+1, pos.z), 2f);
        Handles.DrawLine(pos, new Vector3(pos.x + 2, pos.y, pos.z), 2f);
        // display object "value" in scene
        GUI.color = color;
        Handles.Label(pos, t.value.ToString(t.name));
    }
}