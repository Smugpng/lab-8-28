using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PawnClass : ChessPiece
{
    public Sprite newSprite;
    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        newSprite = Resources.Load<Sprite>("Pawn");
        SpriteRenderer.sprite = newSprite;
        horizontalMovement = 0;
        verticalMovement = 1;
        Vector3 firstPoint = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        firstPoints.Add(firstPoint);
        firstPoints.Add(new Vector3(firstPoint.x+.2f, firstPoint.y - 1, firstPoint.z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
