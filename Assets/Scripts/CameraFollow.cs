using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform playerPosition;
    float cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        cameraOffset = transform.position.x - playerPosition.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (playerPosition.position.x + cameraOffset, transform.position.y, transform.position.z);
    }
}
