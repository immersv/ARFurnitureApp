using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AppManager : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnObj;
    [SerializeField] private Camera arCamera;
    [SerializeField] private ARRaycastManager raycastManager;
    List<ARRaycastHit> hitResults = new List<ARRaycastHit>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);
            if (raycastManager.Raycast(ray, hitResults))
            {
                Pose pose = hitResults[0].pose;
                Instantiate(spawnObj, pose.position, pose.rotation);

            }
        }
    }
}
