using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoardGen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++) 
            {
                if (Gizmos.color != Color.white && y!=0)
                {
                    Gizmos.color = Color.white;
                }
                else if( y != 0)
                {
                    Gizmos.color = Color.black;
                }
                Gizmos.DrawCube(new Vector3(x, y, 0), new Vector3(1, 1, 1));
            }
            
        }

    }
}
