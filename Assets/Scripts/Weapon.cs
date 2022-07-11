using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Laser projectile;
    public Transform shootPoint;
    public float speed;

    public void Fire()
    {
        Instantiate(projectile, shootPoint.position, transform.rotation);
    }
}
