﻿using MiNET.Entities.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushNotifications.Model
{
    public class AlertServiceMasterDTO
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string? SDesc { get; set; }
        public string AlertType { get; set; }
        public int HasAttachment { get; set; }
        public string? AttachmentType { get; set; }
        public string? AttachmentPath { get; set; }
        public string? AttachmentFileType { get; set; }
        public string OutputFileName { get; set; }
        public string DataSourceType { get; set; }
        public string DataSourceDef { get; set; }
        public string PostSendDataSourceType { get; set; }
        public string PostSendDataSourceDef { get; set; }
        public string EmailTo { get; set; }
        public string? CCTo { get; set; }
        public string? BccTo { get; set; }
        public string? ASubject { get; set; }
        public string ABody { get; set; }
        public string? WATemplateName { get; set; }
        public string? WATemplate { get; set; }
        public string? WALanguageCode { get; set; }
        public int DBConnid { get; set; }
        public int AlertConfigId { get; set; }
        public int SchedularId { get; set; }
        public int IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DailyStart { get; set; }
        public DateTime? DailyEnd { get; set; }
    }

    public class AlertServiceList
    {
        public IEnumerable<AlertServiceMasterDTO> alertServiceList { get; set; }
    }

    public class AlertSchedularMapping
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DailyStart { get; set; }
        public DateTime? DailyEnd { get; set; }

    }

    public class AlertVariableMapping
    {
        public int? VariableId {  get; set; }
        public int? ServiceId { get; set; }
        public int? SchedularId { get; set; }
        public string? VarInstance { get; set; }
        public string? VarValue { get; set; }
        public string? VarType { get; set; }
        public int? IsActive { get; set; }
        public int? IsDeleted {  get; set; }
        public int? ActionUser {  get; set; }

    }
    public class AlertVariableList
    {
        public IEnumerable<AlertVariableMapping> list { get; set; }
    }

}
