using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateSpeed  = 5f;
    [SerializeField] float xValue  = 0;
    [SerializeField] float yValue  = 2 ;
    [SerializeField] float zValue  = 0;
    void Start()
    {
        
    }

    void Update()
    {
        rotateObject();
    }

    private void rotateObject()
    {
       
         transform.Rotate(xValue, yValue, zValue);
    }
}
