using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class SimplePlugin : MonoBehaviour
{
    [DllImport("SimplePlugin")]
    private static extern int RandomInt(int min, int max);
    private float time = 0f;
    public Rigidbody rb;
    public Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        time += Time.deltaTime;
    }

    private void Update()
    {
        // int x1 = RandomInt(29, 48);

        if (time > 0.5)
        {
            Instantiate(rb, new Vector3(RandomInt(29, 48), playerPos.position.y + 5, playerPos.position.z + 5), Quaternion.identity);
            time = 0;
        }

        time += Time.deltaTime;
    }
}