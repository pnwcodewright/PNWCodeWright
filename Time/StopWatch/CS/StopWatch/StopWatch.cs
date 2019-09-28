//----------------------------------------------------------------------------
//
//  $Workfile: StopWatch.cs$
//
//  $Revision: X$
//
//  Project:    PNW Code Wright
//
//                            Copyright (c) 2019
//                               James A Wright
//                            All Rights Reserved
//
//  Modification History:
//  $Log:
//  $
//
//----------------------------------------------------------------------------
using System;

//----------------------------------------------------------------------------
//  The name StopWatch is used due to microcontrollers have clocks and
//  timers, so this name does not collide with other deffinitions
//----------------------------------------------------------------------------


namespace StopWatch
{
    //----------------------------------------------------------------------------
    //  Class Declarations
    //----------------------------------------------------------------------------
    //
    // Class Name: StopWatch
    // 
    // Purpose:
    //      Sets a time to wait for things.
    //
    //----------------------------------------------------------------------------
    class StopWatch
    {
        //----------------------------------------------------------------------------
        //  Public Class Consts
        //----------------------------------------------------------------------------
        public const long ONE_SECOND = 1000;

        //----------------------------------------------------------------------------
        //  Class Attributes 
        //----------------------------------------------------------------------------
        long mLastTime = 0;
        long mWaitTime = ONE_SECOND;

        //--------------------------------------------------------------------
        // Purpose:
        //     Empty Constructor
        //
        // Notes:
        //     Keeps the attributes the same as initialized
        //--------------------------------------------------------------------
        public StopWatch()
        {
        }

        //--------------------------------------------------------------------
        // Purpose:
        //     Constructor
        //
        // Notes:
        //     Initializes the Wait Time
        //--------------------------------------------------------------------
        public StopWatch(long waitTime)
        {
            mWaitTime = waitTime;
        }

        //--------------------------------------------------------------------
        // Purpose:
        //     It returns the current milliseconds from 2018
        //
        // Notes:
        //     The date time can be adjusted to the time frame needed
        //--------------------------------------------------------------------
        public static long Now()
        {
            TimeSpan now = DateTime.Now - new DateTime(2018,1,1);
          return (long)now.TotalMilliseconds;
        }

        //--------------------------------------------------------------------
        // Purpose:
        //     Resets the amount to wait 
        //
        // Notes:
        //     None
        //--------------------------------------------------------------------
        public void SetTime(long waitTime)
        {
            mWaitTime = waitTime;
        }

        //--------------------------------------------------------------------
        // Purpose:
        //     Return true if the stop watch is expired 
        //
        // Notes:
        //     None
        //--------------------------------------------------------------------
        public bool IsExpired()
        {
            if ((Now() - mLastTime) > mWaitTime)
            {
                return true;
            }
            return false;
        }

        //--------------------------------------------------------------------
        // Purpose:
        //     Sets the timer to the current time 
        //
        // Notes:
        //     None
        //--------------------------------------------------------------------
        public void Reset()
        {
            mLastTime = Now();
        }

        //--------------------------------------------------------------------
        // Purpose:
        //     Return the time left to wait
        //
        // Notes:
        //     None
        //--------------------------------------------------------------------
        public long GetTimeLeft()
        {
            return mWaitTime - (Now() - mLastTime);
        }
    }
}
