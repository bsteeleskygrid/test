using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions
{
    public static void GetTransformsInOnlyChildren(this Transform transform, List<Transform> result)
    {
        foreach (var component in transform.GetComponentsInChildren<Transform>())
        {
            if (component != transform)
                result.Add(component);
        }
    }
}