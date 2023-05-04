using UnityEngine;

public class ArrowShoot : MonoBehaviour
{
    public GameObject ArrowPrefab;
    RaycastHit hit;
    float range = 1000f;
    public Transform ArrowSpawnPosition;

    void shoot()
    {
        Vector2 ScreenCenter = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);
        if (Physics.Raycast(ray, out hit, range))
        {
            GameObject ArrowInstantiate = GameObject.Instantiate(ArrowPrefab, ArrowSpawnPosition.transform.position, ArrowSpawnPosition.transform.rotation) as GameObject;
            ArrowInstantiate.GetComponent<Arrow>().setTarget(hit.point);
        }

    }
}
