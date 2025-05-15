using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] float moveSpeed  = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
         transform.Translate(xValue,yValue,zValue);
    }
   

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use the arrow keys or WASD to move around.");
        Debug.Log("Doont forget to jump!");
    }
}
