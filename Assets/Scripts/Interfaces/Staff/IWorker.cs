﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWorker
{
    void SetToFinishPoint();

    bool IsMoved();
}
