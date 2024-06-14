using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public InputField nameInputField;
    public InputField idInputField;

    public void OnLoginButtonClicked()
    {
        // 获取输入的姓名和学号
        string name = nameInputField.text;
        string id = idInputField.text;

        // 保存姓名和学号到PlayerPrefs，以便在漫游场景中使用
        PlayerPrefs.SetString("PlayerName", name);
        PlayerPrefs.SetString("PlayerID", id);

        // 加载漫游场景
        //SceneManager.LoadScene("RoamingScene");
    }
}
