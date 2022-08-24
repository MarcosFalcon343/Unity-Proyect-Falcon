using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /*Script para mover al jugador durante el juego*/

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

    
    void Update()
    {
        //Compruba si se presiona la tecla E para encender o apagar el motor
        if (Input.GetKeyDown(KeyCode.E)) Engine();

        //Si el motor esta encendido realiza las siguientes lineas de codigo
        if (isTurnOnEngine == 1)
        {
            //Comprueba si la reversa esta activada, solo funciona si la nave esta en tierra
            //Reversa aun no activada en esta version de juego
            if (Input.GetKeyDown(KeyCode.R)) reverse();

            //Al ser presionada la tecla W aumenta la potencia del motor
            if (Input.GetKey(KeyCode.W)) porcentEngine(10);

            //Al ser presionada la tecla W disminuye la potencia del motor
            if (Input.GetKey(KeyCode.S)) porcentEngine((-10));

            //Comprueba si la nave no esta en reversa
            if (isEngineReverse != 1)
            {
                //Si la potencia del motor alcanzo al menos el 10% la nave se empezara a moverse
                if (porcent > 10 && start.LevelStart == true) moveForward();
            }
        }

    }

    //Metodo para mover al jugador hacia enfrente con una cierta velociddad dependiendo el porcentaje del motor
    private void moveForward()
    {
        speed = (porcent * 60) / 100;
        rotateShip();
        transform.Translate(Vector3.forward.normalized * speed * Time.deltaTime);
    }

    //Metodo para aumentar o disminiur el poecentaje del motor y establecer el limite
    private void porcentEngine(int num)
    {
        porcent += Time.deltaTime * num;
        if (porcent > 100) porcent = 100;
        if (porcent < 0) porcent = 0;
    }


    //Metodo para verificar el estado del motor
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

    //Metodo para verificar el estado de la reversa
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

    //Metodo para rotar la nave dependiendo del cursor del raton
    private void rotateShip()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        cameraAxisY += Input.GetAxis("Mouse Y");
        Quaternion newRotation = Quaternion.Euler(-cameraAxisY, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);

    }

}