using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    [SerializeField] private int rotationScale = 10;
   
    void Update()
    {
        transform.Rotate(rotationScale * Time.deltaTime, 0, 0);
    }
}
