using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
   public float speed;
   public float endX;
   public float startX;

 private void Update() {
     transform.Translate(Vector2.left*speed*Time.deltaTime);
       //vector variable Vector2 with x coordonate = startX and BG position = new Vector2
       if( transform.position.x <= endX){
           Vector2 pos = new Vector2( startX, transform.position.y);
           transform.position = pos;
       }
   }
}
