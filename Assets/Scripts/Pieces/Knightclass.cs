using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Knightclass : ChessPiece
{
    public Sprite newSprite;
    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        newSprite = Resources.Load<Sprite>("Knight");
        SpriteRenderer.sprite= newSprite;
        horizontalMovement = 2;
        verticalMovement = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
