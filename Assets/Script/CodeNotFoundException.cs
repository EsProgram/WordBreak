using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// コードが発見できなかった際に投げられる例外
/// </summary>
public class CodeNotFoundException : Exception
{
    public CodeNotFoundException(string message)
        : base(message)
    {
    }
}