using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        Debug.Log("First!");
        gameObject.SetActive(false);
    }
    void Start()
    {
        Debug.Log("Second!");
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
        DesotroyWhenReached();
    }

    void DesotroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
