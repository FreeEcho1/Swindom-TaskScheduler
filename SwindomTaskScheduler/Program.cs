namespace SwindomTaskScheduler;

class Program
{
    static int Main(string[] args)
    {
        int result = 0;

        foreach (string nowArgs in args)
        {
            switch (nowArgs)
            {
                case Common.CreateTask:
                    TaskSchedulerProcessing.CreateTask();
                    break;
                case Common.DeleteTask:
                    TaskSchedulerProcessing.DeleteTask();
                    break;
                case Common.CheckRegistered:
                    result = TaskSchedulerProcessing.CheckRegistered() ? 1 : 2;
                    break;
            }
        }

        return (result);
    }
}
