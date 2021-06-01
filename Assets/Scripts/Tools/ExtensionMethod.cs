using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMehtod
{
    private const float dotThreshold = 0.5f;
    //Extension Method 扩展方法:扩展transform的方法
    public static bool IsFacingTarget(this Transform transform,Transform target)
    {
        var vectorToTarget = target.position - transform.position;
        vectorToTarget.Normalize();

        float dot = Vector3.Dot(transform.forward, vectorToTarget);

        return dot >= dotThreshold;
    }
}
