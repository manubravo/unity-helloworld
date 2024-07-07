using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] [Range(0, 10)] private int count;
    [SerializeField] [TextArea] private string playerStory;

    [SerializeField] private Ball ballInit;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello manu");
        
        Debug.LogWarning("hello warning");
        
        Debug.LogError("hello error");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Contador: ");
        count++;

    }
}
