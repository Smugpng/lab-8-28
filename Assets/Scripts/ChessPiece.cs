using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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

    [SerializeField] protected int horizontalMovement;
    [SerializeField] protected int verticalMovement;

    public void SetState(PieceType newType)
    {
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
        Vector3 firstPoint = new Vector3(this.transform.position.x, this.transform.position.y + verticalMovement, this.transform.position.z);
        Vector3 lastPoint = new Vector3(firstPoint.x + horizontalMovement, firstPoint.y, firstPoint.z);
        Gizmos.DrawLine(this.transform.position, firstPoint);
        Gizmos.DrawLine(firstPoint, lastPoint);
    }
}
