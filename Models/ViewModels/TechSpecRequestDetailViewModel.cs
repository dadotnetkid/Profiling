using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models.ViewModels
{
    public class TechSpecRequestDetailViewModel
    {
        public List<TechSpecRequests> TechSpecRequests { get; set; }
        public List<TechSpecRequests> GenerateReport(int techSpecsId)
        {
            var techSpecs =
                new UnitOfWork().TechSpecRequestsRepo.Fetch(m => m.TechSpecsId == techSpecsId).OrderBy(x => x.Id).ToList();

            //for (var i = 1; i <= techSpecs.Count(); i++)
            //{
            //    var res = new UnitOfWork().EquipmentProfilesRepo.Get(m => m.TableName == "TechSpecs" && m.RefId == techSpecsId && m.ItemNumber == i);
            //    request.EquipmentProfiles.AddRange(res);
            //    res = new UnitOfWork().EquipmentProfilesRepo.Get(m => m.TableName == "TechSpecs" && m.RefId == techSpecsId && m.ParentItem == i);
            //    request.EquipmentProfiles.AddRange(res);
            ////}
            foreach (var i in techSpecs)
            {
                i.EquipmentProfiles.AddRange(new UnitOfWork().EquipmentProfilesRepo.Get(m =>
                    m.TableName == "TechSpecs" && m.RefId == techSpecsId && m.ItemNumber == i.ItemNumber,x=>x.OrderBy(m=>m.RowNumber)).ToList());
                i.EquipmentProfiles.AddRange(
                new UnitOfWork().EquipmentProfilesRepo.Get(m =>
                        m.TableName == "TechSpecs" && m.RefId == techSpecsId && m.ParentItem == i.ItemNumber, x => x.OrderBy(m => m.RowNumber)).ToList()
                );
            }



            return techSpecs;
        }
    }
}
