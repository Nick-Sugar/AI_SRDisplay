using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class uniygoogle : MonoBehaviour
{
    string url = "https://drive.google.com/uc?id=1Dy-0x9Q95dGDBgVfi-8hV6Lovvk5DqVI";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GetStart()
    {
        UnityWebRequest request = UnityWebRequest.Get(url);

        yield return request.Send();

        string JSONstring = request.downloadHandler.text;
        UnityEngine.Debug.Log(JSONstring);
        var test = request.downloadHandler.data;

    }
}
