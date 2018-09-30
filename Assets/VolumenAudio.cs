using UnityEngine;
using UnityEngine.UI;

public class VolumenAudio : MonoBehaviour
{
    public AudioSource MusicaFondoMenu;
    [SerializeField]
    private float VolumenMusica = 1f;
    private Scrollbar volumeSlider;

    private void Awake()
    {
        MusicaFondoMenu = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        volumeSlider = GetComponent<Scrollbar>();
    }

    private void Update()
    {
        if (volumeSlider != null)
        {
            CambiarVolumen(volumeSlider.value);
            MusicaFondoMenu.volume = VolumenMusica;
        }
        else
        {
            Debug.LogWarning("No se ha encontrado un slider para volumen.");
        }

    }

    public void CambiarVolumen(float volumenFinal)
    {
        VolumenMusica = volumenFinal;
    }
}
