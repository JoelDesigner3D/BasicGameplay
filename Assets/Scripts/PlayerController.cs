using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10f;

    private float movementX;
    //private float movementY;

    public Rigidbody body;

    public GameObject projectilePrefab;

    public GameObject steak;
    public GameObject cookie;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        /*******************************
         * Old Input System
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime) ;
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // launch a projectile from the player
            print("launch projectile");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        *******************************/
    }

    public void OnMove(InputValue movementValue)
    {

        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        //movementY = movementVector.y;

        Debug.Log("movementX : " + movementVector.x);

        body.velocity = new Vector3(movementX * speed, body.velocity.y, body.velocity.z);

        // transform.Translate(Vector3.right * movementVector.x * speed * Time.deltaTime);  

    }

    public void OnFire() // Space key
    {
        // launch a projectile from the player
        Debug.Log("launch projectile");

        // Create a new projectile and add it to the scene
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }

    public void OnFireSteak() // ctrl key
    {
        // launch a projectile from the player
        Debug.Log("launch steak");

        // Create a new projectile and add it to the scene
        Instantiate(steak, transform.position, steak.transform.rotation);
    }

    public void OnFireCookie() // shift key
    {
        // launch a projectile from the player
        Debug.Log("launch cookie");

        // Create a new projectile and add it to the scene
        Instantiate(cookie, transform.position, cookie.transform.rotation);
    }
}
