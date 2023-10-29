using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class VR_SceneCanvasScript : MonoBehaviour
{
    public Transform head;
    public Canvas[] canvasArray;
    public float spawnDistance = 2;
    public InputActionProperty Button;
    bool isOpen = false;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < canvasArray.Length; i++)
        {
            canvasArray[i].gameObject.SetActive(false);
        }
    }

    public void returnMainMenu(Button button)
    {
        if (button.gameObject.name == "NoExitButton")
        {
            //setMenuCanvas(1, 0, false, true);
            openOrCloseCanvas(0, false);
            isOpen = !isOpen;
        }
    }

    //void setMenuCanvas(int canvasNumber,int canvasNumber2, bool canvas1_Status, bool canvas2_Status)
    //{
    //    canvasArray[canvasNumber].gameObject.SetActive(canvas1_Status);
    //    canvasArray[canvasNumber2].gameObject.SetActive(canvas2_Status);
    //}

    private void Update()
    {
        if (Button.action.WasPressedThisFrame())
        {
            isOpen = !isOpen;
            openOrCloseCanvas(0, isOpen);
        }
        canvasArray[0].transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        canvasArray[0].gameObject.transform.LookAt(new Vector3(head.position.x, canvasArray[0].gameObject.transform.position.y, head.position.z));
        canvasArray[0].gameObject.transform.forward *= -1;
    }

    void openOrCloseCanvas(int canvasNumber, bool wantToOpen)
    {
        canvasArray[canvasNumber].gameObject.SetActive(wantToOpen);
    }
}
