using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayeSitScript : MonoBehaviour
{
    public GameObject Player;
    public InputActionProperty Button;
    bool isStanding = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Button.action.WasPressedThisFrame() && isStanding==true)
        {
            Player.gameObject.transform.position = new Vector3(Player.gameObject.transform.position.x, -0.50f, Player.gameObject.transform.position.z);
            isStanding = false;
        }
        else if(Button.action.WasPressedThisFrame() && isStanding == false)
        {
            Player.gameObject.transform.position = new Vector3(Player.gameObject.transform.position.x, 0, Player.gameObject.transform.position.z);
            isStanding = true;
        }

        if (Player.gameObject.transform.position.y > 0)
        {
            Player.gameObject.transform.position = new Vector3(Player.gameObject.transform.position.x, 0, Player.gameObject.transform.position.z);
        }
        else if (Player.gameObject.transform.position.y < -0.50f && isStanding == false)
        {
            Player.gameObject.transform.position = new Vector3(Player.gameObject.transform.position.x, -0.50f, Player.gameObject.transform.position.z);

        }
        else if (Player.gameObject.transform.position.y < -0.50f && isStanding == true)
        {
            Player.gameObject.transform.position = new Vector3(Player.gameObject.transform.position.x, 0, Player.gameObject.transform.position.z);

        }
    }
}
