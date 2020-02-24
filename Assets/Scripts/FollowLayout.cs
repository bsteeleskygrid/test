using UnityEngine;
using UnityEngine.UI;

public class FollowLayout : Targetable<RectTransform>
{
    [SerializeField] RectTransform rectTransform;

    protected void LateUpdate()
    {
        DoThisFrameAnimation();
    }

    protected override void OnTargetChanged()
    {
        rectTransform.sizeDelta = target.sizeDelta;
    }

    private void DoThisFrameAnimation()
    {
        //  Todo animated this.
        rectTransform.sizeDelta = target.sizeDelta;
    }
}

