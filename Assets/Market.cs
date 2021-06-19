using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    public List<MarketButton> planes;
    
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
            planes[i].Icon.color = Color.black;
        }
        
        _selectItem.Icon.color = Color.green;
    }
}