using UnityEngine;

public class TargetPosition : MonoBehaviour, ISetTarget
{
    public Transform target;

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}