using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public Button mute; // دکمه میوت
    public AudioSource backgroundMusic; // موزیک بازی

    private bool isMuted = false; // حالت میوت

    void Start()
    {
        // افزودن لیسنر به دکمه میوت
        mute.onClick.AddListener(ToggleMute);
    }

    // تابع برای میوت یا آن‌میوت کردن
    void ToggleMute()
    {
        if (isMuted)
        {
            // اگر موزیک قطع شده، دوباره پخش شود
            backgroundMusic.mute = false;
            isMuted = false;
            // mute.GetComponentInChildren<Text>().text = "Mute"; // تغییر متن دکمه به "Mute"
        }
        else
        {
            // اگر موزیک در حال پخش است، قطع شود
            backgroundMusic.mute = true;
            isMuted = true;
            // mute.GetComponentInChildren<Text>().text = "Unmute"; // تغییر متن دکمه به "Unmute"
        }
    }
}
