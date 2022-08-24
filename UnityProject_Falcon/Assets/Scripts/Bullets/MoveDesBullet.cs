using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDesBullet : MonoBehaviour
{
    public float speed = 30f;
    public float destroyTime = 40f;
    public PlayerData playerdata;

    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        //playerdata.Hurt(20);
        CancelInvoke();
        Destroy(gameObject);
    }

    void Start()
    {
        Invoke("destroyDelay", destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}