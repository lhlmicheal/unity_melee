using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationAutoTest : MonoBehaviour
{
    public Transform targetObj;
    // Start is called before the first frame update
    void Start()
    {
        if (targetObj != null)
        {
            //test.test
            GetComponent<UnityEngine.AI.NavMeshAgent>().destination = targetObj.position;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
