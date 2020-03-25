using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Repository;

namespace Models.ViewModels
{
    public class AccomplishmentReportViewModel
    {
        public string UserId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }


        public string PrintedBy { get; set; }


        public string AccomplishmentPeriod =>
            this.DateFrom?.ToShortDateString() + " - " + this.DateTo?.ToShortDateString();
        private Users _users;
        public Users Users
        {
            get
            {
                if (_users == null)
                    _users = new UnitOfWork().UsersRepo.Find(m => m.Id == UserId);
                return _users;
            }
            set => _users = value;
        }
        /// <summary>
        /// TODO: Get all accomlishment report by sub activity
        /// </summary>
        /// <returns></returns>
        public List<ActionReports> GetAccomplishmentReport()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                //DateFrom = Convert.ToDateTime(DateFrom?.ToShortDateString()).AddHours(-11).AddMinutes(-59);
                DateTo = Convert.ToDateTime(DateTo).AddHours(23).AddMinutes(59);
                //filter by userId iqueryable
                var _docAction =
                    unitOfWork.DocActionsRepo.Fetch(m => m.ActionDate >= DateFrom && m.ActionDate <= DateTo).Where(x => x.CreatedBy == UserId);
                //insert it to listof ActionReport
                var actionReport = _docAction.GroupBy(x => x.SubActivityId)
                    .ToList().Select(x => new ActionReports()
                    {
                        SubActivityId = x.Key,

                    }).Where(x => x.SubActivity != null ||x.SubActivityId>0).ToList();
                //i can now safely query subactivityid
                actionReport = actionReport.Select(x => new ActionReports()
                {
                    SubActivityId = x.SubActivityId,
                    Count = _docAction.Count(c => c.SubActivityId == x.SubActivityId),
                    SubActivity = unitOfWork.DropdownsRepo.Find(m => m.Id == x.SubActivityId)

                }).ToList();
                return actionReport;
            }

        }

        public List<ActionReports> AccomplishmentReport { get; set; }



    }

    public class ActionReports
    {

        public int? SubActivityId { get; set; }
        public int Count { get; set; }
        public Dropdowns SubActivity { get; set; }
        public Dropdowns Activity => new UnitOfWork().DropdownsRepo.Find(m => m.Id == SubActivity.ParentId);
        public Dropdowns MainActivity => new UnitOfWork().DropdownsRepo.Find(m => m.Id == Activity.ParentId);
    }


}
