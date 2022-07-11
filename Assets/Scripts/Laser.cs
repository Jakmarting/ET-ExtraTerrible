using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public string type;
    public GameObject impact;

    private float laserLife = 1f;
    private float laserSpeed = 10f;
    private float angle = 0f;

    public void SetSpeed(float s)
    {
        laserSpeed= s;
    }
    void DoMovement()
    {
        transform.Translate(Quaternion.Euler(0, 0, angle) * new Vector3(laserSpeed, 0, 0) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null) return;
        if(collision.tag == "Soldier")
        {
            if (impact == null) return;
            Instantiate(impact, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        Destroy(gameObject, laserLife);
    }

    void Update()
    {
        DoMovement();
    }
}
