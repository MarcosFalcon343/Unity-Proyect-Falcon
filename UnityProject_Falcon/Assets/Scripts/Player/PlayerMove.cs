using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Variable global
    public MoveSR2 start;

    //Variables de movimiento
    public float speed;
    public float porcent = 0;

    //Variables de direccion
    public float cameraAxisX = 0f;
    public float cameraAxisY = 0f;

    //Variables de estado
    private byte isTurnOnEngine = 0;
    private byte isEngineReverse = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) Engine();
        if (isTurnOnEngine == 1)
        {
            if (Input.GetKeyDown(KeyCode.R)) reverse();
            if (Input.GetKey(KeyCode.W)) porcentEngine(10);
            if (Input.GetKey(KeyCode.S)) porcentEngine((-10));

            if (isEngineReverse != 1)
            {
                if (porcent > 10 && start.LevelStart == true) moveForward();
            }
        }

    }

    private void moveForward()
    {
        speed = (porcent * 60) / 100;
        rotateShip();
        transform.Translate(Vector3.forward.normalized * speed * Time.deltaTime);
    }
    private void porcentEngine(int num)
    {
        porcent += Time.deltaTime * num;
        if (porcent > 100) porcent = 100;
        if (porcent < 0) porcent = 0;
    }

    private void Engine()
    {
        switch (isTurnOnEngine)
        {
            case 0:
                isTurnOnEngine = 1;
                break;
            case 1:
                isTurnOnEngine = 0;
                break;
        }
    }
    private void reverse()
    {
        switch (isEngineReverse)
        {
            case 0:
                isEngineReverse = 1;
                break;
            case 1:
                isEngineReverse = 0;
                break;
        }
    }

    private void rotateShip()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        cameraAxisY += Input.GetAxis("Mouse Y");
        Quaternion newRotation = Quaternion.Euler(-cameraAxisY, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);

    }

}