using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetMessageManager : MonoBehaviour
{
    private int currPetStatus = 0;
    private PetSimulatorManager petSimulatorManager;

    public Text petText;

    // Start is called before the first frame update
    void Start()
    {
        petSimulatorManager = transform.GetComponent<PetSimulatorManager>();
        currPetStatus = petSimulatorManager.GetPetStatus();
    }

    // Update is called once per frame
    void Update()
    {
        int petSimStatus = petSimulatorManager.GetPetStatus();

        if (currPetStatus != petSimStatus)
        {
            currPetStatus = petSimStatus;
            SetPetStatus(currPetStatus);
        }
    }

    private void SetPetStatus(int status)
    {
        switch (status)
        {
            case 0:
                petText.text = "I am Pet.";
                break;
            case 1:
                petText.text = "Pet is hungry.";
                break;
            case 2:
                petText.text = "Pet is sad.";
                break;
            case 3:
                petText.text = "Pet made mess.";
                break;
            case 4:
                petText.text = "Pet angry and bad.";
                break;
            default:
                Debug.Log("Unable to find status");
                break;
        }
    }
}
