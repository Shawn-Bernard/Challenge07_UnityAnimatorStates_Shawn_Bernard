using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class Cube_Animator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public TextMeshProUGUI text;
    [SerializeField] Camera cam;
    [SerializeField] GameObject camSpot_2;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            //Moving my camera into the position to the object
            cam.transform.position = camSpot_2.transform.position;
            //If the animator bool "Rotate" is true update the bool to false 
            if (animator.GetBool("Rotate"))
            {
                UpdateBool(false);
                Debug.Log("Not spinning");
            }
            else //Update the bool "Rotate" to update to false
            {
                UpdateBool(true);
                Debug.Log("Spinning!!!!");
            }
            text.text = $"Roate = {animator.GetBool("Rotate")}";
        }
    }
    //I know I don't need this but it kinda makes it look cleaner (not really)
    void UpdateBool(bool Bool)
    {
        //Updating my bool to whatever I throw in
        animator.SetBool("Rotate", Bool);
    }
}
