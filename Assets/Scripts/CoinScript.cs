using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public Transform player; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,90 * Time.deltaTime,0);
    }
    
   void OnTriggerEnter(Collider other)
   {
       if (other.transform == player)
       {
           ScoreManager.instance.AddPoint();
           Destroy(gameObject);
       }
   }
}

