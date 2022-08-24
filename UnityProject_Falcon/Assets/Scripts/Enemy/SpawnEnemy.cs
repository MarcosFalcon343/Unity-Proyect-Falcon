using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    /*Script que nos ayuda a spawnear enemigos aleatoriamente en el spawn del crucero*/

    //Variables
    public GameObject[] Enemy;
    public float cooldown = 30f;


    void Start()
    {
        //Invoca un enemigo cada cierto tiempo
        InvokeRepeating("EnemyInvoke", 2f, cooldown);
    }

    
    void Update()
    {
        
    }

    //Metodo para instanciar al enemigo aleatoriamente
    private void EnemyInvoke()
    {
        Instantiate(Enemy[Random.Range(0, Enemy.Length)], transform);
    }
}
