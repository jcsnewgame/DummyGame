using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShoot : MonoBehaviour
{
    public float Range;
    public GameObject Arrow;
    public GameObject Cam;
    
    void shoot()
    {
        RaycastHit hit;
        Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, Range);
        Instantiate(Arrow, hit.point, transform.rotation);
    }
}
    