using UnityEngine;

public class FollowPosition : TargetPosition
{
    [SerializeField] float maxSpeed = .5f;  // Over 60 frames or 1 second, will move 30 units

    public void LateUpdate()
    {
        DoThisFrameAnimation();
    }

    private void DoThisFrameAnimation()
    {
        Vector3 deltaPosition = target.position - this.transform.position;
        Vector3 deltaNormalized = deltaPosition.normalized;
        float deltaMagnitude = deltaPosition.magnitude;
        float speedScaler = Mathf.Sqrt(deltaMagnitude) / (Mathf.Sqrt(deltaMagnitude) + 1f);
        float thisFrameSpeed = maxSpeed * speedScaler;
        thisFrameSpeed = thisFrameSpeed * Time.deltaTime; // ?
        Vector3 thisFrameDelta = deltaNormalized * Mathf.Min(thisFrameSpeed, deltaMagnitude);

        this.transform.position = this.transform.position + thisFrameDelta;
    }
}