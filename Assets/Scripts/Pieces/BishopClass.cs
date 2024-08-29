using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ChessPiece))]
public class BishopClass : ChessPiece
{
    public Sprite newSprite;
    private SpriteRenderer SpriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer.sprite = newSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
