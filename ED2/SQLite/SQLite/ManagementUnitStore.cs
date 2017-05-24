using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS;
using SQLiteNetExtensionsAsync.Extensions;
using Stores;
using WTSqLExtAsync.Extensions;
using ManagementUnit = DataObjects.DAOS.ManagementUnit;

namespace SQLite
{

    public interface IManagementUnitStore : IBaseStore
    {     
        Task<IEnumerable<ManagementUnitsDTO>> GetManagementUnitLookupData(int applicationId);
        Task<IEnumerable<ManagementUnitsDTO>> GetManagementUnitLookupData();

        Task<IEnumerable<PropertyDto>> GetPropertyList();
    }


    public class ManagementUnitStore : BaseStore, IManagementUnitStore
    {
      
        public ManagementUnitStore(IPlatform platform)
        {
            _platform = platform;

            _sqLiteAsyncConnection = GetConnection();
        }

        //public async Task<IEnumerable<ManagementUnitsDTO>> GetManagementUnitListAsync(int skip = 0, int take = 100, bool forceRefresh = false)
        //{
        //    var returnList0 = new List<ManagementUnitsDTO>();



        //   // r0.First().WoodlandOfficer.DisplayName

        //    var r1 = await _sqLiteAsyncConnection.GetAllWithChildrenAsync<ManagementUnit>(
        //        filter: null,
        //        orderExpr: null,
        //        limit: take,
        //        offset: skip,
        //        recursive: false);

        //    returnList0.AddRange(r1.Select(t => new ManagementUnitsDTO()
        //    {
        //        ManagementUnitId = t.ID,
        //        Name = t.Name,
        //        WoodlandOfficer = t.WoodlandOfficer.DisplayName,
        //        DeputyWoodlandOfficer = t.DeputyWoodlandOfficer.DisplayName

        //    }));

        //    return returnList0;
        //}

  



        public async Task<IEnumerable<ManagementUnitsDTO>> GetManagementUnitLookupData()
        {
            var returnList0 = new List<ManagementUnitsDTO>();

            var r1 = await _sqLiteAsyncConnection.Table<ManagementUnit>().ToListAsync();
             
            returnList0.AddRange(r1.Select(t => new ManagementUnitsDTO()
            {
                ManagementUnitId = t.ID,
                Name = t.Name,          
            }));

            return returnList0;
        }

        public async Task<IEnumerable<ManagementUnitsDTO>> GetManagementUnitLookupData(int applicationId)
        {
            var returnList0 = new List<ManagementUnitsDTO>();

            var r1 = await _sqLiteAsyncConnection.Table<ManagementUnit>().Where(m=>m.ApplicationID == applicationId).ToListAsync();

            returnList0.AddRange(r1.Select(t => new ManagementUnitsDTO()
            {
                ManagementUnitId = t.ID,
                Name = t.Name,
            }));

            return returnList0;
        }

        public async Task<IEnumerable<PropertyDto>> GetPropertyList()
        {
            var returnList0 = new List<PropertyDto>();

            var r1 = await _sqLiteAsyncConnection.GetAllWithChildrenAsync<AcquisitionUnit>(
                filter: null,
                orderExpr: null,
                limit: 1,
                offset: 0,
                recursive: 0);

            //returnList0.AddRange(r1.Select(t => new PropertyDto()
            //{
            //    ID = t.ID,
            //    Name = t.Name,                                
                
            //    LPM = t.WoodlandOfficer.DisplayName,
            //    GridReference = t.GridReference,
              
            //    ManagedBy = t.ApplicationID.ToString(),
            //    SFPS = "x"                 
            //}));


            foreach (var v in r1)
            {               
                var propertyDto = new PropertyDto();

                propertyDto.Location = v.Location;
                propertyDto.AreaHa = v.GISAreaInHectares.GetValueOrDefault();
                propertyDto.Acquired = v.DateContractCompleted.GetValueOrDefault();
                propertyDto.Tenure = v.GetIFNull().Tenure.Description;                    
                propertyDto.LeaseTermYrs = v.LeaseTerm.ToString();                
                propertyDto.ID = v.ID;
                propertyDto.Name = v.Name;
                propertyDto.GridReference = v.GridReference;


            //    propertyDto.LPM = v.ManagementUnit.GetIFNull().WoodlandOfficer.GetIFNull().DisplayName;
                
                

                returnList0.Add(propertyDto);
            }

            


            return returnList0;
        }
    }
}
