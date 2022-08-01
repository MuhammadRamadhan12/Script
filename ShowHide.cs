using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject hideObject, showObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jalankan()
    {
        hideObject.SetActive(false);
        showObject.SetActive(true);
    }

}
