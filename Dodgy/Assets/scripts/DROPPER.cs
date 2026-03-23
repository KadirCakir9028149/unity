using UnityEngine;

public class DROPPER : MonoBehaviour
{

    [SerializeField] float dropTime = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
  
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();


        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

  
    void Update()
    {
        if (Time.time > dropTime)
        {
      myMeshRenderer.enabled = true;
        myRigidbody.useGravity = true;
        }
    }
}
