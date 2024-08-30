using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Knightclass : ChessPiece
{
    public Sprite newSprite;

    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        newSprite = Resources.Load<Sprite>("Knight");
        SpriteRenderer.sprite= newSprite;
        Vector3 firstPoint = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        firstPoints.Add(firstPoint);
        secondPoints.Add(new Vector3(firstPoint.x + 1, firstPoint.y, firstPoint.z));
        secondPoints.Add(new Vector3(firstPoint.x - 1, firstPoint.y, firstPoint.z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
