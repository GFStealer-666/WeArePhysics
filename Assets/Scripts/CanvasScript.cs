using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public Canvas[] canvasArray ;

    void Start()
    {
        for(int i = 1; i < canvasArray.Length; i++)
        {
            canvasArray[i].gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openPlayMenu()
    {
        setMenuCanvas(1, 0, true, false);
    }

    public void openOptionMenu()
    {
        setMenuCanvas(2, 0, true, false);
    }

    public void openExitMenu()
    {
        setMenuCanvas(3, 0, true, false);
    }

    public void openSandboxMenu()
    {
        setMenuCanvas(4, 1, true, false);
    }

    public void closeSandboxMenu()
    {
        setMenuCanvas(1, 4, true, false);
    }

    public void returnMainMenu(Button button)
    {
        if (button.gameObject.name == "ClosePlayButton")
        {
            setMenuCanvas(1, 0,false, true);
        }
        else if (button.gameObject.name == "CloseOptionButton")
        {
            setMenuCanvas(2, 0, false, true);
        }
        else if (button.gameObject.name == "NoExitButton")
        {
            setMenuCanvas(3, 0, false, true);
        }
    } 

    void setMenuCanvas(int canvasNumber, int canvasNumber2,bool canvas1_Status, bool canvas2_Status)
    {
        canvasArray[canvasNumber].gameObject.SetActive(canvas1_Status);
        canvasArray[canvasNumber2].gameObject.SetActive(canvas2_Status);
    }
}
