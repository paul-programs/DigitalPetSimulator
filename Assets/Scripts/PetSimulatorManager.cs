using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetSimulatorManager : MonoBehaviour
{
    private float currTimer = 0.0f;
    public float behaviorChangeTime = 30.0f;

    private int status = 0;//0 - fine, 1 - hungry, 2 - sad, 3 - dirty, 4 - bad

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currTimer += Time.deltaTime;

        if(currTimer >= behaviorChangeTime)
        {
            ChangeStatus();
            currTimer = 0.0f;
        }
    }

    private void ChangeStatus()
    {
        if(status > 0)
        {
            status = 0;
        } 
        else
        {
            status = Random.Range(1, 5);
        }
    }

    public void PlayerAction(int type)
    {
        if(type == status)
        {
            status = 0;
        }
        else
        {
            status = 4;
        }

        currTimer = 0.0f;
    }

    public int GetPetStatus()
    {
        return status;
    }
}
