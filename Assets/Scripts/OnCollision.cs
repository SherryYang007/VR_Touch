using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Time = UnityEngine.Time;

public class OnCollision : MonoBehaviour
{
    // THIS IS AN EVENT PROPERTY
    public UnityEvent OnEnter;
    
    // THIS IS AN EVENT PROPERTY
    public UnityEvent OnExit;

    // THIS IS A BOOLEAN PROPERTY
    public bool isColliding;

    // THIS IS A STRING PROPERTY
    // public string myName;
    
    
    //---------------------------------
    // THIS IS A METHOD
    //---------------------------------
    // WHEN A COLLIDER ENTERS OUR ZONE
    void OnTriggerEnter()
    {
        // Run the OnEnter event
        OnEnter.Invoke();
        
        // Set the isColliding property to true
        isColliding = true;
    }

    //---------------------------------
    // THIS IS A METHOD
    //---------------------------------
    // WHEN A COLLIDER EXITS OUR ZONE
    void OnTriggerExit()
    {
        // Run the OnExit event
        OnExit.Invoke();
        
        // Set the isColliding property to true
        isColliding = false;
    }
    
} 


