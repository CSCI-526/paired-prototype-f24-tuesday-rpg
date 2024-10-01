using UnityEngine;
using TMPro;

public class EndPoint : MonoBehaviour
{
    public TMP_Text winText;

    void Start()
    {
        
       winText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Collision Detected with: " + other.name);

        if (other.CompareTag("Player")){
            winText.gameObject.SetActive(true);
            Debug.Log("Player has triggered the endpoint!");
        }
}

}
