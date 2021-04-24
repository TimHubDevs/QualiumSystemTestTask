using UnityEngine;
using UnityEngine.UI;

public class MarketButton : MonoBehaviour
{
    [SerializeField] public Image Icon;
    [SerializeField] private Market _market;
    private MarketButton marketButton;

    public MarketButton()
    {
        marketButton = this;
    }

    public void Subscribe()
    {
        _market.SelectItem = marketButton;
    }
}