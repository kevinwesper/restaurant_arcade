using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    /// <summary>
    /// Total Time of the timer in minutes.
    /// </summary>
    [SerializeField] private float /*int*/ totalTime = 1;                                                                   // !!!! //

    /// <summary>
    /// How much time is remaining in seconds.
    /// </summary>
    private float timeRemaining;

    /// <summary>
    /// Calls Timer coroutine.
    /// <para> Should be called from a different script.</para>
    /// </summary>
    void Start()
    {
        StartCoroutine(StartTimer(totalTime * 60f));
    }

    /// <summary>
    /// Countdown Timer.
    /// <para>Should probably be attached to a working clock.</para>
    /// </summary>
    /// <param name="_totalTime">Timer time in seconds.</param>
    /// <returns></returns>
    public IEnumerator StartTimer(float _totalTime)
    {
        timeRemaining = _totalTime;

        while (timeRemaining > 0)
        {
            Debug.Log("Countdown: " + timeRemaining);
            yield return new WaitForSeconds(1.0f);
            timeRemaining--;
        }
        Debug.Log("Timer finished");
    }
}
