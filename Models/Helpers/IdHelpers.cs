using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Repository;

namespace Helpers
{
    public class IdHelpers
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public string GenerateBarcode(Machines machines)
        {
            //var boxNo = unitOfWork.OfficesRepo.Fetch(m => m.Id == machines.ReqOfficeId).Select(x => new { x.BoxNo }).FirstOrDefault()?.BoxNo;
            //var machineTypeNo = unitOfWork.MachineTypesRepo.Fetch(m => m.Id == machines.MachineTypeId).Select(x => new { x.MachineTypeNo }).FirstOrDefault()?.MachineTypeNo;
            //try
            //{
            //    var machine = unitOfWork.MachinesRepo.Fetch(m => m.ReqOfficeId == machines.ReqOfficeId && m.MachineTypeId == machines.MachineTypeId).OrderByDescending(x => x.Id).Select(x => new { x.Barcode })?.FirstOrDefault()?.Barcode;
            //    machine = boxNo + "-" + machineTypeNo + "-" + (machine.Replace(boxNo + " - " + machineTypeNo + " - ", "").ToInt() + 1);
            //    return machine;
            //}
            //catch (Exception)
            //{
            //    return boxNo + "-" + machineTypeNo + "-" + "1001";
            //}

            return "";
        }

    }
}
