
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 30;

    private readonly int limitX = 15;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        transform.Translate(Time.deltaTime * speed * inputX * Vector3.right);

        if(transform.position.x >= limitX)
        {
           transform.position = Vector3.right * limitX;
        }
        else if(transform.position.x <= -limitX)
        {
            transform.position = Vector3.left * limitX;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}