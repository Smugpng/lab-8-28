using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[ExecuteInEditMode]
public class ChessPiece : MonoBehaviour
{
    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    };
    public PieceType type;  
    protected Sprite Sprite;
    public float value =1;
    [SerializeField] protected int horizontalMovement;
    [SerializeField] protected int verticalMovement;
    protected Vector3 startingPoint;
    protected List<Vector3> firstPoints = new List<Vector3>();
    protected List<Vector3> secondPoints = new List<Vector3>();

    public void SetState(PieceType newType)
    {
        startingPoint = this.transform.position;
        type = newType;
        SetUp();
    }
    // Method to set up values; can be overridden by derived classes
    protected virtual void SetUp()
    {
        switch (type)
        {
            case PieceType.Pawn:
                this.AddComponent<PawnClass>();
                break;
            case PieceType.Rook:
                this.AddComponent<RookClass>();
                break;
            case PieceType.Bishop:
                this.AddComponent<BishopClass>();
                break;
            case PieceType.Knight:
                this.AddComponent<Knightclass>();
                break;
            case PieceType.Queen:
                this.AddComponent<QueenClass>();
                break;
            case PieceType.King:
                this.AddComponent<KingClass>();
                break;
        };
        
    }
   
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        foreach(Vector3 point in firstPoints)
        {
            Gizmos.DrawLine(this.transform.position, point);
            foreach (Vector3 secondPoint in secondPoints)
            {
                Gizmos.color = Color.yellow;
                Gizmos.DrawLine(point, secondPoint);
            }
        }
        
    }
}
[CustomEditor(typeof(ChessPiece))]
public class ExampleEditor : Editor
{
    // Custom in-scene UI for when ExampleScript
    // component is selected.
    public void OnSceneGUI()
    {
        var t = target as ChessPiece;
        var tr = t.transform;
        var pos = tr.position;
        // display an orange disc where the object is
        var color = new Color(1, 0.8f, 0.4f, 1);
        Handles.color = color;
        Handles.DrawWireDisc(pos, tr.forward, .5f);
        // display object "value" in scene
        GUI.color = color;
        Handles.Label(pos, t.value.ToString("F1"));
    }
}