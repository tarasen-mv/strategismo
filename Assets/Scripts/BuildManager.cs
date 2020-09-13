using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour
{

	public bool building;
    public GameObject Shop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Shop.activeSelf)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shop.SetActive(true);
        }
    }

    void OnMouseEnter () {

    	transform.GetChild(0).GetComponent<Image>().color = !building ? Color.green : Color.red;
    	

    }

    void OnMouseExit () {

    	transform.GetChild(0).GetComponent<Image>().color = Color.white;

    }
}
