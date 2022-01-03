using System.Collections.Generic;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class JobType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Job> Jobs { get; set; }
        
    }
}
