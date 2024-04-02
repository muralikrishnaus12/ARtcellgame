using UnityEngine;

public class CellBehavior : MonoBehaviour
{
    private Color originalColor;
    private Renderer rend;

    void Start()
    {

        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        rend.material.color = Color.yellow;
    }
    private void OnTriggerEnter(Collider other)
    {
        print(gameObject);
        if (gameObject.CompareTag("cell1"))
        {
            Debug.Log("Destroy");

            Renderer renderer = gameObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.blue;
            }
            else
            {
                Debug.LogWarning("Renderer component not found on the collided object.");
            }

            gameObject.tag = "tcell";
        }
        else if (gameObject.CompareTag("cell2"))
        {
            Debug.Log("Destroy");

            Renderer renderer = gameObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.green;
            }
            else
            {
                Debug.LogWarning("Renderer component not found on the collided object.");
            }

            gameObject.tag = "normalcell";
        }
        else if (gameObject.CompareTag("cell3"))
        {
            Debug.Log("Destroy");

            Renderer renderer = gameObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.grey;
            }
            else
            {
                Debug.LogWarning("Renderer component not found on the collided object.");
            }

            gameObject.tag = "CancerCell";
        }
    }
}