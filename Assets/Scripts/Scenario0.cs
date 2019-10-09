using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scenario0 : MonoBehaviour
{

	public int stateScenario = 0;

	public GameObject consignes;

    public Button YesButton;
    public Button NoButton;

    public GameObject character;
    public Transform posUser;
    private Transform posOrig;

    
    // Start is called before the first frame update
    void Start()
    {
        // posOrig = character.transform;
        posOrig = posUser;
    }

    // Update is called once per frame
    void Update()
    {
        void TaskOnClickYes()
        {
            stateScenario = 0;
        }

        void TaskOnClickNo()
        {
            Application.Quit();
        }
        
        switch(stateScenario)
        {
        	case 0:
        		Debug.Log("Etat0");
        		character.gameObject.GetComponent<Rigidbody>().useGravity = false;
        		character.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        		character.transform.position = posOrig.position;
        		posUser = posOrig;
        		this.consignes.transform.Find("TryAgain").gameObject.SetActive(false);
        		stateScenario = 1;
        	break;

        	case -1:
        		Debug.Log("Etat = -1");
                this.consignes.transform.Find("TryAgain").gameObject.SetActive(true);
                YesButton.onClick.AddListener(TaskOnClickYes);
                NoButton.onClick.AddListener(TaskOnClickNo);
        	break;

        	case 1:
        		character.gameObject.GetComponent<Rigidbody>().useGravity = true;
        		character.gameObject.GetComponent<Rigidbody>().isKinematic = false;

        		if(character.transform.position.y < -10.0f){
        			stateScenario = -1;
        		}

        	break;
        }

    }
}
