using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���Ĩt��
    /// </summary>
    /// �n�D����G�b�Ĥ@���M�Φ��}���ɷ|����
    [RequireComponent(typeof(AudioSource))]
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource aud;

        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// ���񭵮�
        /// </summary>
        /// <param name="sound">�n���񪺭���</param>
        public void PlaySound(AudioClip sound)
        {
            // ���Ĩӷ�.����@������(����)
            aud.PlayOneShot(sound);
        }
    }
}
