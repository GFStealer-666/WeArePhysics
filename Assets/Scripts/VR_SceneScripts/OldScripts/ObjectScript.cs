using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectScript : MonoBehaviour
{
    GameObject objectCanvas;
    ObjectCanvasScript objectCanvasScript;
    string nameText;

    private void Awake()
    {
        objectCanvas = GameObject.FindGameObjectWithTag("objectCanvas");
    }

    // Start is called before the first frame update
    void Start()
    {
        nameText = gameObject.name;
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(openObjectCanvas);
        objectCanvasScript = objectCanvas.GetComponent<ObjectCanvasScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void openObjectCanvas(ActivateEventArgs arg)
    {
        if(objectCanvas == false)
        {
            objectCanvas.SetActive(true);
            objectCanvasScript.getName(name);
            objectCanvasScript.getGameObject(gameObject);
        }
    }
}
