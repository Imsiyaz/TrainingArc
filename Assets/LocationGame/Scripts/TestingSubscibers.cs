using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingSubscibers : MonoBehaviour
{

    private void OnEnable()
    {
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.OnSpacePressed += TestingEvents_OnSpacePressed;
        testingEvents.OnWPressed += TestingEvents_OnWPressed;
 
        Debug.Log("Enabling");
    }

    private void OnDisable()
    {
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.OnWPressed -= TestingEvents_OnWPressed;
        testingEvents.OnSpacePressed += TestingEvents_OnSpacePressed;
        Debug.Log("Disabling");
    }

    private void TestingEvents_OnWPressed(object sender, TestingEvents.OnWKeyPressedEventArgs e)
    {
        Debug.Log("W pressed" + e.key);
    }

    private void TestingEvents_OnSpacePressed(object sender,TestingEvents.OnSpacePressedEvenetArgs e)
    {
        Debug.Log("Button Pressed" + e.spaceCount);
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        //testingEvents.OnSpacePressed -= TestingEvents_OnSpacePressed;
    }

    public void Testing_UnityEvents()
    {
        Debug.Log("Unity Test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
