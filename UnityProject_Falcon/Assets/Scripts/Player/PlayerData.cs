using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    //Variables globales del jugador y metodos del mismo

    private float live = 1000f;

    private void Update()
    {
        Debug.Log(live);
    }
    public void Hurt(float value)
    {
        live = live - value;
    }
}
