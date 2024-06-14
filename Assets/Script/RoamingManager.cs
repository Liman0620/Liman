using UnityEngine;
using UnityEngine.UI;

public class RoamingManager : MonoBehaviour
{
    public Image avatarImage;
    public Text playerNameText;

    public Sprite[] avatarSprites; // �洢ͷ����е�ͷ��ͼƬ

    void Start()
    {
        // ��PlayerPrefs�л�ȡ���������ѧ��
        string playerName = PlayerPrefs.GetString("PlayerName");
        string playerID = PlayerPrefs.GetString("PlayerID");

        // ��������
        playerNameText.text = playerName;

        // ����ͷ�񣬴�ͷ��������ѡ��
        int randomIndex = Random.Range(0, avatarSprites.Length);
        avatarImage.sprite = avatarSprites[randomIndex];
    }
}

