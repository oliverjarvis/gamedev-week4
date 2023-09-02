using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;

    public Renderer rend;

    public int randomVal;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randomVal = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{name}:{++i}");
        if(this.CompareTag("Red") && i == 100)
            this.gameObject.SetActive(false);
        if (this.CompareTag("Blue") && i == randomVal)
            rend.enabled = false;
    }
}
