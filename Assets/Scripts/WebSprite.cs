using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebSprite : MonoBehaviour
{
    public string URL;
    public Text text;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        text = FindObjectOfType<Text>();
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(URL))
        {
            float startTime = Time.time;
            yield return uwr.SendWebRequest();
            float EndTime = Time.time;
            EndTime -= startTime;
                        text.text = EndTime.ToString();

            if (uwr.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                var texture = DownloadHandlerTexture.GetContent(uwr);
                sr.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height),
                    new Vector2(0.5f, 0.5f));
            }
        }
    }

// Update is called once per frame
    void Update()
    {
        
    }
}
