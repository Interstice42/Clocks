using UnityEngine;

public class ClockGen : MonoBehaviour
{
    public GameObject objectPrefab;
    public float upwardForce = 10f;
    
    void Start()
    {
      
     
        for(int x = 0; x < 10; x++ ){
            // Instantiate the object at the current position and rotation
            GameObject newObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);

            // Apply an upward force to the object using its Transform component
            newObject.transform.Translate(Vector3.up * upwardForce * Time.deltaTime, Space.World);
        }
    }
}