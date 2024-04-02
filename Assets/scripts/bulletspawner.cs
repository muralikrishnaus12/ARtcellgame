//using UnityEngine;

//public class SpawnAndMove : MonoBehaviour
//{
//    public GameObject prefabToSpawn;
//    public float moveSpeed = 5f;
//    public GameObject smoke;


//    public void SpawnAndMovePrefab()
//    {
//        GameObject spawnedPrefab = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
//        Rigidbody prefabRigidbody = spawnedPrefab.GetComponent<Rigidbody>();

//        if (prefabRigidbody != null)
//        {
//            prefabRigidbody.velocity = transform.forward * moveSpeed;
//        }
//        else
//        {
//            Debug.LogWarning("Prefab does not have a Rigidbody component attached!");
//        }
//    }
//    private void OnCollisionEnter(Collision collision)
//    {
//        if (collision.gameObject.tag == "Obstacle") // Adjust tag as needed for your obstacle GameObjects
//        {
//            print("smoke");
//            Instantiate(smoke, collision.contacts[0].point, Quaternion.identity);
            
//        }
//    }
//}
