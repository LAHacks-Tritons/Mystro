using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MystroService.DataObjects
{
    public class Message : EntityData
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DT { get; set; }
        public string Msg { get; set; }
    }
}