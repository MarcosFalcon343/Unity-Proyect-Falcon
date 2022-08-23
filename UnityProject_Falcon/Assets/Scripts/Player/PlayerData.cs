using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Start is called before the first frame update
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
