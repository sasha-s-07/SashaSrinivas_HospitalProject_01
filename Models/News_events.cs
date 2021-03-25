using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SashaSrinivas_HospitalProject_01.Models
{
    public class News_events
    {
        [Key]
        public int News_events_id { get; set; }

        public string News_events_title { get; set; }

        public string News_events_content { get; set; }
        public DateTime Date_published { get; set; }

    }

    public class News_eventsDto
    {
        public int News_events_id { get; set; }

        public string News_events_title { get; set; }

        public string News_events_content { get; set; }
        public DateTime Date_published { get; set; }



    }

}