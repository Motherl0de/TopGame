using System;
using System.Collections;
using UnityEngine;

public class Day_Night : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return DayNight();
    }

    private IEnumerator DayNight()
    {
        var t = TimeSpan.Zero;
        var duration = TimeSpan.FromSeconds(25);
        var delta = TimeSpan.FromSeconds(Time.fixedDeltaTime);
        var origin = transform.rotation;
        var target = Quaternion.Euler(origin.x,origin.y + -127.20f,origin.z);
        while (true)
        {
            yield return new WaitForSecondsRealtime(60f);
            while (t <= duration)
            {
                yield return new WaitForSecondsRealtime(Time.fixedDeltaTime);
                transform.rotation = Quaternion.Slerp(origin,target,(float)(t / duration));
                t += delta;
            }

            (target, origin) = (origin, target);
            t = TimeSpan.Zero;
        }
    }
}
