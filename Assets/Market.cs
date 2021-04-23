using UnityEngine;

public class Market : MonoBehaviour
{
    [Header("Planes")]
    [SerializeField]
    private MarketButton[] Planes;

    private int a = 0;
    
    private Sprite playerPlane;

    private void Update()
    {
        ChangeBackgroundPlane();
    }

    private void ChangeBackgroundPlane()
    {
        for (int i = 0; i < Planes.Length; i++)
        {
            if (Planes[i].isSelected == true)
            {
                a++;
                if (a > 1)
                {
                    Planes[i].DeselectColor();
                    a--;
                }
            }
        }
        
    }
}
