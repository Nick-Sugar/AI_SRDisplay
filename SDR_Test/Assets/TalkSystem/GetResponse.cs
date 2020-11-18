using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Speech.Synthesis;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

public class GetResponse : MonoBehaviour
{
    string url = "https://script.google.com/macros/s/AKfycbyD0yruRnfUiIGUVdXPboTFCjr2uvkKGIZrwhXdpPEClJROiSAN/exec?text=日本";

    public Process p;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetStart());
        p = new Process();
        _Main();
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
        UnityEngine.Debug.Log(JSONstring);
        makeVOICE(JSONstring);

    }
    void makeVOICE(string data)
    {

    }
    void start_booyomi()
    {
        ProcessStartInfo _bou = new ProcessStartInfo();
        _bou.FileName = Application.dataPath + "/StreamingAssets/BouyomiChan_0_1_11_0_Beta20/BouyomiChan.exe";
        _bou.CreateNoWindow = false;
        _bou.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;  //最小化
        Process bou = Process.Start(_bou);
        //アイドル状態になるまで待機
        bou.WaitForInputIdle();
        UnityEngine.Debug.Log("棒読みちゃん起動完了");
    }
    void RunTerminal(string text)
    {
        p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
        UnityEngine.Debug.Log(Application.dataPath);
        p.StartInfo.Arguments = "/k " + Application.dataPath+ "/StreamingAssets/BouyomiChan_0_1_11_0_Beta20/RemoteTalk/RemoteTalk.exe /Talk "+text;
        p.Start();
    }
    void _Main()
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        synthesizer.Volume = 100;  // 0...100
        synthesizer.Rate = -2;     // -10...10

        // Synchronous
        synthesizer.Speak("Hello World");

        // Asynchronous
        synthesizer.SpeakAsync("Hello World");

    }
}
