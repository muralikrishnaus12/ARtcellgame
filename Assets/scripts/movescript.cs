using UnityEngine;

public class CellBehavior : MonoBehaviour
{
    private Color originalColor;
    private Renderer rend;
    public GameObject cancercell;
    void Start()
    {
        //cancercell.gameObject.tag = "Untagged";
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        rend.material.color = Color.yellow;
    }

}