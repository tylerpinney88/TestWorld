using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool Teleported;
    public float Cooldown;
    
    
    // Start is called before the first frame update
    public void Start()
    {
        Cooldown = 3f;
    }

    // Update is called once per frame
    public void Update()
    {
        Countdown();
    }

    void Countdown() 
    {
        if (Teleported == true) 
        {
            Cooldown = Cooldown - Time.deltaTime;
        }

        if (Cooldown <= 0f) 
        {
            Teleported = false;
            Cooldown = 3f;
        }
    }
}
