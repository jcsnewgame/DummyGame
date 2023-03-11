/* WeaponController.cs */
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField]
    private Weapon weapon;

    [SerializeField]
    private string enemyTag;

    private bool fire;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fire = false;
        }

        if (Input.GetMouseButtonUp(0))
        {
            fire = true;
        }

        if (fire)
        {
            weapon.Fire(enemyTag);

            if (weapon.UseTap())
            {
                fire = false;
            }
        }
    }
}