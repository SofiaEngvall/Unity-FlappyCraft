using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeaterBigController : MonoBehaviour
{
    int noOfBGPieces;
    float bgWidth;
    GameObject[] temp;

    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.FindGameObjectsWithTag("Background");
        noOfBGPieces = temp.Length;
        Debug.Log(noOfBGPieces);
        bgWidth = Mathf.Abs(temp[0].transform.position.x-temp[1].transform.position.x);
        Debug.Log(bgWidth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Vector3 newPos = collision.transform.position;
        if (collision.CompareTag("Background")) newPos.x += bgWidth * noOfBGPieces;
        collision.transform.position = newPos;
    }
}
