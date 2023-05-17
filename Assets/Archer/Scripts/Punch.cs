using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public GameObject player;
    public float xPosition;
    public float yPosition;
    public float zPosition;
    int iteration = 0;
    public bool hasHit = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (iteration == 3)
        {
            player.transform.position = new Vector3(0f, 0.0799998f, 0f);
            Debug.Log("Teleport!");
            iteration = 0;
            // player.transform.localEulerAngles = Vector3.zero;
        }
        if (Input.GetButtonUp("Fire2"))
        {
            hasHit = false;
        }
    }

    private void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.CompareTag("Enemy"))
        {
            if (Input.GetButton("Fire2") && iteration < 3 && hasHit == false)
            {
                enemy.GetComponent<HealthController>().ApplyDamage(10);
                iteration += 1;
                hasHit = true;
            }
        }
    }
}
