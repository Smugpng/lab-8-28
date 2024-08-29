using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RookClass : ChessPiece
{
    public Sprite newSprite;
    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        newSprite = Resources.Load<Sprite>("Rook");
        SpriteRenderer.sprite = newSprite;
        horizontalMovement = 8;
        verticalMovement = 8;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
