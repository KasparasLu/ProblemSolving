using System.Collections.Generic;
using System;
using System.Linq;

public class Program {
  public int OptimalFreelancing(Dictionary<string, int>[] jobs) {
    // Write your code here.
      int sum=0;
      bool[] busyDays = Enumerable.Repeat(false, 7).ToArray();
      var sortedJobs = jobs.OrderByDescending(dict => dict["payment"]).ToArray();

      foreach (var job in sortedJobs)
      {
          int maxJobDeadline = Math.Min(job["deadline"], 7);
          for(int i=maxJobDeadline-1; i>=0; i--)
          {
              if(busyDays[i]==false)
              {
                  busyDays[i]=true;
                  sum+=job["payment"];
                  break;
              }
          }
      }
      
    return sum;
  }
}
