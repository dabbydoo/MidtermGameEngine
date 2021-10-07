using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class EmptyPlugin : MonoBehaviour
{
    [DllImport("EmptyPlugin")]
    private static extern int Empty();
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
       
    }
}