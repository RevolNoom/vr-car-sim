using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWall : MonoBehaviour
{
    private bool isChecked;
    void Start()
    {
        isChecked = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!isChecked && other.gameObject.CompareTag("Wall"))
        {
            isChecked = true;
            Debug.Log("tru 5 nhe =))");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isChecked = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
