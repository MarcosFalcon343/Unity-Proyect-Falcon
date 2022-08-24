using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSR2 : MonoBehaviour
{
    //Script para mover la Normandy al inicio del juego USO EXCLISIVO DE DECORACION, NO INFLUYE EN EL JUEGO
    

    //Variables de Estado
    [HideInInspector] public bool LevelStart = false;
    [HideInInspector] public bool EngineStart = false;

    //Variables de Movimiento
    [SerializeField] private Transform playerTransform;
    private float[] time = { 5f, 10f };
    private float cooldown;
    

    void Start()
    {

    }

    
    void Update()
    {
        if (LevelStart == true && EngineStart == true)
        {
            if (cooldown <= time[0])
            {
                aroundPlayer();
            }
            else if (cooldown >= time[1])
            {
                Destroy(gameObject);
            }
            else
            {
                transform.Translate(Vector3.forward * 300f * Time.deltaTime);
            }
            cooldown = cooldown + Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && EngineStart == true)
        {
            LevelStart = true;
        }
        else if (Input.GetKeyDown(KeyCode.E )) EngineStart = true;
    }

    private void aroundPlayer()
    {
        transform.RotateAround(playerTransform.position, Vector3.left, 3f * Time.deltaTime);
        transform.Translate(Vector3.forward * 30f * Time.deltaTime);
    }
}
