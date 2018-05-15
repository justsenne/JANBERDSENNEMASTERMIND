using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Startup : MonoBehaviour {
    
    public static int[] GetCode()
    {
        var Code = new int[4];
        for (int x = 0; x > 4; x++)
        {
            Code[x] = Random.Range(0, 4);
        };
        return Code;
    }

    
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}