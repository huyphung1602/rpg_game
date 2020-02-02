using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFade : MonoBehaviour
{
    public Image fadeScreen;
    public float fadeSpeed;

    public bool shouldFadeFromBlack;
    public bool shouldFadeToBlack;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldFadeFromBlack)
        {
            fadeScreen.color = new Color(
                fadeScreen.color.r,
                fadeScreen.color.g,
                fadeScreen.color.b,
                Mathf.MoveTowards(fadeScreen.color.a, 1f, fadeSpeed * Time.deltaTime)
                );

            if (fadeScreen.color.a == 1f)
            {
                shouldFadeFromBlack = false;
            }
        }

        if (shouldFadeToBlack)
        {
            fadeScreen.color = new Color(
                fadeScreen.color.r,
                fadeScreen.color.g,
                fadeScreen.color.b,
                Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime)
                );
            if (fadeScreen.color.a == 0f)
            {
                shouldFadeToBlack = false;
            }
        }
    }
}
