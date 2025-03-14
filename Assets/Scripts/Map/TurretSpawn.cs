using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to spawn
    public Transform spawnLocation;  // The location where the object will be spawned
    public Button spawnButton;       // The UI Button that triggers the spawn

     

    void Start()
    {
        // Make sure the button is linked in the inspector
        if (spawnButton != null)
        {
            spawnButton.onClick.AddListener(SpawnObject);
        }
    }

  

    void SpawnObject()
    {
        if (objectToSpawn != null && spawnLocation != null)
        {
            // Instantiate the object at the spawn location with the same rotation
            Instantiate(objectToSpawn, spawnLocation.position, spawnLocation.rotation);
        }
    }
      //Debug.Log("Spawn");
}
