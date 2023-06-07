using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanMuzik : MonoBehaviour
{
    static bool SahnedeMuzikVar;
    // Start is called before the first frame update
    void Start()
    {
        if (!SahnedeMuzikVar)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            SahnedeMuzikVar = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
