using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class DebugProxyRect : MonoBehaviour
{
    public enum RecycleState
    {
        dormant,
        active
    }
    public RecycleState recycleState;

    [SerializeField] RectTransform rectTransform;

    public void OnDrawGizmos()
    {
        if (recycleState == RecycleState.dormant)
            Gizmos.color = Color.magenta;
        else
            Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(rectTransform.position, rectTransform.sizeDelta);
    }
}