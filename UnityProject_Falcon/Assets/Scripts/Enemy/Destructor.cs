using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    /*Script que nos ayuda a mover, rotar los diferentes tipos de enemigos destroyer dependiendo de su tipo
     realiza un movimiento diferente*/

    //Variables
    [SerializeField][Range(1f, 100f)] private float speed = 50f;
    enum ShipType { DesNormal, DesLegendary, DesUltra }
    [SerializeField] ShipType shiptype;

    public Cruiser Transform ;
    

    void Start()
    {
        //Linea del codigo que nos ayuda a localizar la variable de otro script(clase)
        Transform = FindObjectOfType<Cruiser>();
    }

    void Update()
    {
        //Mediante switch escoger el tipo de destructor
        switch (shiptype)
        {
            case ShipType.DesNormal:
                desNormal();
                break;
            case ShipType.DesLegendary:
                DesLegendary();
                break;
            case ShipType.DesUltra:
                DesUltra();
                break;
        }
    }


    //Metodo que nos ayuda a mirar al jugador
    private void LookPlayer()
    {
        transform.LookAt(Transform.playerTransform);
    }

    //Metodo para el movimiento del destructor tipo Normal
    private void desNormal()
    {
        //Debug.Log(Transform);
        LookPlayer();
        Vector3 direction = (Transform.playerTransform.position - transform.position);
        if (direction.magnitude > 100f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

    //Metodo para el movimiento del destructor tipo Ultra
    private void DesUltra()
    {
        LookPlayer();
        Vector3 direction = (Transform.playerTransform.position - transform.position);
        if (direction.magnitude > 150f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

    //Metodo para el movimiento del destructor tipo Legendario
    private void DesLegendary()
    {
        LookPlayer();
        Vector3 direction = (Transform.playerTransform.position - transform.position);
        if (direction.magnitude > 200f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }
}
