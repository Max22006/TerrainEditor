using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
         PlayerController player = other.GetComponentInParent<PlayerController>();

        if (player != null)
        {
            player.Die();
        }
    }
}
