using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KingClass : ChessPiece
{
    public Sprite newSprite;
    private SpriteRenderer SpriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        newSprite = Resources.Load<Sprite>("King");
        SpriteRenderer.sprite = newSprite;
        horizontalMovement = 1;
        verticalMovement = 1;
    }
}
