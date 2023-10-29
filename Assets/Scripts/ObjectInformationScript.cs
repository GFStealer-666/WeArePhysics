using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectInformationScript : MonoBehaviour
{
    public GameObject testObject;
    public TextMeshProUGUI nameText, speedText, massText, AxisText;
    float speedNumber = 1, massNumber ;
    int axisNumber = 1;
    Rigidbody testRigidbody;
    bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        testRigidbody = testObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        testRigidbody.mass = massNumber;
        nameText.text = testObject.name;
        speedText.text = "Speed: " + speedNumber;
        massText.text = "Mass: " + massNumber;

        if (isActive == true && axisNumber == 1)
        {
            testObject.transform.position += new Vector3(speedNumber * Time.deltaTime, 0, 0);
        }
        else if (isActive == true && axisNumber == 2)
        {
            testObject.transform.position += new Vector3(0, speedNumber * Time.deltaTime, 0);
        }
        else if (isActive == true && axisNumber == 3)
        {
            testObject.transform.position += new Vector3(0, 0, speedNumber * Time.deltaTime);
        }
    }

    public void goButton()
    {
        isActive = true;

    }

    public void increaseSpeed()
    {
        Debug.Log("PlusSpeed");
        speedNumber += 1;
    }

    public void decreaseSpeed()
    {
        Debug.Log("DecreaseSpeed");
        speedNumber -= 1;
    }

    public void increaseMass()
    {
        Debug.Log("IncreaseMass");
        massNumber += 1;
    }

    public void decreaseMass()
    {
        Debug.Log("DecreaseMass");
        massNumber -= 1;
    }

    public void directionButton(int directionNumber)
    {
        if (directionNumber == 1)
        {
            AxisText.text = "Direction: X";
            axisNumber = 1;
        }
        else if (directionNumber == 2)
        {
            AxisText.text = "Direction: Y";
            axisNumber = 2;
        }
        else if (directionNumber == 3)
        {
            AxisText.text = "Direction: Z";
            axisNumber = 3;
        }
    }


}
