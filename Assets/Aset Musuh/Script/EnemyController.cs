using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float zPosition = 9f;
    public float zPastPosition = -9f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < zPastPosition)
        {
            transform.position = new Vector3(0, transform.position.y, zPosition);
        }
    }
}
