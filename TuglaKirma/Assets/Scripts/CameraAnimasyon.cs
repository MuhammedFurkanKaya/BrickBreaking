using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimasyon : MonoBehaviour
{
    private Vector3 ilkPos;
    // Start is called before the first frame update
    void Start()
    {
        ilkPos = transform.position;
        transform.position = new Vector3(ilkPos.x, ilkPos.y - 6f, ilkPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, ilkPos, 2 * Time.deltaTime);
    }
}
