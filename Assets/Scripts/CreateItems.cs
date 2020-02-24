using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This script is a simple example of the item spawn and follow thing I want to do.
 * */
public class CreateItems : MonoBehaviour
{
    [SerializeField] Transform proxyRoot;
    [SerializeField] Transform itemRoot;
    [SerializeField] GameObject itemPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        InstantiateAndFollowAllTargets();
    }

    private void InstantiateAndFollowAllTargets()
    {
        List<Transform> proxies = new List<Transform>();
        proxyRoot.GetTransformsInOnlyChildren(proxies);
        foreach (var proxy in proxies)
            InstantatiateAndFollow(proxy);
        Debug.Log("<color=cyan>Instantiate an item foreach proxy transform, and set the proxy as it's follow target.</color>");
    }

    private void InstantatiateAndFollow(Transform target)
    {
        var copy = Instantiate(itemPrefab);
        copy.transform.parent = itemRoot;
        copy.GetComponent<FollowPosition>().SetTarget(target);
        copy.GetComponent<FollowLayout>().SetTarget(target.GetComponent<RectTransform>());
        copy.GetComponent<Item>().guid.text = target.GetSiblingIndex().ToString();
        //target.GetComponent<DeltaPositionBroadcaster>().OnPositionChanged += copy.GetComponent<DeltaPositionReceiver>().UpdatePosition;
    }

}
