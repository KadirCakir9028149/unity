using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f; 
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    PrintInsturctions();
    }

    // Update is called once per frame
    void Update()
    {
    MovePlayer();
    }

void PrintInsturctions()
    {
        Debug.Log("Welcome to the game! Use the arrow keys to move the player around the scene.");
    }

void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }


}
