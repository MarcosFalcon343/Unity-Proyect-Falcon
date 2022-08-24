using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Variables
    public float speed = 20f;
    public float destroyTime = 4f;
    

    private void OnTriggerEnter(Collider other)
    {
        /*Metodo que cuando la Bullet coliciona con un gameobject se destruye*/
        //playerdata.Hurt(20);
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
    private void destroyDelay()
    {
        Destroy(gameObject);
    }
}
