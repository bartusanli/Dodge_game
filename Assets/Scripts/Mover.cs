using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed;
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
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using W A S D !");
        Debug.Log("Don't bunpinto objects!");
    }

    void MovePlayer()
    {
         float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed ,
               yValue =0f,
               zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
