using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDesBullet : MonoBehaviour
{
    public float speed = 30f;
    public float destroyTime = 40f;
    public PlayerData playerdata;

    
    private void OnTriggerEnter(Collider other)
    {
        //playerdata.Hurt(20);
        /*Metodo que cuando la Bullet coliciona con un gameobject se destruye y se cancela el invoke*/
        CancelInvoke();
        Destroy(gameObject);
    }

    void Start()
    {
        //Si el bullet no colisiona se aplica el invoke para borrar la bullet en cierto tiempo
        Invoke("destroyDelay", destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    //Metodo para mover la bullet derecho
    private void move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}