using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Post
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Должность")]
        public string Name { get; set; }
    }
}
