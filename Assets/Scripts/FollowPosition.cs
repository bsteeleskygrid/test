using UnityEngine;

public class FollowPosition : Targetable<Transform>
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
        float thisFrameSpeed = CalcThisFrameAnimation(deltaMagnitude);
        Vector3 thisFrameDelta = deltaNormalized * Mathf.Min(thisFrameSpeed, deltaMagnitude);
        this.transform.position = this.transform.position + thisFrameDelta;
    }

    private float CalcThisFrameAnimation(float delta)
    {
        float speedScaler = Mathf.Pow(delta, 1f/1.3f) * .2f;
        float thisFrameSpeed = maxSpeed * speedScaler;
        return thisFrameSpeed * Time.deltaTime;
    }

    protected override void OnTargetChanged()
    {
        this.transform.position = target.position;
    }
}

