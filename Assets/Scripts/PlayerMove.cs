using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMove : MonoBehaviour
{

    public float side;
    public float updown;
    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        side = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * side * speed * Time.deltaTime);
        updown = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * updown * speed * Time.deltaTime);
        if (transform.position.x < -7.5f) 
        {
            transform.position = (new Vector3(-7.5f, transform.position.y, transform.position.z));      
        }
        if (transform.position.x > 6.75f)
        {
            transform.position = (new Vector3(6.75f, transform.position.y, transform.position.z));
        }
        if (transform.position.z < -6.75f)
        {
            transform.position = (new Vector3(transform.position.x, transform.position.y, -6.75f));
        }
        if (transform.position.z > 7.5f)
        {
            transform.position = (new Vector3(transform.position.x, transform.position.y, 7.5f));
        }
    }
}
