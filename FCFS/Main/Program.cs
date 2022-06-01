Console.Write("Enter The Length of the Array: ");

int x = int.Parse(Console.ReadLine());
int at = 0;
int bt = 0;

int[] Finish_Time=new int[x];
int[] Arrival_Time=new int[x];
int[] Burst_Time=new int[x];
int[] Turn_Around=new int[x];

Console.WriteLine();

for (int j = 0; j < Arrival_Time.Length; j++)
{
    
    Console.WriteLine();
    Console.Write("P{0} Arrival Time: ",j+1);
    at = int.Parse(Console.ReadLine());
    Arrival_Time[j] = at;

    Console.Write("P{0} Burst Time: ",j+1);
    bt = int.Parse(Console.ReadLine());
    Burst_Time[j] = bt;

    if (j==0)
    {
        Finish_Time[j]=Arrival_Time[j]+Burst_Time[j];
    }
    else
    {
        Finish_Time[j]=Finish_Time[j-1]+Burst_Time[j];
    }

    Turn_Around[j]=Finish_Time[j]-Arrival_Time[j];

}

//Console.WriteLine(Finish_Time[0]);

Console.WriteLine();

Console.WriteLine("Process\t Arrival Time\t Burst Time\t Finish Time\t Turnaround Time\t Waiting Time");

Console.WriteLine();

for (int i = 0; i < x; i++)
{
    Console.WriteLine("P{0}\t{1}\t\t{2}\t\t{3}\t\t{4}",i+1,Arrival_Time[i],Burst_Time[i],Finish_Time[i],Turn_Around[i]);

    Console.WriteLine();
}