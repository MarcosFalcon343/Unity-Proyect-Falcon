using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] cameras;
    public GameObject startCamera;
    private int cameraNumber = 0;
    private float cooldown = 3;

    //Variable de estado
    public MoveSR2 start;
    private bool CameraChanse = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown = cooldown - Time.deltaTime;
        if (start.LevelStart == true && CameraChanse == false && cooldown < 0)
        {
            CameraChanse = true;
            startCamera.SetActive(false);
            cameras[0].SetActive(true);

        }
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
