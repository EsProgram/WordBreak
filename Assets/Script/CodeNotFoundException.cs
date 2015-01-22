using System;
using System.Collections;
using UnityEngine;

public class CodeNotFoundException : Exception
{
    public CodeNotFoundException(string message)
        : base(message)
    {
    }
}