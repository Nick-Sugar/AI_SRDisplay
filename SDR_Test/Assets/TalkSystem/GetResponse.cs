using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using UnityEngine;
using UnityEngine.Networking;

public class GetResponse : MonoBehaviour
{
    string url = "https://script.google.com/macros/s/AKfycbyD0yruRnfUiIGUVdXPboTFCjr2uvkKGIZrwhXdpPEClJROiSAN/exec?text=日本";

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

        yield return request.SendWebRequest();

        string JSONstring = request.downloadHandler.text;
        Debug.Log(JSONstring);
    }
}
