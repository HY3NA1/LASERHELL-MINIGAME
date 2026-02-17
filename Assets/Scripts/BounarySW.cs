using Unity.VisualScripting;
using UnityEngine;

public class BounarySW : MonoBehaviour
{
    public float zbound = 12.0f;
    public float xbound = 15.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zbound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > xbound)
        {
            Destroy(gameObject);
        }
    }
}
