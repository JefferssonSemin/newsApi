using System;

namespace NewsApi.DTOs
{
    public class New 
    {
        public New()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}