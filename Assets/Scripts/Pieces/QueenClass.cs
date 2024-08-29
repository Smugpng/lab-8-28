using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class QueenClass : ChessPiece
{
    public Sprite newSprite;
    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        newSprite = Resources.Load<Sprite>("Queen");
        SpriteRenderer.sprite = newSprite;
        Vector3 firstPoint = new Vector3(transform.position.x, transform.position.y + 7, transform.position.z);
        firstPoints.Add(firstPoint);
        Vector3 leftPoint = new Vector3(transform.position.x-3, transform.position.y, transform.position.z);
        firstPoints.Add(leftPoint);
        Vector3 rightPoint = new Vector3(transform.position.x+4, transform.position.y, transform.position.z);
        firstPoints.Add(rightPoint);
        Vector3 diagLeft = new Vector3(transform.position.x - 4, transform.position.y+4, transform.position.z);
        firstPoints.Add(diagLeft);
        Vector3 diagRight = new Vector3(transform.position.x + 4, transform.position.y+4, transform.position.z);
        firstPoints.Add(diagRight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
