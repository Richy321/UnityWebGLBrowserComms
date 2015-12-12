using System.Runtime.InteropServices;
using UnityEngine;

public class JavaScriptCommunications : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void JSPluginHelloWorld();

    public void CallJSPluginHelloWorld()
    {
        JSPluginHelloWorld();
    }

    public void CallWebHelloWorld()
    {
        Application.ExternalCall("HelloWorldWebPage");
    }

    public void CallAsBrowserJS()
    {
        Application.ExternalEval("document.location='http://unity3d.com';");
    }

}
