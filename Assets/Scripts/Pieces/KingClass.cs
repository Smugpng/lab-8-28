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
        Vector3 firstPoint = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        firstPoints.Add(firstPoint);
        Vector3 leftPoint = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        firstPoints.Add(leftPoint);
        Vector3 rightPoint = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        firstPoints.Add(rightPoint);
    }
}
