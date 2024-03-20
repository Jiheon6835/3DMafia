using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrasition : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject BackCamera;

    bool main_cam = true;
    bool back_cam = false;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.SetActive(main_cam);
        BackCamera.SetActive(back_cam);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            main_cam = !main_cam;
            back_cam = !back_cam;
            MainCamera.SetActive(main_cam);
            BackCamera.SetActive(back_cam);
        }
    }
}
