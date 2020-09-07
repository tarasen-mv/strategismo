using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour
{

	public bool building;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter () {

    	transform.GetChild(0).GetComponent<Image>().color = !building ? Color.green : Color.red;
    	

    }

    void OnMouseExit () {

    	transform.GetChild(0).GetComponent<Image>().color = Color.white;

    }
}
