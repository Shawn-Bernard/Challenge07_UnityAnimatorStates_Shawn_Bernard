using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class Animation_Test : MonoBehaviour
{
    public Animator animator;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            if (animator.GetBool("Rotate"))
            {
                animator.ResetTrigger("Spinning");
                animator.SetTrigger("Spinning");
                //UpdateBool(false);
                Debug.Log("Not spinning");
            }
            else
            {
                animator.ResetTrigger("Rotate");
                animator.SetTrigger("Static");
                //UpdateBool(true);
                Debug.Log("Spinning!!!!");
            }
            text.text = $"Roate = {animator.GetBool("Rotate")}";
        }
    }
    void UpdateBool(bool Bool)
    {
        animator.SetBool("Rotate", Bool);
    }
}
