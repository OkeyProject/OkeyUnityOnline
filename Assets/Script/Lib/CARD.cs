using UnityEngine;
using System.Collections;

public static class CARD{
	public static Vector3 HAND_SIZE {get{return new Vector3(0.3f, 0.05f, 0.45f);}}

	public static Vector3 DECK_SIZE {get{return new Vector3(0.2f, 0.05f, 0.3f);}}

	public static Vector3[] HAND_POS_0 {	
		get{
			Vector3[] positionCal = new Vector3[12];
			for (int i = 0;i < 12;i++){
				positionCal[i] = new Vector3((-3.3f+0.6f*i), -3.68f,-0.08f);
			}
			return positionCal;
		}
	}
	
	public static Vector3[] HAND_POS_1 {
		get{
			Vector3[] positionalCal = new Vector3[12];
			for (int i= 0;i< 12;i++){
				positionalCal[i] = HAND_POS_0[i] + new Vector3(0,-1,0);
			}
			return positionalCal;
		}
	}
}
