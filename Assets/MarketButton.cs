using UnityEngine;
using UnityEngine.UI;

public class MarketButton : MonoBehaviour
{
    [SerializeField] private Image Icon;
    public bool isSelected = false;
    
    public void SelectColor()
    {
        Icon.color = Color.green;
        isSelected = true;
    }
    
    public void DeselectColor()
    {
        Icon.color = Color.black;
        isSelected = false;
    }

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(()=>SelectColor());
    }
}
