using UnityEngine;
using UnityEngine.SceneManagement;

public class backMapSelectScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene("map_select",LoadSceneMode.Single);
        }
    }
}
