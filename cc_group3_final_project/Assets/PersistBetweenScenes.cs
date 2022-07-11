using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistBetweenScenes : MonoBehaviour
{
    public static int NumberTimesBookOpened = 0;
    public Fungus.Flowchart chartToSet;
    public int getTimesOpened ()
    {
        return NumberTimesBookOpened;
    }

    public void increaseTimesOpened ()
    {
        NumberTimesBookOpened = NumberTimesBookOpened + 1;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if (chartToSet != null)
        {
            chartToSet.SetIntegerVariable ("timesOpened", NumberTimesBookOpened);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
