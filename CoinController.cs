using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinController : MonoBehaviour
{
    public static CoinController instanse;

    [SerializeField] private int _coins;
    [SerializeField] private TextMeshProUGUI _coinsAmountText;
    void Awake()
    {
        if(instanse == null)
        {
            instanse = this;
        }
    }
    public void CoinCounter(int coinAmount)
    {
        _coins+=coinAmount;
        _coinsAmountText.text = _coins.ToString();
        Debug.Log(_coins);
    }
}
