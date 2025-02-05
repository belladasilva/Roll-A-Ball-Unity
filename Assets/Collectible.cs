using UnityEngine;

public class Collectible : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.AddScore(); 
            gameObject.SetActive(false);  
        }
    }
}
