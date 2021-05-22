using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{

    public GameObject trash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject hp = GameObject.Find("HPControl");
        if (other.gameObject.tag == "Player")
        {
            hp.GetComponent<HpController>().HpControl();
            Destroy(gameObject);
        }
    }
}
