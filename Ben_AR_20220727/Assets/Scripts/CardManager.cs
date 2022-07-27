
using UnityEngine;

namespace Ben
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID �Ϥ�")] private DefaultObserverEventHandler observerKID;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
        }
        private void CardFound()
        {
            print("<color=yellow>���d��</color>");
        }
        private void CardLost()
        {
            print("<color=red>�d�����ѥ���</color>");
        }
    }
}

