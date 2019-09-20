using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitScript : MonoBehaviour
{

    private Animator anim;
    private int nextAnim = 1;

    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            switch (nextAnim)
            {
                case 1:
                    anim.Play("Nobi");
                    nextAnim = 2;
                    break;
                case 2:
                    anim.Play("Burabura");
                    nextAnim = 3;
                    break;
                case 3:
                    anim.Play("Yahho");
                    nextAnim = 1;
                    break;
                default:
                    nextAnim = 1;
                    break;
            }
        }
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 110, 10, 100, 90), "Motion"))
        {
            switch (nextAnim)
            {
                case 1:
                    anim.Play("Nobi");
                    nextAnim = 2;
                    break;
                case 2:
                    anim.Play("Burabura");
                    nextAnim = 3;
                    break;
                case 3:
                    anim.Play("Yahho");
                    nextAnim = 1;
                    break;
                default:
                    nextAnim = 1;
                    break;
            }
        }
    }
}
