using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("I AM AWAKE");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I AM STARTING");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I AM UPDATED");
        Debug.LogWarning("STOP OR YOU WILL BE ARRESTED");
    }
}
