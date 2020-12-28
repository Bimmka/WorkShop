using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerAnimation 
{
    void SetIsHaveBomb(bool isHave);
    void HitBomb();
    void ChangeAnimatorSpeed(float speedValue);

}
