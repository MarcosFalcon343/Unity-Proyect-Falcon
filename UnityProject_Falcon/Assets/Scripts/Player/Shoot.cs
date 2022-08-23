using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;

    public MoveSR2 start;
    // Start is called before the first frame update
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
