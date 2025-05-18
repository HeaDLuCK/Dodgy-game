using Unity.VisualScripting;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject ball1;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ball.SetActive(true);
            ball1.SetActive(true);
            Destroy(gameObject);
        }
    }
}
