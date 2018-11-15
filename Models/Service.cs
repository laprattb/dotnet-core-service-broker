using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace NetCoreServiceBroker.Models
{
    public class Service {
        [Required]
        public string name {get;set;}
        [Required]
        public string id {get;set;}
        [Required]
        public string description {get;set;}
        public IList<string> tags {get;set;}
        public IList<string> requires {get;set;}
        [Required]
        public bool bindable {get;set;}
        public JsonToken metadata {get;set;}
        public object dashboard_client {get;set;}
        public bool plan_updateable {get;set;}
        [Required]
        public IList<ServicePlan> plans {get;set;}
    }
}