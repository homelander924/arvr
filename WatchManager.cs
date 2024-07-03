using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchManager : MonoBehaviour
{
    public GameObject obj1, obj2;
    // Start is called before the first frame update
    void Start()
    {
        obj1.SetActive(true);
        obj2.SetActive(false);
    }
    // Update is called once per frame
    public void btnNextClick()
    {
        obj1.SetActive(false);
        obj2.SetActive(true);
    }
    public void btnPrevClick()
    {
        obj1.SetActive(true);
        obj2.SetActive(false);
    }
}