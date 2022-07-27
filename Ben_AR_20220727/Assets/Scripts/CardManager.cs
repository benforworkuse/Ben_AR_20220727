

using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace Ben
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID 圖片")] private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("機器人ani")] private Animator anirobot;
        [SerializeField, Header("攻擊按鈕")] private Button btnAttack;
        [SerializeField, Header("虛擬跳躍按鈕")] private VirtualButtonBehaviour vbbjump;

        private string shootaction = "Shoot";
        private AudioSource audBGM;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);

            btnAttack.onClick.AddListener(Attack);
            vbbjump.RegisterOnButtonReleased(OnJumpPressed);
            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }

        private void OnJumpPressed(VirtualButtonBehaviour obj)
        {
            print("<color=#3366dd>跳躍!!!</color>");
           
        }

        private void CardFound()
        {
            print("<color=yellow>找到卡片</color>");
            anirobot.SetTrigger(shootaction);
            audBGM.Play();
        }
        private void CardLost()
        {
            print("<color=red>卡片辨識失敗</color>");
            audBGM.Stop();
        }
        private void Attack()
        {
            print("<color=#987655>攻擊!!!</color>");
        }
    }
}

