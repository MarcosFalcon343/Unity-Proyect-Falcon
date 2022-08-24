using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cruiser : MonoBehaviour
{
    /*Script que nos ayuda a rotar el crucero alrededor del mapa */
    public Transform target;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aroundPlayer();
    }

    private void aroundPlayer()
    {
        transform.RotateAround(target.position, Vector3.up, 0.5f * Time.deltaTime);
    }

}
