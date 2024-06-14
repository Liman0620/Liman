using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginGame : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject registerPanel;
    public GameObject settingPanel;
    public InputField r_userName;
    public InputField r_passWord;
    public InputField cr_passWord;
    public InputField userName;
    public InputField passWord;
    string name = "";//用于临时储存账号
    string pass = "";//临时储存密码
    string str = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    string showText = "";//展示验证码
    public Text textShow;//文本展示在ui界面
    public InputField setText;//设置文本
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        r_userName = r_userName.GetComponent<InputField>();
        r_passWord = r_passWord.GetComponent<InputField>();
        cr_passWord = cr_passWord.GetComponent<InputField>();
        userName = userName.GetComponent<InputField>();
        passWord = passWord.GetComponent<InputField>();
        textShow= textShow.GetComponent<Text>();
        setText=setText.GetComponent<InputField>();
    }
    public void ConfirmRegister()
    {
        if (string.IsNullOrEmpty(r_userName.text) || string.IsNullOrEmpty(r_passWord.text) || r_passWord.text != cr_passWord.text)
        {
            print("注册失败，请重新输入账号密码");
            r_passWord.text = "";
            r_userName.text = "";
            cr_passWord.text = "";
            return;
        }
        
        name = r_userName.text;
            pass=r_passWord.text;
            //r_userName.text = "";
            //r_passWord.text = "";
            //cr_passWord.text = "";
        registerPanel.SetActive(false);
            print("您的账号为"+name+"  您的密码为"+pass);
        
    }
    public void Login()
    {
        string name1 = r_userName.text;
        string id1 = r_passWord.text;

        Debug.Log(name1);

        PlayerPrefs.SetString("PlayerName", name1);
        PlayerPrefs.SetString("PlayerID", id1);

        if (string.IsNullOrEmpty(name)||string.IsNullOrEmpty(pass))
        {
            print("请输入账号密码");
            SelectString();
            return;
        }
         else if(name==userName.text && pass==passWord.text)
        {
            if(setText.text.ToLower()==showText )
            {
                print("登录成功");
                SelectString();
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
               // SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                print("验证码错误");
                setText.text = "";
                SelectString();
            }
        }
        else
        {
            print("账号或密码有误，登录失败");
            SelectString();
            return;
        }

    }
    public void SelectString()
    {
        showText = "";
        for(int i=0;i<4;i++)
        {
            index = Random.Range(0, str.Length);
            showText += str[index];
        }
        textShow.text = showText;
        setText.text = "";
        showText=showText.ToLower();

    }
    public void OpenLoginPanel()
    {
        
        loginPanel.SetActive(true);
        SelectString();
    }
    public void OpenReginsterPanel()
    {
        registerPanel.SetActive(true);
    }
    public void CloseRegisterPanel()
    {
        registerPanel.SetActive(false);
        SelectString();
    }
    public void OpenSettingPanel()
    {
        settingPanel.SetActive(true);
    }
    public void CloseSettingPanel()
    {
        settingPanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLoginButtonClicked()
    {

        
    }
}
