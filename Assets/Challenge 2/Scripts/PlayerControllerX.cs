using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time;
    public float timer;

    // Update is called once per frame
    void Update()
    {
        time = 2;
       

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spawnDog();
                timer = time;
            }
            
        }
    }


    void spawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
