using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("test mesage from windows");
    }
    void Start()
    {
        Debug.Log("from linux");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
