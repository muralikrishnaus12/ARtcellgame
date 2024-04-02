using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BulletSpawnner : MonoBehaviour
{
    public GameObject ar_camera;
    //public GameObject smoke;
    //public Text score;
    private int scoreval = 0;

    public void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.transform.CompareTag("cell1"))
            {
                print("Destroy");

                hit.transform.GetComponent<Renderer>().material.color = Color.blue;
                hit.transform.gameObject.tag = "tcell";
            }
            if (hit.transform.CompareTag("cell2"))
            {
                print("Destroy");

                hit.transform.GetComponent<Renderer>().material.color = Color.green;
                hit.transform.gameObject.tag = "normalcell";
            }
            if (hit.transform.CompareTag("cell3"))
            {
                print("Destroy");

                hit.transform.GetComponent<Renderer>().material.color = Color.grey;
                hit.transform.tag = "CancerCell";
            }
        }
    }
}
