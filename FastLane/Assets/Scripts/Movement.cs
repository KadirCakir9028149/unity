using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 100f;

    void Update()
    {
        // Vooruit/Achteruit
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Links/Rechts
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        // Bewegen
        transform.Translate(Vector3.forward * move);

        // Sturen (alleen als de auto beweegt)
        if (move != 0)
        {
            transform.Rotate(Vector3.up * turn);
        }
    }
}
