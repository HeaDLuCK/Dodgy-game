using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public static Color hitColor = Color.yellow;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = hitColor;
            gameObject.tag = "Hit";
        }
        
    }
}
