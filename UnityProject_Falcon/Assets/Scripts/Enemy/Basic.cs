using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    /*
     Este Script aun no esta en funcionamiento ya que se esta trabajando en el enemigo
     */
    [SerializeField] [Range(1f, 100f)] private float speed = 20f;
    enum ShipType { BasNormal, BasLegendary, BasUltra }
    [SerializeField] ShipType shiptype;

    [SerializeField] private Transform playerTransform;
    private float time;

    //private float time;
    //private float[] cooldowns = { 5 };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (shiptype)
        {
            case ShipType.BasNormal:
                basNormal();
                break;
            case ShipType.BasLegendary:

                break;
            case ShipType.BasUltra:

                break;
        }
    }

    private void basNormal()
    {
        LookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 50f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }
    private void LookPlayer()
    {
        transform.LookAt(playerTransform);
    }
}
