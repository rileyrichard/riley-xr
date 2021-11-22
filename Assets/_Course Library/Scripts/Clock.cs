using UnityEngine;
using System;

public class Clock : MonoBehaviour {

    private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;

    void Update () {
        DateTime timespan = DateTime.Now;
        hours.localRotation = Quaternion.Euler(((float)timespan.Hour - 14) * -hoursToDegrees,0f,-90f);
        minutes.localRotation = Quaternion.Euler(((float)timespan.Minute - 15) * -minutesToDegrees,0f,-90f);
        seconds.localRotation = Quaternion.Euler(((float)timespan.Second - 15)* -secondsToDegrees,0f,-90f);
    }
}