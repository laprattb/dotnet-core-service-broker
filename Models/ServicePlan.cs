using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;  

namespace NetCoreServiceBroker.Models
{
    public class ServicePlan {
        [Required]
        public string id {get;set;}
        [Required]
        public string name {get;set;}
        [Required]
        public string description {get;set;}
        public object metadata {get;set;}
        public bool free {get;set;}
        public bool bindable {get;set;}
        public object schemas {get;set;}
    }
}