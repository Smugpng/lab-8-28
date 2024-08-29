using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static ChessPiece;
using static UnityEngine.GraphicsBuffer;

public class ChessPopulate : MonoBehaviour
{
    public float value = 7.0f;
    [SerializeField] private GameObject chessPiece;
    private void Start()
    {

        for (int x = 0; x < 8; x++) 
        {
            if (x == 0 || x == 7) 
            { 
                GameObject rook =  Instantiate(chessPiece, new Vector3(x, 0, 0), Quaternion.identity); 
                ChessPiece gulp = rook.AddComponent<ChessPiece>(); gulp.SetState(PieceType.Rook);
                rook.name = "rook";
            }
            if (x == 1 || x == 6) 
            { 
                GameObject knight = Instantiate(chessPiece, new Vector3(x, 0, 0), Quaternion.identity); 
                ChessPiece gulp = knight.AddComponent<ChessPiece>(); gulp.SetState(PieceType.Knight);
                knight.name = "knight";
            }
            if (x == 2 || x == 5) 
            { 
                GameObject bishop = Instantiate(chessPiece, new Vector3(x, 0, 0), Quaternion.identity);  
                ChessPiece gulp = bishop.AddComponent<ChessPiece>(); gulp.SetState(PieceType.Bishop);
                bishop.name = "bishop";
            }
            if (x == 3) 
            { 
                GameObject queen = Instantiate(chessPiece, new Vector3(x, 0, 0), Quaternion.identity);
                ChessPiece gulp = queen.AddComponent<ChessPiece>(); gulp.SetState(PieceType.Queen);
                queen.name = "queen";
            }
            if (x == 4) 
            { 
                GameObject king = Instantiate(chessPiece, new Vector3(x, 0, 0), Quaternion.identity);
                ChessPiece gulp = king.AddComponent<ChessPiece>(); gulp.SetState(PieceType.King);
                king.name = "king";
            }
            for (int y = 0; y < 2; y++)
            {
                
                if (y == 1)
                {
                    {
                        GameObject pawn = Instantiate(chessPiece, new Vector3(x, y, 0), Quaternion.identity);
                        ChessPiece gulp = pawn.AddComponent<ChessPiece>(); gulp.SetState(PieceType.Pawn);
                        pawn.name = "pawn";
                    }
                }
               
            }

        }

    }

}
/*[CustomEditor(typeof(ChessPopulate))]
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
}*/
