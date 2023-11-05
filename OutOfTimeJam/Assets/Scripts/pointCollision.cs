using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollision : MonoBehaviour
{
    //public ContactFilter2D filter;

    public int points = 0;




// Update is called once per frame
void Update()
    {
    
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<PlayerMovement>())
        {
            points += 1;
        }
        Destroy(col.gameObject);
    }
}