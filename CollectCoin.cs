using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] private int _coins;
   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.CompareTag("CoinAmount5"))
       {
            CoinController.instanse.CoinCounter(5);
            Destroy(other.gameObject); 
       }
       else if(other.gameObject.CompareTag("CoinAmount25"))
       {
            CoinController.instanse.CoinCounter(25);
            Destroy(other.gameObject); 
       }
       else if(other.gameObject.CompareTag("CoinAmount100"))
       {
            CoinController.instanse.CoinCounter(100);
            Destroy(other.gameObject); 
       }
       else if(other.gameObject.CompareTag("CoinAmount500"))
       {
            CoinController.instanse.CoinCounter(500);
            Destroy(other.gameObject); 
       }
   }
}
