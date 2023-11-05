using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingNumberScript : MonoBehaviour
{
    public GameObject goodFall;
    public GameObject badFall;
    float time;
    public float delay;
    public int leftSide;
    public int rightSide;
    public int topScreen;
    //required input values:
    //delay for delay between drops
    //leftSide for x-position of left side of screen
    //rightSide for x-position of right side of screen
    //topScreen for y-position of the top of the screen
    
    // Start is called before the first frame update
    void Start()
    {
        time = delay;
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0) {
            int randomDropSpot = Random.Range(leftSide, rightSide);
            int randomItem = Random.Range(1,3);
            if (randomItem < 3)
            {
                Instantiate(goodFall, new Vector2(randomDropSpot,topScreen), Quaternion.identity);
            }
            else {
                Instantiate(badFall, new Vector2(randomDropSpot, topScreen), Quaternion.identity);
            }
            time = delay;
        }
        time -= Time.deltaTime;
    }
}
