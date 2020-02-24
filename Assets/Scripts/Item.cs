using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*  Exposes the guid.
 *  Exposes the LayoutElement.
 * */
[RequireComponent(typeof(TextMeshProUGUI))]
 [RequireComponent(typeof(LayoutElement))]
public class Item : MonoBehaviour
{
    public TextMeshProUGUI guid;
    public LayoutElement size;

    // Start is called before the first frame update
    void Start()
    {
        guid = GetComponent<TextMeshProUGUI>();
        size = GetComponent<LayoutElement>();
    }
}