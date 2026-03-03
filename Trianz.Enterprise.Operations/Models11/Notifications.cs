using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trianz.Enterprise.Operations.Models
{
    public class Notifications
    {

        public string NotificationType { get; set; }
        public DateTime NotificationDate { get; set; }
        public int NotificationFrom { get; set; }
        public int NotificationTo { get; set; }
        public string NotificationMessage { get; set; }
        public bool IsActive { get; set; }
        public string AssetID { get; set; }
        public string ApplicationCode { get; set; }
        public string Name { get; set; }
        public string RequestName { get; set; }

        #region Talento
        public string JobDescrption { get; set; }
        public string Grade { get; set; }
        public string Role { get; set; }
        #endregion
        #region for time sheet

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? EmployeeId { get; set; }
        public Decimal? TotalHours { get; set; }
        public string EmployeeName { get; set; }
        public int? ApprovedBy { get; set; }
        public string ApproverName { get; set; }
        public long? TimesheetID { get; set; }
        public string Status { get; set; }

        #endregion
    }

    public class RootNotifications
    {
        public string objectNotificationsType { get; set; }
        public List<Notifications> objectNotificationList { get; set; }
    }
}