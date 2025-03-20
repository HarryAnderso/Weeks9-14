using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public float timeAnHourTakes = 5;
    public Transform hourHand;
    public Transform minuteHand;

    public float t;
    public int hour = 0;

    public UnityEvent<int> OnTheHour;

    Coroutine clockIsRunning;
    IEnumerator doOneHour;

    private void Start()
    {
       clockIsRunning = StartCoroutine(MoveTheClock());
    }

    private IEnumerator MoveTheClock()
    {
        while (true)
        {
            doOneHour = MoveTheClockHandOneHour();
            yield return StartCoroutine(doOneHour);
        }
        
    }
    //void Update()
    //{
    //    StartCoroutine(MoveTheClockHandOneHour());
    //    t += Time.deltaTime;

    //    if (t > timeAnHourTakes)
    //    {
    //        t = 0;
    //        OnTheHour.Invoke();

    //        hour++;
    //        if (hour == 12)
    //        {
    //            hour = 0;
    //        }
    //    }
    //}
    private IEnumerator MoveTheClockHandOneHour()
    {
        t = 0;
        while (t > timeAnHourTakes)
        {
            t += Time.deltaTime;
            minuteHand.Rotate(0, 0, -(360 / timeAnHourTakes)*Time.deltaTime);
            hourHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null;
        }
        OnTheHour.Invoke();
    }

    public void StopTheClock()
    {
        if (clockIsRunning != null)
        {
            StopCoroutine(clockIsRunning);
        }
        if (doOneHour !=null)
        {
            StopCoroutine(doOneHour);
        }
    }
}
