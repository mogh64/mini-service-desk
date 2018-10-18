using ISE.Framework.Server.Core.DataAccessBase;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.Data;
using Telerik.OpenAccess.Data.Common;

namespace ISE.ServiceDesk.DataAccess
{
    public class PersonelTDataAccess : TDataAccess<VwPersonel, VwPersonelDto, VwPersonelRepository>
    {
        public PersonelTDataAccess()
            : base(new VwPersonelRepository())
        {
        }
        public List<VwPersonelDto> GetPersonel(int chartId)
        {
            if (chartId > 0)
            {
                return GetAll(it => it.ChartId == chartId).ToList();
            }
            return GetAll().ToList();
        }
        public List<VwPersonelDto> GetPersonelByIndependentId(int independentId)
        {
            if (independentId > 0)
            {
                return GetAll(it => it.IndependentId == independentId).ToList();
            }
            return GetAll().ToList();
        }
        public Common.DTO.VwPersonelDto GetPersonId(int perId)
        {
            var data = this.GetSingle(it => it.PerId == perId);
            if(data!=null)
                return data;
            else
            {
                VwPersonelDto response = new VwPersonelDto();
                response.Response.AddBusinessException("Not exist", Framework.Common.Service.Message.BusinessExceptionEnum.Validation);
                return response;
            }
        }
        public List<DeviceDto> GetDeviceList(int perId, int objectTypeId)
        {
            List<DeviceDto> deviceList = new List<DeviceDto>();
            using (EntitiesModel1 ctx = new EntitiesModel1())
            {

                using (OACommand cmd = ctx.Connection.CreateCommand())
                {
                    OracleParameter refCurPar1 = new OracleParameter();
                    refCurPar1.ParameterName = "v_per_id";
                    refCurPar1.Direction = ParameterDirection.Input;
                    refCurPar1.Value = perId;
                    refCurPar1.OracleDbType = OracleDbType.Int16;

                   


                    OracleParameter refCurPar2 = new OracleParameter();
                    refCurPar2.ParameterName = "resultset ";
                    refCurPar2.Direction = ParameterDirection.Output;
                    refCurPar2.OracleDbType = OracleDbType.RefCursor;

                    if (objectTypeId > 0)
                    {
                        OracleParameter refCurPar3 = new OracleParameter();
                        refCurPar3.ParameterName = "v_objecttype_id ";
                        refCurPar3.Direction = ParameterDirection.Input;
                        refCurPar3.Value = objectTypeId;
                        refCurPar3.OracleDbType = OracleDbType.Int16;
                        cmd.Parameters.Add(refCurPar3);
                    }

                    cmd.CommandText = "pkg_failrequest.getdataforinsfailreq";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new object[] { refCurPar1, refCurPar2 });

                    using (OADataReader reader = cmd.ExecuteReader())
                    {
                        IEnumerable<DeviceDto> categories = ctx.Translate<DeviceDto>(reader);
                        deviceList.AddRange(categories);
                        reader.NextResult();                      
                    }
                }
            }
            return deviceList;
        }
        public List<DeviceDto> GetDeviceList(int tranferId)
        {
            List<DeviceDto> deviceList = new List<DeviceDto>();
            using (EntitiesModel1 ctx = new EntitiesModel1())
            {

                using (OACommand cmd = ctx.Connection.CreateCommand())
                {
                    OracleParameter refCurPar1 = new OracleParameter();
                    refCurPar1.ParameterName = "v_transfer_id";
                    refCurPar1.Direction = ParameterDirection.Input;
                    refCurPar1.Value = tranferId;
                    refCurPar1.OracleDbType = OracleDbType.Int16;




                    OracleParameter refCurPar2 = new OracleParameter();
                    refCurPar2.ParameterName = "resultset ";
                    refCurPar2.Direction = ParameterDirection.Output;
                    refCurPar2.OracleDbType = OracleDbType.RefCursor;

                  

                    cmd.CommandText = "pkg_failrequest.getdataforinsfailreqbytransfer";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new object[] { refCurPar1, refCurPar2 });

                    using (OADataReader reader = cmd.ExecuteReader())
                    {
                        IEnumerable<DeviceDto> categories = ctx.Translate<DeviceDto>(reader);
                        deviceList.AddRange(categories);
                        reader.NextResult();
                    }
                }
            }
            return deviceList;
        }
    }
}
