using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider enemy)
    {
        if(enemy.gameObject.CompareTag("Enemy"))
        {
            Destroy(enemy.gameObject);
        }
    }
}
