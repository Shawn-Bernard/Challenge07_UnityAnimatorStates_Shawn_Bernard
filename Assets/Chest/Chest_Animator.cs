using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Chest_Animator : MonoBehaviour
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
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (animator.GetBool("open"))
            {
                UpdateBool(false);
                Debug.Log("Not spinning");
            }
            else
            {
                UpdateBool(true);
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
