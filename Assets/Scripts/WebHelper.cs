using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebTexture
{
    public string Path;
    public Texture2D texture;
    public Text TimeText;

    WebTexture(string path,Texture2D texture)
    {
        Path = path;
        this.texture = texture;
    }
}
public class WebHelper : MonoBehaviour
{
    public List<WebTexture> Textures = new List<WebTexture>();

    public static WebHelper Instance;
    private static WebHelper instance;
    
    public void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Singleton not alone");
        }
    }
    

    
    public Texture2D GetTexture(string Path)
    {
        WebTexture text = Textures.FirstOrDefault(x=>x.Path==Path);
        if (text!=null)
        {
            return text.texture;
        }
        else
        {
           
        }
    }
}
