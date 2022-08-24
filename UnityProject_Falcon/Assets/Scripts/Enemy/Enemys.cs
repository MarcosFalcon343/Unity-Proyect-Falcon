using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    /*Script que no esta en uso solo para verificar posibles el codigo no es elaborado por mi es de la clase del 
     docente, USO UNICO PARA VERIFICAR*/
    [SerializeField] [Range(1f, 100f)] private float speed = 20f;
    enum ShipType { SX1,SX2, Cruiser}
    [SerializeField] ShipType shiptype;

    [SerializeField] private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (shiptype)
        {
            case ShipType.Cruiser:
                aroundPlayer();
                break;
            case ShipType.SX1:
                followPlayer();
                break;
            case ShipType.SX2:
                moveForward();
                break;
        }
    }

    private void moveForward()
    {
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 15f)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }
    private void aroundPlayer()
    {
        LookPlayer();
        transform.RotateAround(playerTransform.position, Vector3.up, 2f * Time.deltaTime);
    }
    private void followPlayer()
    {
        LookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 15f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

    private void LookPlayer()
    {
        transform.LookAt(playerTransform);
    }
}
