using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RookClass : ChessPiece
{
    public Sprite newSprite;

    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        newSprite = Resources.Load<Sprite>("Rook");
        SpriteRenderer.sprite = newSprite;
        Vector3 firstPoint = new Vector3(transform.position.x, transform.position.y + 7, transform.position.z);
        firstPoints.Add(firstPoint);
        Vector3 leftPoint = new Vector3(transform.position.x - 7, transform.position.y, transform.position.z);
        firstPoints.Add(leftPoint);
        Vector3 rightPoint = new Vector3(transform.position.x + 7, transform.position.y, transform.position.z);
        firstPoints.Add(rightPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
