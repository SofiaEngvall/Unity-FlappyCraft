using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeaterController : MonoBehaviour
{
    int noOfGroundPieces;
    float groundWidth;
    GameObject[] temp;

    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.FindGameObjectsWithTag("Ground");
        noOfGroundPieces = temp.Length;
        //Debug.Log(noOfGroundPieces);
        groundWidth = temp[0].transform.lossyScale.x;
        //Debug.Log(groundWidth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        Vector3 newPos = collision.transform.position;
        if (collision.tag == "Ground") newPos.x += groundWidth * noOfGroundPieces;
        collision.transform.position = newPos;
    }
}
