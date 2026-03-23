using UnityEngine;

public class scorer : MonoBehaviour
{

    int hits = 0;
   private void OnCollisionEnter(Collision other) {
    hits++;
    Debug.Log("you have bumped this many times: " + hits);

   }
}
