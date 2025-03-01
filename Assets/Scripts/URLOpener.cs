using UnityEngine;

public class URLOpener : MonoBehaviour
{
    public string url;

    public void openURL()
    {
        Application.OpenURL(url);
    }
}
