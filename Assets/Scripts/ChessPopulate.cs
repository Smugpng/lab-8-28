using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ChessPopulate : MonoBehaviour
{
    public float value = 7.0f;
    private void OnDrawGizmos()
    {

        for (int x = 0; x < 8; x++) 
        {
            if (x == 0 || x == 7) { Gizmos.DrawIcon(new Vector3(x, 0, 0), "Rook.png", true); }
            if (x == 1 || x == 6) { Gizmos.DrawIcon(new Vector3(x, 0, 0), "Knight.png", true); }
            if (x == 2 || x == 5) { Gizmos.DrawIcon(new Vector3(x, 0, 0), "Bishop.png", true); }
            if (x == 3) { Gizmos.DrawIcon(new Vector3(x, 0, 0), "Queen.png", true); }
            if (x == 4) { Gizmos.DrawIcon(new Vector3(x, 0, 0), "King.png", true); }
            for (int y = 0; y < 2; y++)
            {
                
                if (y == 1)
                {
                    Gizmos.DrawIcon(new Vector3(x, y, 0), "Pawn.png", true);
                }
               
            }

        }

    }

}
[CustomEditor(typeof(ChessPopulate))]
public class ExampleEditor : Editor
{
    // Custom in-scene UI for when ExampleScript
    // component is selected.
    public void OnSceneGUI()
    {
        var t = target as ChessPopulate;
        var tr = t.transform;
        var pos = tr.position;
        // display an orange disc where the object is
        var color = new Color(1, 0.8f, 0.4f, 1);
        Handles.color = color;
        Handles.DrawWireDisc(pos, tr.up, 1.0f);
        // display object "value" in scene
        GUI.color = color;
        Handles.Label(pos, t.value.ToString("F1"));
    }
}
