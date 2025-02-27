using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Chest_Animator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public TextMeshProUGUI text;
    [SerializeField] Camera cam;
    [SerializeField] GameObject camSpot_3;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            cam.transform.position = camSpot_3.transform.position;
            // Resetting the trigger just in case
            animator.ResetTrigger("Chest_Trigger");
            // Activating the trigger
            animator.SetTrigger("Chest_Trigger");
            text.text = $"Chest has been triggered";
        }
    }
}
