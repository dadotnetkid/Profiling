using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Models.Repository
{
    public partial class UnitOfWork : IDisposable
    {
        public ModelDb context;

        public UnitOfWork()
        {
            context = ModelDb.Create(DataSource.ConnectionString);//(/*DataSource.ConnectionString ?? context.Database.Connection.ConnectionString*/);
        }
        public UnitOfWork(UnitOfWorkSettings settings)
        {

        }


        private GenericRepository<Deliveries> _DeliveriesRepo;
        public GenericRepository<Deliveries> DeliveriesRepo
        {
            get
            {
                if (this._DeliveriesRepo == null)
                    this._DeliveriesRepo = new GenericRepository<Deliveries>(context);
                return _DeliveriesRepo;
            }
            set { _DeliveriesRepo = value; }
        }

        private GenericRepository<MES> _MESRepo;
        public GenericRepository<MES> MESRepo
        {
            get
            {
                if (this._MESRepo == null)
                    this._MESRepo = new GenericRepository<MES>(context);
                return _MESRepo;
            }
            set { _MESRepo = value; }
        }

        private GenericRepository<TechSpecRequests> _TechSpecRequestsRepo;
        public GenericRepository<TechSpecRequests> TechSpecRequestsRepo
        {
            get
            {
                if (this._TechSpecRequestsRepo == null)
                    this._TechSpecRequestsRepo = new GenericRepository<TechSpecRequests>(context);
                return _TechSpecRequestsRepo;
            }
            set { _TechSpecRequestsRepo = value; }
        }

        private GenericRepository<Documents> _DocumentsRepo;
        public GenericRepository<Documents> DocumentsRepo
        {
            get
            {
                if (this._DocumentsRepo == null)
                    this._DocumentsRepo = new GenericRepository<Documents>(context);
                return _DocumentsRepo;
            }
            set { _DocumentsRepo = value; }
        }

     
        private GenericRepository<TechSpecs> _TechSpecsRepo;
        public GenericRepository<TechSpecs> TechSpecsRepo
        {
            get
            {
                if (this._TechSpecsRepo == null)
                    this._TechSpecsRepo = new GenericRepository<TechSpecs>(context);
                return _TechSpecsRepo;
            }
            set { _TechSpecsRepo = value; }
        }

        private GenericRepository<EvaluationSheets> _EvaluationSheetsRepo;
        public GenericRepository<EvaluationSheets> EvaluationSheetsRepo
        {
            get
            {
                if (this._EvaluationSheetsRepo == null)
                    this._EvaluationSheetsRepo = new GenericRepository<EvaluationSheets>(context);
                return _EvaluationSheetsRepo;
            }
            set { _EvaluationSheetsRepo = value; }
        }

        private GenericRepository<TechnicalEvaluationSheet> _TechnicalEvaluationSheetRepo;
        public GenericRepository<TechnicalEvaluationSheet> TechnicalEvaluationSheetRepo
        {
            get
            {
                if (this._TechnicalEvaluationSheetRepo == null)
                    this._TechnicalEvaluationSheetRepo = new GenericRepository<TechnicalEvaluationSheet>(context);
                return _TechnicalEvaluationSheetRepo;
            }
            set { _TechnicalEvaluationSheetRepo = value; }
        }

        private GenericRepository<Dropdowns> _DropdownsRepo;
        public GenericRepository<Dropdowns> DropdownsRepo
        {
            get
            {
                if (this._DropdownsRepo == null)
                    this._DropdownsRepo = new GenericRepository<Dropdowns>(context);
                return _DropdownsRepo;
            }
            set { _DropdownsRepo = value; }
        }
        private GenericRepository<DocActions> _DocActionsRepo;
        public GenericRepository<DocActions> DocActionsRepo
        {
            get
            {
                if (this._DocActionsRepo == null)
                    this._DocActionsRepo = new GenericRepository<DocActions>(context);
                return _DocActionsRepo;
            }
            set { _DocActionsRepo = value; }
        }
      

        private GenericRepository<Statuses> _StatusesRepo;
        public GenericRepository<Statuses> StatusesRepo
        {
            get
            {
                if (this._StatusesRepo == null)
                    this._StatusesRepo = new GenericRepository<Statuses>(context);
                return _StatusesRepo;
            }
            set { _StatusesRepo = value; }
        }

        
        private GenericRepository<WorkOrders> _WorkOrdersRepo;
        public GenericRepository<WorkOrders> WorkOrdersRepo
        {
            get
            {
                if (this._WorkOrdersRepo == null)
                    this._WorkOrdersRepo = new GenericRepository<WorkOrders>(context);
                return _WorkOrdersRepo;
            }
            set { _WorkOrdersRepo = value; }
        }

        private GenericRepository<PPEs> _PPEsRepo;
        public GenericRepository<PPEs> PPEsRepo
        {
            get
            {
                if (this._PPEsRepo == null)
                    this._PPEsRepo = new GenericRepository<PPEs>(context);
                return _PPEsRepo;
            }
            set { _PPEsRepo = value; }
        }
        private GenericRepository<EquipmentProfiles> _EquipmentProfilesRepo;
        public GenericRepository<EquipmentProfiles> EquipmentProfilesRepo
        {
            get
            {
                if (this._EquipmentProfilesRepo == null)
                    this._EquipmentProfilesRepo = new GenericRepository<EquipmentProfiles>(context);
                return _EquipmentProfilesRepo;
            }
            set { _EquipmentProfilesRepo = value; }
        }

    
     

        private GenericRepository<Offices> _OfficesRepo;
        public GenericRepository<Offices> OfficesRepo
        {
            get
            {
                if (this._OfficesRepo == null)
                    this._OfficesRepo = new GenericRepository<Offices>(context);
                return _OfficesRepo;
            }
            set { _OfficesRepo = value; }
        }
  
        private GenericRepository<EquipmentTypes> _EquipmentTypesRepo;
        public GenericRepository<EquipmentTypes> EquipmentTypesRepo
        {
            get
            {
                if (this._EquipmentTypesRepo == null)
                    this._EquipmentTypesRepo = new GenericRepository<EquipmentTypes>(context);
                return _EquipmentTypesRepo;
            }
            set { _EquipmentTypesRepo = value; }
        }
        private GenericRepository<UnitTypes> _UnitTypesRepo;
        public GenericRepository<UnitTypes> UnitTypesRepo
        {
            get
            {
                if (this._UnitTypesRepo == null)
                    this._UnitTypesRepo = new GenericRepository<UnitTypes>(context);
                return _UnitTypesRepo;
            }
            set { _UnitTypesRepo = value; }
        }

        private GenericRepository<PurchaseOrders> _PurchaseOrdersRepo;
        public GenericRepository<PurchaseOrders> PurchaseOrdersRepo
        {
            get
            {
                if (this._PurchaseOrdersRepo == null)
                    this._PurchaseOrdersRepo = new GenericRepository<PurchaseOrders>(context);
                return _PurchaseOrdersRepo;
            }
            set { _PurchaseOrdersRepo = value; }
        }



        private GenericRepository<Suppliers> _SuppliersRepo;
        public GenericRepository<Suppliers> SuppliersRepo
        {
            get
            {
                if (this._SuppliersRepo == null)
                    this._SuppliersRepo = new GenericRepository<Suppliers>(context);
                return _SuppliersRepo;
            }
            set { _SuppliersRepo = value; }
        }
        public bool StartConnection()
        {
            try
            {
                this.context.Database.Connection.Open();
                var res = this.UsersRepo.Fetch().Select(x => x.Id).Count();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }




        private GenericRepository<Employees> _EmployeesRepo;
        public GenericRepository<Employees> EmployeesRepo
        {
            get
            {
                if (this._EmployeesRepo == null)
                    this._EmployeesRepo = new GenericRepository<Employees>(context);
                return _EmployeesRepo;
            }
            set { _EmployeesRepo = value; }
        }

        private GenericRepository<MachineTypes> _MachineTypesRepo;
        public GenericRepository<MachineTypes> MachineTypesRepo
        {
            get
            {
                if (this._MachineTypesRepo == null)
                    this._MachineTypesRepo = new GenericRepository<MachineTypes>(context);
                return _MachineTypesRepo;
            }
            set { _MachineTypesRepo = value; }
        }
        private GenericRepository<Machines> _MachinesRepo;
        public GenericRepository<Machines> MachinesRepo
        {
            get
            {
                if (this._MachinesRepo == null)
                    this._MachinesRepo = new GenericRepository<Machines>(context);
                return _MachinesRepo;
            }
            set { _MachinesRepo = value; }
        }

        private GenericRepository<Logs> _LogsRepo;
        public GenericRepository<Logs> LogsRepo
        {
            get
            {
                if (this._LogsRepo == null)
                    this._LogsRepo = new GenericRepository<Logs>(context);
                return _LogsRepo;
            }
            set { _LogsRepo = value; }
        }

        private GenericRepository<Provinces> _ProvincesRepo;
        public GenericRepository<Provinces> ProvincesRepo
        {
            get
            {
                if (this._ProvincesRepo == null)
                    this._ProvincesRepo = new GenericRepository<Provinces>(context);
                return _ProvincesRepo;
            }
            set { _ProvincesRepo = value; }
        }

        private GenericRepository<Towns> _TownsRepo;
        public GenericRepository<Towns> TownsRepo
        {
            get
            {
                if (this._TownsRepo == null)
                    this._TownsRepo = new GenericRepository<Towns>(context);
                return _TownsRepo;
            }
            set { _TownsRepo = value; }
        }

        private GenericRepository<Actions> _ActionsRepo;
        public GenericRepository<Actions> ActionsRepo
        {
            get
            {
                if (this._ActionsRepo == null)
                    this._ActionsRepo = new GenericRepository<Actions>(context);
                return _ActionsRepo;
            }
            set { _ActionsRepo = value; }
        }

        private GenericRepository<UserRolesInActions> _UserRolesInActionsRepo;
        public GenericRepository<UserRolesInActions> UserRolesInActionsRepo
        {
            get
            {
                if (this._UserRolesInActionsRepo == null)
                    this._UserRolesInActionsRepo = new GenericRepository<UserRolesInActions>(context);
                return _UserRolesInActionsRepo;
            }
            set { _UserRolesInActionsRepo = value; }
        }




        private GenericRepository<ControllersActions> _ControllersActionsRepo;
        public GenericRepository<ControllersActions> ControllersActionsRepo
        {
            get
            {
                if (this._ControllersActionsRepo == null)
                    this._ControllersActionsRepo = new GenericRepository<ControllersActions>(context);
                return _ControllersActionsRepo;
            }
            set { _ControllersActionsRepo = value; }
        }



        private GenericRepository<Items> _ItemsRepo;
        public GenericRepository<Items> ItemsRepo
        {
            get
            {
                if (this._ItemsRepo == null)
                    this._ItemsRepo = new GenericRepository<Items>(context);
                return _ItemsRepo;
            }
            set { _ItemsRepo = value; }
        }



        private GenericRepository<Users> usersRepo;
        public GenericRepository<Users> UsersRepo
        {
            get
            {
                if (this.usersRepo == null)
                    this.usersRepo = new GenericRepository<Users>(context);
                return usersRepo;
            }
            set { usersRepo = value; }
        }

        private GenericRepository<UserRoles> userRolesRepo;
        public GenericRepository<UserRoles> UserRolesRepo
        {
            get
            {
                if (this.userRolesRepo == null)
                    this.userRolesRepo = new GenericRepository<UserRoles>(context);
                return userRolesRepo;
            }
            set { userRolesRepo = value; }
        }




        public void Save()
        {
            context.SaveChanges();

        }


        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

    public class UnitOfWorkSettings
    {
        private bool _proxyCreationEnabled;
        private bool _lazyLoading;

        public bool LazyLoading
        {
            get
            {
                if (_lazyLoading == null)
                    _lazyLoading = true;
                return _lazyLoading;
            }
            set => _lazyLoading = value;
        }

        public bool AsNoTracking { get; set; }

        public bool ProxyCreationEnabled
        {
            get
            {
                if (_proxyCreationEnabled == null)
                    _proxyCreationEnabled = true;
                return _proxyCreationEnabled;
            }
            set => _proxyCreationEnabled = value;
        }
    }
}