using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingNumberScript : MonoBehaviour
{
    public Transform numberDrop;
    public GameObject goodFall;
    public GameObject badFall;
    float time = delay;
    //required input values:
    //delay for delay between drops
    //leftSide for x-position of left side of screen
    //rightSide for x-position of right side of screen
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0) {
            int randomDropSpot = Random.Range(leftSide, rightSide);
            instantiate gameObject prefab name;
            time = delay;
        }
        time -= Time.deltaTime;
    }
}
