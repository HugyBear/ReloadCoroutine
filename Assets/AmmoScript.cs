using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
   public int maxAmmo = 5;
   public float reloadTime = 5;
   public int ammoCount = 5;
   private bool reloading = false;

   IEnumerator Reload()
   {
      reloading = true;
      yield return new WaitForSeconds(reloadTime);
      ammoCount = maxAmmo;
      reloading = false;
   }

   // Update is called once per frame
   void Update()
   {
      if (ammoCount < 1 || ammoCount < 5 && Input.GetKeyDown("r"))
         if (reloading == false)
            StartCoroutine(Reload());                    
   }
}
