using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrcutorShoot : MonoBehaviour
{
    /*Script que nos ayuda a hacer el disparo del Enemigo tipo destructor*/

    public GameObject Desbullet;
    public float cooldown = 3f;


    void Update()
    {
        //Un cooldown para evitar disparos seguidos
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }

    //Cuando un gameobject de tag "player" colisiona con el collider de disparador este dispara un par de bullets
    //cada cierto tiempo
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && cooldown <= 0)
        {
            spawnBulllet();
            cooldown = 3f;
        }
    }

    //Spawnear la Bullet
    private void spawnBulllet()
    {
        Instantiate(Desbullet, transform);
    }
}
