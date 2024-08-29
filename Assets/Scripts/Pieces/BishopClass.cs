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
        Vector3 diagLeft = new Vector3(transform.position.x - 5, transform.position.y + 5, transform.position.z);
        firstPoints.Add(diagLeft);
        Vector3 diagRight = new Vector3(transform.position.x + 5, transform.position.y + 5, transform.position.z);
        firstPoints.Add(diagRight);
    }
}
