using UnityEngine;

public class DeltaPositionReceiver : MonoBehaviour
{
    public void UpdatePosition(Vector3 delta)
    {
        this.transform.position = this.transform.position + delta;
    }
}
