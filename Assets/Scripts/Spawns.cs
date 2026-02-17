using UnityEngine;

public class Spawns : MonoBehaviour
{
    public GameObject laser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("spawnlaser", 2);
        Invoke("spawnlaser", 4);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void spawnlaser()
    {
        Vector3 spawn = new Vector3(Random.Range(-7.7f, 6.7f), 0, -12);
        Instantiate(laser, spawn, laser.transform.rotation);
        Invoke("spawnlaser", Random.Range(0.5f, 4.0f));
    }


}
