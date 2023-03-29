using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour

{
    // public Score score;
    private void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.CompareTag("Enemy"))
        {
            enemy.GetComponent<HealthController>().ApplyDamage(100);
            Destroy(gameObject);
            // score.AddScore(100);
        }
    }

    // void Update()
    // {
    //     score.AddScore(100);
    // }
}
