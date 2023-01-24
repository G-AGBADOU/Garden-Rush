using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerManager : MonoBehaviour
{
    public UnityEvent TriggerTriggered;

    private GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " est entré dans le plant");
        TriggerTriggered.Invoke();
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " est sortie dans le plant");
        TriggerTriggered.Invoke();
    }

}