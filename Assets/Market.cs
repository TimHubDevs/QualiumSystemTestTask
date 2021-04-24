using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Market : MonoBehaviour
{
    [Header("Planes")] 
    [SerializeField] private List<Button> planes;
    
    private MarketButton _selectItem;

    public MarketButton SelectItem
    {
        get { return _selectItem; }
        set { _selectItem = value;
            ChangeBackgroundPlane();
        }
    }

    private void ChangeBackgroundPlane()
    {
        if (planes == null)
        {
            Debug.LogError("Planes null");
            return;
        }
        
        for(int i = 0; i < planes.Count; i++)
        {
            planes[i].GetComponent<MarketButton>().Icon.color = Color.black;
        }
        
        _selectItem.Icon.color = Color.green;
    }
}