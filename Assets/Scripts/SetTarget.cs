using UnityEngine;

public abstract class Targetable<T> : MonoBehaviour, ISetTarget<T>
{
    protected T target;

    public void SetTarget(T newTarget)
    {
        target = newTarget;
        OnTargetChanged();
    }

    protected abstract void OnTargetChanged();
}