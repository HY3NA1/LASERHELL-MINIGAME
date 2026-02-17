using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using TMPro; 
public class DEATH : MonoBehaviour
{
    public TextMeshProUGUI display;
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("highscore", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        display.text = ("Time Survived: " + count.ToString());
    }

    void highscore()
    {
        count++;
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        Debug.Log("Game Over! Highscore: " + count);
    }
}
