using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InitializeAdsScript : MonoBehaviour
{
    public void AdButtonPressed()
    {
        var options = new ShowOptions { resultCallback = HandleShowResult };
        Advertisement.Show(options);
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("ad finished");
                break;
            case ShowResult.Skipped:
                Debug.Log("ad skipped");
                break;
            case ShowResult.Failed:
                Debug.LogError("ad failed");
                break;
        }
    }
}
