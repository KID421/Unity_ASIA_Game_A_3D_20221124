﻿using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    /// <summary>
    /// 互動系統：偵測玩家是否進入觸發區域並處理互動行為
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("對話結束後的事件")]
        private UnityEvent onDialogueFinish;

        [SerializeField, Header("啟動道具")]
        private GameObject propActive;
        [SerializeField, Header("啟動後的事對話資料")]
        private DialogueData dataDialogueActive;

        private string nameTartget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
        }

        // 兩個碰撞物件碰撞
        // 其中一個有勾選 Is Trigger
        // 觸發開始
        private void OnTriggerEnter(Collider other)
        {
            // 如果 碰撞物件名稱 包含 PlayerCapsule 就執行 {}
            if (other.name.Contains(nameTartget))
            {
                print(other.name);

                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive);
                }
            }
        }

        // 觸發離開
        private void OnTriggerExit(Collider other)
        {
            
        }

        // 觸發持續
        private void OnTriggerStay(Collider other)
        {
            
        }

        /// <summary>
        /// 隱藏物件
        /// </summary>
        public void HideObject()
        {
            gameObject.SetActive(false);
        }
    }
}