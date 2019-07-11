using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float timeIncrease = 2;
    public bool timeElapsed = false;

    public int items;

    private float timeRemaining;

    void Start()
    {
        //The timer, as a child of this gameobject, receive this and start the countdown using the timeRemaining variable
        BroadcastMessage("Start Timer", timeRemaining);
    }

    //If the game controller receives this signal from the timer, it will end the game
    void timeHasElapsed()
    {
        timeElapsed = true; // game over 
    }
}
