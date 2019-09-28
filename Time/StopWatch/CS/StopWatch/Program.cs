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
using System.Threading;

namespace StopWatch
{
    //----------------------------------------------------------------------------
    //  Class Declarations
    //----------------------------------------------------------------------------
    //
    // Class Name: Program
    // 
    // Purpose:
    //      This class tests the StopWatch Class
    //
    //----------------------------------------------------------------------------
    class Program
    {
        //--------------------------------------------------------------------
        // Purpose:
        //     Test the StopWatch
        //
        // Notes:
        //     
        //--------------------------------------------------------------------
        static void Main(string[] args)
        {
            StopWatch fiveSeconds = new StopWatch(5 * StopWatch.ONE_SECOND);
            Console.WriteLine("Waiting five seconds");
            fiveSeconds.Reset();
            while (false == fiveSeconds.IsExpired()) 
            {
                // Do Nothing
            }
            Console.WriteLine("Done");
            Console.WriteLine("Now:" + StopWatch.Now().ToString());
            Thread.Sleep(1234);
            Console.WriteLine("Now:" + fiveSeconds.GetTimeLeft().ToString());
        }
    }
}
