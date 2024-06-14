using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public InputField nameInputField;
    public InputField idInputField;

    public void OnLoginButtonClicked()
    {
        // ��ȡ�����������ѧ��
        string name = nameInputField.text;
        string id = idInputField.text;

        // ����������ѧ�ŵ�PlayerPrefs���Ա������γ�����ʹ��
        PlayerPrefs.SetString("PlayerName", name);
        PlayerPrefs.SetString("PlayerID", id);

        // �������γ���
        //SceneManager.LoadScene("RoamingScene");
    }
}
