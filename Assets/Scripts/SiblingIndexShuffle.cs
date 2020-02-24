using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

/*
 * This is a quick implementation; simulates the indeces changing when the data is changed.
 * Items will follow their target
 * */
public class SiblingIndexShuffle : MonoBehaviour
{
    [SerializeField] RectTransform proxyRoot;

    void Start()
    {
        StartCoroutine(ReverseRoutine());
    }

    private IEnumerator ReverseRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Randomize();
        }
    }

    /// <summary>
    /// I understand caching is better than lots of GetComponent calls.
    /// </summary>
    private void Randomize()
    {
        List<Transform> children = new List<Transform>();
        proxyRoot.GetTransformsInOnlyChildren(children);
        //List<DeltaPositionBroadcaster> allBroadcasters = new List<DeltaPositionBroadcaster>();
        //proxyRoot.GetComponentsInChildren<DeltaPositionBroadcaster>(allBroadcasters);
        var indeces = GenerateIndexList(children.Count);
        RandomizeIndeces(indeces);
        SetNewSiblingIndeces(children, indeces);
        //LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)proxyRoot.root);
        //allBroadcasters.ForEach(x => x.UpdateCurrentPositionSansEvent());    //  Turn broadcasting back on
        Debug.Log("Randomized sibling order of children inside ProxyRoot!  Watch the Items animate to their target proxy transform!");
    }

    private List<int> GenerateIndexList(int count)
    {
        List<int> indeces = new List<int>();
        for (int i = 0; i < count-1; i++)
        {
            indeces.Add(i);
        }
        return indeces;
    }

    private void RandomizeIndeces(List<int> indeces)
    {
        for (int i = 0; i < 99; i++)
        {
            int randomIndex = UnityEngine.Random.Range(0, indeces.Count-1);
            //  Swap random with last.
            int a = indeces[indeces.Count - 1];
            int b = indeces[randomIndex];
            indeces[indeces.Count - 1] = b;
            indeces[randomIndex] = a;
        }
    }

    private void SetNewSiblingIndeces(List<Transform> children, List<int> indeces)
    {
        for (int i = 0; i < children.Count -1; i++)
        {
            var child = children[i];
            var index = indeces[i];
            child.SetSiblingIndex(index);
        }
    }
}
