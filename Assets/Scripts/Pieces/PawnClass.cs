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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
