using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    /*Script que nos ayuda a administrar la camaras de la scena*/

    //Variables
    public GameObject[] cameras;
    public GameObject startCamera;
    private int cameraNumber = 0;
    private float cooldown = 3;

    //Variable de estado
    public MoveSR2 start;
    private bool CameraChanse = false;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        /*administrar la camara del start game*/
        cooldown = cooldown - Time.deltaTime;

        //Compruba si el juego fue iniciado, si la camara del start game aun no se ha desactivado
        //y ya paso el tiempo de espera
        if (start.LevelStart == true && CameraChanse == false && cooldown < 0)
        {
            //Desactiva la camara startGame y activa la camara Maincamera
            CameraChanse = true;
            startCamera.SetActive(false);
            cameras[0].SetActive(true);

        }

        //Lineas de codigo que nos ayuda cambiar de camaras durante el juego con la tecla "C"
        if(start.LevelStart == true)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                if (cameraNumber >= cameras.Length - 1)
                {
                    cameras[cameras.Length - 1].SetActive(false);
                    cameraNumber = 0;
                    cameras[cameraNumber].SetActive(true);
                }
                else
                {
                    cameras[cameraNumber].SetActive(false);
                    cameraNumber++;
                    cameras[cameraNumber].SetActive(true);
                }
            }
        }
    }
}
