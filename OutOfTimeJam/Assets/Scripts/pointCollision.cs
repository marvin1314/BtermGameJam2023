using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollision : MonoBehaviour
{
    public ContactFilter2D filter;
    public Collider2D playerCollider;
    public Collider2D goodCollider;
    public Collider2D floorCollider;



    // Start is called before the first frame update
    void Start()
    {
        filter.NoFilter();
        public int points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (goodCollider.IsTouching(playerCollider, filter))
        {
            givePoint();
        }
        if (goodCollider.IsTouching(playerCollider, filter))
        {
            remove();
        }
    }
    void givePoint()
    {
        points += 1;
        remove();
    }
    void remove()
    {
        //delete this object
    }
}