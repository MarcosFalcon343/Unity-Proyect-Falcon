using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrcutorShoot : MonoBehaviour
{
    public GameObject Desbullet;
    public float cooldown = 3f;


    // Start is called before the first frame update
    void Update()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && cooldown <= 0)
        {
            spawnBulllet();
            cooldown = 3f;
        }
    }
    private void spawnBulllet()
    {
        Instantiate(Desbullet, transform);
    }
}
