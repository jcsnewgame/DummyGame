using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    public Score score;

    private void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.CompareTag("Enemy"))
        {
            enemy.GetComponent<HealthController>().ApplyDamage(10);
            Destroy(gameObject);
            score.AddScore(10);
        }
    }
}
