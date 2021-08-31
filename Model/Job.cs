using System;
using System.ComponentModel.DataAnnotations;

namespace c_greglist.Model
{
    public class Job
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Pay { get; set; }


    public Job(string title, int pay)
    {
      Title = title;
      Pay = pay;
      Id = Guid.NewGuid().ToString();
    }
  }
}