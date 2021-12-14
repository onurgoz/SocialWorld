using System;
using System.Collections.Generic;
using System.Text;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class JobType : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Job> Jobs { get; set; }
        
    }
}
