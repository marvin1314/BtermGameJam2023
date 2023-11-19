using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointCollision : MonoBehaviour
{
    //public ContactFilter2D filter;
    public TextMeshProUGUI score;
    public int points = 0;

    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
    
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        Destroy(gameObject);
    }
}