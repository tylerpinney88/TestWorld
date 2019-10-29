using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public GameObject AltPortal;
    public GameObject Player;
    public GameObject GameManagerObj;
    public GameManager GM;

    public void Awake()
    {
        GM = GameManagerObj.GetComponent<GameManager>();
          
    }
    public void Start()
    {
       
    }

    public void Update() 
    {
        AltPortalAssignment();

        if (Input.GetKeyDown(KeyCode.T)) 
        {
            TeleportPlayer();
        }
    }

    public void AltPortalAssignment() 
    {
        if (AltPortal == null) 
        {
            if (this.gameObject.tag == "Portal1")
            {
                AltPortal = GameObject.FindGameObjectWithTag("Portal2");
            }
            else
            {
                AltPortal = GameObject.FindGameObjectWithTag("Portal1");
            }
        }
    }

    public void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.tag == "Player" && GM.Teleported == false) 
        {
            Debug.Log("Player seen");
            GM.Teleported = true;
            TeleportPlayer();
        }
    }

    void TeleportPlayer() 
    {
        Player.transform.position = AltPortal.transform.position;
    }

}
