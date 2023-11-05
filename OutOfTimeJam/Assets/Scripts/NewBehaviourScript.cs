using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public ContactFilter2D filter;
    public Collider2D playerCollider;
    public Collider2D badCollider;

    // Start is called before the first frame update
    void Start()
    {
        filter.NoFilter();
    }

    // Update is called once per frame
    void Update()
    {
        if (badCollider.IsTouching(playerCollider, filter))
        {
            die();
        }
    }
    void die()
    {
        Scenemanager.loadSceneAsync(0);
    }
}
