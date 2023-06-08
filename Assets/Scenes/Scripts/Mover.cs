using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //This controls the speed of player
    [SerializeField]float moveSpeed=10f;

    // Start is called before the first frame update
    void Start()
    {
       PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Bro! Play Nice!");
    }

    void MovePlayer()
    {
        float xVar=Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zVar=Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xVar, 0 ,zVar);
    }
}