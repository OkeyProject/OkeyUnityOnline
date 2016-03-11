using UnityEngine;
using System.Collections;

public static class CARD{
	public static Vector3 CARD_SIZE {get{return new Vector3(0.3f, 0.05f, 0.45f);}}

	public static Vector3[,] HAND_POS {	
		get{
			Vector3[,] positionCal = new Vector3[2, 12];
			for (int i = 0;i < 12;i++){
				positionCal[0, i] = new Vector3((-3.3f+0.6f*i), -3.68f,-0.08f);
				positionCal[1, i] = new Vector3((-3.3f+0.6f*i), -4.68f,-0.08f);
			}
			return positionCal;
		}
	}
}
