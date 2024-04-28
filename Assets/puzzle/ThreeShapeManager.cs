using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ThreeShapeManager
{
    private static bool createNewShapes = false;
    private static bool warning = false;
    public static void openNewShapes()
    {
        createNewShapes = true;
    }

    public static void closeNewShapes()
    {
        createNewShapes = false;
    }

    public static bool doNewShapes()
    {
        return createNewShapes;
    }

    public static void addWarning()
    {
        warning = true;
    }

    public static void resolveWarnings()
    {
        if(warning)
        {
            warning = false;
            createNewShapes = false;
        }
    }
}
