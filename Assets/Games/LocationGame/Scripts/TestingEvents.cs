using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Events;

public class TestingEvents : MonoBehaviour
{
    public event EventHandler<OnSpacePressedEvenetArgs> OnSpacePressed;
    public event EventHandler<OnWKeyPressedEventArgs> OnWPressed;
    private int spaceCount;

    public UnityEvent onUnityEvents;
    string key = "lol";

    public class OnSpacePressedEvenetArgs : EventArgs
    { 
        public int spaceCount;
        public int spaceCount1;
        public int spaceCount2;
    }

    public class OnWKeyPressedEventArgs : EventArgs 
    {
        public string key;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceCount++;
            // ?.Invoke means the same thing as != null
            OnSpacePressed?.Invoke(this, new OnSpacePressedEvenetArgs { spaceCount = spaceCount });

            onUnityEvents?.Invoke();
            
        }

        if(Input.GetKeyDown(KeyCode.W)) 
        {
            OnWPressed?.Invoke(this, new OnWKeyPressedEventArgs { key = key });
        }
    }
}
