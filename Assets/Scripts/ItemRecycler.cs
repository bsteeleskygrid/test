using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemRecycler
{
    public delegate void OnCenterDetectedDelegate();
    public event OnCenterDetectedDelegate OnCenterDetected;

    int numOfIndecesToRenderFromCenter = 5;

    [SerializeField] List<Model> models;
    [SerializeField] ScrollRect scrollRect;

    private int CalculateCenterItem()
    {
        int currentCenterIndex = (int)((models.Count - 1) * scrollRect.verticalNormalizedPosition);
        return currentCenterIndex;
    }

    private MinMax RenderRange(int centerIndex)
    {
        int min = Mathf.Max(0, centerIndex - numOfIndecesToRenderFromCenter);
        int max = Mathf.Min(models.Count - 1, centerIndex + numOfIndecesToRenderFromCenter);
        return new MinMax(min, max);
    }
}