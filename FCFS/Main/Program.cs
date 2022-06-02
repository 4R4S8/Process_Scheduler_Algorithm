﻿int x=0;

int at = 0;
int bt = 0;

double tt = 0;
double wt = 0;

int[] Finish_Time = new int[x];
int[] Arrival_Time = new int[x];
int[] Burst_Time = new int[x];
int[] Turn_Around = new int[x];
int[] Waiting_Time = new int[x];

System.Console.Write("Choose The Process Scheduler Arlgorithm:\n[1] FCFS\n[2] SJF\n[3] SRTF\n[4] RR\nEnter Your Choice: ");
int choose = int.Parse(Console.ReadLine());

switch (choose)
{
    case 1:
    {
        System.Console.WriteLine(@"
         ______    _____   ______    _____
        |  ____|  / ____| |  ____|  / ____|
        | |__    | |      | |__    | (___
        |  __|   | |      |  __|    \___ \
        | |      | |____  | |       ____) |
        |_|       \_____| |_|      |_____/
        ");

        /*//////////////////////////////////////////////////////////////////////////////////////////////////*/
        /* دریافت طول آرایه*/
        /*//////////////////////////////////////////////////////////////////////////////////////////////////*/
        Console.Write("Enter The Length of the Array: ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine();

        /*//////////////////////////////////////////////////////////////////////////////////////////////////*/
        /*دریافت مقادیر زمان ورود و زمان پردازش*/
        /*//////////////////////////////////////////////////////////////////////////////////////////////////*/

        for (int j = 0; j < Arrival_Time.Length; j++)
        {
            Console.WriteLine();
            Console.Write("P{0} Arrival Time: ",j+1);
            at = int.Parse(Console.ReadLine());
            Arrival_Time[j] = at;

            Console.Write("P{0} Burst Time: ",j+1);
            bt = int.Parse(Console.ReadLine());
            Burst_Time[j] = bt;

            /*به دست آوردن مقادیر زمان اتمام*/

            if (j==0)
            {
                Finish_Time[j]=Arrival_Time[j]+Burst_Time[j];
            }
            else
            {
                Finish_Time[j]=Finish_Time[j-1]+Burst_Time[j];
            }
            /*به دست آوردن زمان برگشت*/
            Turn_Around[j]=Finish_Time[j]-Arrival_Time[j];
            /*به دست آوردن زمان انتظار*/
            Waiting_Time[j]=Turn_Around[j]-Burst_Time[j];

            tt += Turn_Around[j];
            wt += Waiting_Time[j];
        }

        /*به دست آوردن میانگین زمان برگشت و زمان انتظار*/
        tt/=x;
        wt/=x;

        /*//////////////////////////////////////////////////////////////////////////////////////////////////*/
        /*نمایش مقادیر پردازش شده*/
        /*//////////////////////////////////////////////////////////////////////////////////////////////////*/

        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
        System.Console.WriteLine();
        Console.WriteLine("Process\t Arrival Time\t Burst Time\t Finish Time\t Turnaround Time\t Waiting Time");

        Console.WriteLine();

        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("P{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",i+1,Arrival_Time[i],Burst_Time[i],Finish_Time[i],Turn_Around[i],Waiting_Time[i]);
            Console.WriteLine();
        }

        Console.WriteLine("TT Avg = {0}   WT Avg = {1}",tt,wt);
        break;
    }

    case 2:
    {
        System.Console.WriteLine(@"
          _____        _   ______
         / ____|      | | |  ____|
        | (___        | | | |__
         \___ \   _   | | |  __|
         ____) | | |__| | | |
        |_____/   \____/  |_|
        ");

        break;
    }

    case 3:
    {
        System.Console.WriteLine(@"
          _____   _____    _______   ______ 
         / ____| |  __ \  |__   __| |  ____|
        | (___   | |__) |    | |    | |__   
         \___ \  |  _  /     | |    |  __|  
         ____) | | | \ \     | |    | |     
        |_____/  |_|  \_\    |_|    |_|     
                                     
        ");
        break;
    }

    case 4:
    {
        System.Console.WriteLine(@"
        _____    _____  
        |  __ \  |  __ \ 
        | |__) | | |__) |
        |  _  /  |  _  / 
        | | \ \  | | \ \ 
        |_|  \_\ |_|  \_\
        
        ");
        break;
    }
    default:
    {
        break;
    }
}

