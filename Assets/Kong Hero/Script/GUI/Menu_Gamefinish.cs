using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu_Gamefinish : MonoBehaviour
{
    public Text scoreText;
    public Text timerText;
    public GameObject Buttons;
    public GameObject Next;
    public AudioClip soundCouting;
    [Range(0, 1)]
    public float soundCoutingVolume = 0.5f;

    public float countingSpeed = 0.5f;
    int score;
    int timer;

    private Text levelCompleteText;

    void Awake()
    {
        Buttons.SetActive(false);
        if (LevelManager.Instance.isLastLevelOfWorld)
            Next.SetActive(false);      //dont show the next button when this is the final level
    }

   
    void Start()
    {
        levelCompleteText = GameObject.Find("LevelCompleteText").GetComponent<Text>();
        levelCompleteText.text = Localisation.GetString("LevelComplete");

        score = GameManager.Instance.Point;
        timer = LevelManager.Instance.currentTimer;

        StartCoroutine(Counting(countingSpeed * Time.deltaTime));
    }

    IEnumerator Counting(float time)
    {
        yield return new WaitForSeconds(time);
        if (timer > 0)
        {
            timer--;
            score++;
            timerText.text = timer.ToString("000");
            scoreText.text = score.ToString("0000000");
            SoundManager.PlaySfx(soundCouting, soundCoutingVolume);
            StartCoroutine(Counting(countingSpeed * Time.deltaTime));
        }
        else
            Buttons.SetActive(true);
    }
}
