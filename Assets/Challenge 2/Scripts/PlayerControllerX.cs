using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canSpwan = true;
    private float pressableTime = 3f;

    // Update is called once per frame
    private void Start()
    {
        startCountManager();
    }

    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpwan)
        {
            canSpwan = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    void startCountManager()
    {

        InvokeRepeating("updatePressable", 0f, 1f);
    }

    void updatePressable()

    {
        pressableTime = pressableTime - 1f;
        if (pressableTime == 0f)

        {
            pressableTime = 3f;
            canSpwan = true;
        }
    }
}
