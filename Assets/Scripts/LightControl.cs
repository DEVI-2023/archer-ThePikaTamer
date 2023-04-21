using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool active;

    void Start()
    {
        active = false;
        GetComponent<Light>().intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        toShine();
    }

    public void toShine()
    {
        if(active==true)
        {
            while (GetComponent<Light>().intensity <= 1)
            {
                GetComponent<Light>().intensity++;
            }
        }

        else
        {
            while (GetComponent<Light>().intensity >= 0)
            {
                GetComponent<Light>().intensity--;
            }
        }
    }
}
