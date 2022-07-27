

using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace Ben
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID �Ϥ�")] private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("�����Hani")] private Animator anirobot;
        [SerializeField, Header("�������s")] private Button btnAttack;
        [SerializeField, Header("�������D���s")] private VirtualButtonBehaviour vbbjump;

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
            print("<color=#3366dd>���D!!!</color>");
           
        }

        private void CardFound()
        {
            print("<color=yellow>���d��</color>");
            anirobot.SetTrigger(shootaction);
            audBGM.Play();
        }
        private void CardLost()
        {
            print("<color=red>�d�����ѥ���</color>");
            audBGM.Stop();
        }
        private void Attack()
        {
            print("<color=#987655>����!!!</color>");
        }
    }
}

