using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sho : MonoBehaviour
{
    public GameObject InfoObject;
    public GameObject InfoObject1;
    private bool Show = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowAndHideInfo()
    {
        if (!Show)
        {
            InfoObject1.SetActive(true);
            InfoObject1.SetActive(false);
            InfoObject.SetActive(true);
            Show = true;
        }else{
            InfoObject1.SetActive(true);
            InfoObject1.SetActive(false);
            InfoObject.SetActive(false);
            Show = false;
        }
    }
}
