using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.Instance.UpdateScore();
        gameObject.SetActive(false);
    }
    
}
