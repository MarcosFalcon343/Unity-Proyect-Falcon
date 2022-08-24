using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //Script para el player al presionar espacio dispare
    public GameObject bullet;

    public MoveSR2 start;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(start.LevelStart == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spawnBulllet();
            }
        }
        
    }

    private void spawnBulllet()
    {
        Instantiate(bullet, transform);
    }
}
