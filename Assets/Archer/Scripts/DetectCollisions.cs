using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public float damageValue = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.CompareTag("Enemy"))
        {
            enemy.GetComponent<HealthController>().ApplyDamage(damageValue);
            Destroy(gameObject);
        }
        Destroy(gameObject);

        // if (enemy.gameObject.CompareTag("DestroyArrow"))
        // {
        //     Destroy(gameObject);
        // }
    }
}
