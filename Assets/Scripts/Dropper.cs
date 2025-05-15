using Unity.VisualScripting;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    [SerializeField]float timeToFall = 3f;
    MeshRenderer meshR;
    Rigidbody rb;
    void Start()
    {
        meshR= GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        if (meshR != null)
        {
            meshR.enabled = false;
        }
        if (rb != null)
        {
            rb.useGravity = false;
        }
    }

    void Update()
    {   
        if(Time.time >= timeToFall )
        {
            if(meshR != null)
            {
                meshR.enabled = true;
            }
            if (rb != null)
            {
                rb.useGravity = true;
            }
        }
        
    }

   
}
