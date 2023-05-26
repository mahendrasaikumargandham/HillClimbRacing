using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevelScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        SceneManager.LoadScene("FinishMenu");
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
