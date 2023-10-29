using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction;
using TMPro;

public class ObjectCanvasScript : MonoBehaviour
{
    public TextMeshProUGUI objectName, speedText, massText, directionText;
    int speedNumber = 1, massNumber = 1;
    GameObject objectGame;
    ObjectMoveForward objectMoveForward;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        objectMoveForward = objectGame.GetComponent<ObjectMoveForward>();
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed: " + speedNumber;
        massText.text = "Mass: " + massNumber;
    }

    public void cancelButton()
    {
        gameObject.SetActive(false);
    }

    public void goButton()
    {
        gameObject.SetActive(false);
        objectMoveForward.activeGo();
        
    }

    public void increaseSpeed()
    {
        speedNumber += 1;
    }

    public void decreaseSpeed()
    {
        speedNumber -= 1;
    }

    public void increaseMass()
    {
        massNumber += 1;
    }

    public void decreaseMass()
    {
        massNumber -= 1;
    }

    public void getName(string nameText)
    {
        objectName.text = nameText;
    }

    public void directionButton(int directionNumber)
    {
        if(directionNumber == 1)
        {
            objectMoveForward.getDirection(1);
            directionText.text = "Direction: X";

        }
        else if (directionNumber == 2)
        {
            objectMoveForward.getDirection(2);
            directionText.text = "Direction: Y";

        }
        else if (directionNumber == 3)
        {
            objectMoveForward.getDirection(3);
            directionText.text = "Direction: Z";

        }
    }

    public void getGameObject(GameObject gameObjectnow)
    {
        objectGame = gameObjectnow;
    }
}
