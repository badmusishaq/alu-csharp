﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList){
        if (myLList.First == null) {
            return 0;
        }

        int value = myLList.First.Value;
        myLList.RemoveFirst();
        return value;
    }
}