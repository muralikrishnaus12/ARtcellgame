using UnityEngine;

public class MoveTowardsCancerCell : MonoBehaviour
{
    public string cancerCellTag = "CancerCell";
    public float movementSpeed = 5f;
    private Transform target;
    public float desiredDistance = 0.02f; 

    void Start()
    {
        FindNearestCancerCell();
    }

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime);
        }
        else
        {
            FindNearestCancerCell();
        }
    }

    void FindNearestCancerCell()
    {
        GameObject[] cancerCells = GameObject.FindGameObjectsWithTag(cancerCellTag);
        float closestDistance = Mathf.Infinity;
        GameObject nearestCancerCell = null;

        foreach (GameObject cancerCell in cancerCells)
        {
            if (cancerCell != gameObject) 
            {
                float distance = Vector3.Distance(transform.position, cancerCell.transform.position);
                
                if (distance < desiredDistance)
                {
                    closestDistance = distance;
                    nearestCancerCell = cancerCell;
                    break; 
                }
            }
        }

        if (nearestCancerCell != null)
        {
            target = nearestCancerCell.transform;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(cancerCellTag))
        {
            Destroy(other.gameObject);
        }
    }
}