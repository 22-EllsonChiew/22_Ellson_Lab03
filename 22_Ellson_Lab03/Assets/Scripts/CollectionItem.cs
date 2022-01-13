using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionItem : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        
        
            Debug.Log("1");
            Destroy(gameObject);
        
        
    }
}
