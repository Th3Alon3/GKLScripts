using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterDeadControl : MonoBehaviour
{
    private CharacterInjureandDead character;
    public Button tryagain;
    public Image tryimg;
    public Text text;
    public Button menu;
    public Image menuimage;
    public Text menutext;
    public Text textdead;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterInjureandDead>();
        tryagain = tryagain.GetComponent<Button>();
        tryimg = tryimg.GetComponent<Image>();
        menu = menu.GetComponent<Button>();
        menuimage = menuimage.GetComponent<Image>();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(character.health < -5)
        {
            tryagain.enabled = true;
            tryimg.enabled = true;
            text.enabled = true;
            menu.enabled = true;
            menuimage.enabled = true;
            menutext.enabled = true;
            textdead.enabled = true;
            score.enabled = true;
        }
    }
}
