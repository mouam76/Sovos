using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace SovosAssessmentMVC.Models
{
    public class CaseViewModel
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TypeEnum TypeEnum
        {
            get
            {
                if (Type == 1)
                {
                    return TypeEnum.DataImport;
                }
                else if (Type == 2)
                {
                    return TypeEnum.StateReport;
                }
                else
                {
                    return TypeEnum.AuditReport;
                }
            ;
            }
        }
        public int Status { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public StatusEnum StatusEnum
        {
            get
            {
                if (Status == 1)
                {
                    return StatusEnum.Processing;
                }
                else if (Status == 2)
                {
                    return StatusEnum.Complete;
                }
                else
                {
                    return StatusEnum.Failed;
                }
            ;
            }
        }
        public string UserName { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public enum TypeEnum
    {
        DataImport = 1, StateReport = 2, AuditReport = 3
    }

    public enum StatusEnum
    {
        Processing = 1, Complete = 2, Failed = 3
    }
}