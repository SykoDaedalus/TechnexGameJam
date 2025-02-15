using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;


public class options : MonoBehaviour
{
    public AudioMixer am;
   Resolution[] res;
    public TMP_Dropdown dd;
    void Start(){
        res  = Screen.resolutions;
        dd.ClearOptions();
        List<string> options = new List<string>();
        int cur = 0;
        for(int i=0;i<res.Length;i++){
            string option = res[i].width + " x "+res[i].height;
            options.Add(option);
            if(res[i].width == Screen.currentResolution.width &&res[i].height == Screen.currentResolution.height){
                cur = i;
            }
        }
        dd.AddOptions(options);
        dd.value = cur;
        dd.RefreshShownValue();
         
    }
   public void SetVolume(float val){
    am.SetFloat("volume",val);
   }
   public void setFullScreen(bool fs){
    Screen.fullScreen =fs;
   }
}
