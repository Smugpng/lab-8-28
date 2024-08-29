using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopClass : ChessPiece
{
    public Sprite newSprite;
    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        newSprite = Resources.Load<Sprite>("Bishop");
        SpriteRenderer.sprite = newSprite;
        horizontalMovement = 8;
        verticalMovement = 8;
    }
}
