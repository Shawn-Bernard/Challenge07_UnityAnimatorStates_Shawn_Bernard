using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Spinning_Animator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public TextMeshProUGUI text;
    [SerializeField] float speed;
    [SerializeField] Camera cam;
    [SerializeField] GameObject camSpot_1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        float scrollValue = Input.GetAxis("Mouse ScrollWheel");
        if (scrollValue != 0)
        {
            //Moving my camera into the position to object
            cam.transform.position = camSpot_1.transform.position;
            speed += scrollValue;
            // Clamping the speed with a min of 0f to 2.5f
            speed = Mathf.Clamp(speed, 0f, 2.5f);
            //Setting my animator speed value to scroll value (speed)
            animator.SetFloat("Speed",speed);
            
            // Showing my speed from text
            text.text = $"Speed {animator.GetFloat("Speed")}";
        }
    }
}
