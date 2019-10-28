using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public GameObject AltPortal;
    public GameObject Player;

    public void Awake()
    {
     
    }
    public void Start()
    {
       
    }

    public void Update() 
    {
        AltPortalAssignment();
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
        if (col.gameObject.tag == "Player") 
        {
            Debug.Log("Player seen");
            Player.transform.position = AltPortal.transform.position;
        }
    }

}
