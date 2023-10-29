using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveForward : MonoBehaviour
{
    int speed = 1;
    bool isActive = false;
    int direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true && direction == 1)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if (isActive == true && direction == 2)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        else if (isActive == true && direction == 3)
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
    }

    public void getDirection(int directionNumber)
    {
        direction = directionNumber;
    }

    public void getSpeed(int speedNumber)
    {
        speed = speedNumber;
    }

    public void activeGo()
    {
        isActive = true;
    }
}
