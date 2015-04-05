using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MystroService.DataObjects
{
    public class User : EntityData
    {
        public string Username { get; set; }
        public string Language { get; set; }
        public DateTime LastMessagesRead { get; set; }
    }
}