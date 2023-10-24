using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOneCheckTrue : MonoBehaviour
{
    // Start is called before the first frame update
    private bool lIsHaveChecked;
    private bool rIsHaveChecked;
    public bool isDone;
    void Start()
    {
        isDone = false;
        rIsHaveChecked = false;
        lIsHaveChecked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CheckDone()
    {
        if(rIsHaveChecked && lIsHaveChecked)
        {
            Debug.Log("Done");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BRPoint") && !isDone)
        {
            rIsHaveChecked = true;
       
        }
        else if (other.gameObject.CompareTag("BLPoint") && !isDone)
        {
            lIsHaveChecked = true;

        }
        CheckDone();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("BRPoint") && !rIsHaveChecked)
        {
            rIsHaveChecked = false;

        }
        else if (other.gameObject.CompareTag("BLPoint") && !rIsHaveChecked)
        {
            lIsHaveChecked = false;

        }
    }
}
