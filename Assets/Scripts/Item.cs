using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*  Exposes the guid.
 *  Exposes the LayoutElement.
 * */
public class Item : MonoBehaviour
{
    public TextMeshProUGUI guid;
    public LayoutElement size;

    // Start is called before the first frame update
    void OnEnable()
    {
        guid = GetComponentInChildren<TextMeshProUGUI>();
        size = GetComponentInChildren<LayoutElement>();
    }
}