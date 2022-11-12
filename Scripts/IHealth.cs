﻿using System;
using System.Collections;
using UnityEngine;

public interface IHealth
{
    event System.Action<float> OnHPPctChanged;
    event System.Action OnDied;
    void TakeDamage(int amount);
}
