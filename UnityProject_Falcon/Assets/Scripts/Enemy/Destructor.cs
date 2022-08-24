using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    [SerializeField][Range(1f, 100f)] private float speed = 50f;
    enum ShipType { DesNormal, DesLegendary, DesUltra }
    [SerializeField] ShipType shiptype;

    public Cruiser Transform ;
    
    // Start is called before the first frame update
    void Start()
    {
        Transform = FindObjectOfType<Cruiser>();
    }

    // Update is called once per frame
    void Update()
    {
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

    private void LookPlayer()
    {
        transform.LookAt(Transform.playerTransform);
    }
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

    private void DesUltra()
    {
        LookPlayer();
        Vector3 direction = (Transform.playerTransform.position - transform.position);
        if (direction.magnitude > 150f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

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
