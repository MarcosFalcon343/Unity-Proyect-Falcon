using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] Enemy;
    public float cooldown = 30f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemyInvoke", 2f, cooldown);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Random.Range(0, Enemy.Length));
        /*if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }*/
    }

    private void EnemyInvoke()
    {
        Instantiate(Enemy[Random.Range(0, Enemy.Length)], transform);
    }
}
