using ExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 智能平台总控端.DTO;
using EntityFramework.Extensions;
using 智能平台总控端.Models;
using 智能平台总控端.Service;
using System.Web.Script.Serialization;

namespace 智能平台总控端
{
    public partial class Power_Frm : Form
    {
        private ManagePower managePower;
        private DataManager dataManager;
        public Power_Frm()
        {
            InitializeComponent();
            managePower = new ManagePower();
            SqlDao<User> uRepository = new SqlDao<User>();
            dataManager = new DataManager(uRepository.GetByFirstOrDefault(p => p.UserID == NowUser.UserID));
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void Power_Load(object sender, EventArgs e)
        {
            this.Floor_Data.DataSource = dataManager._fDTOList;
            this.Floor_Data.CellValueChanged+=Floor_Data_CellValueChanged;
        }

        private void Floor_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fEntity = Floor_Data.SelectedRows[0].DataBoundItem as FloorDTO;
            this.Room_Data.CellValueChanged -= Room_Data_CellValueChanged;
            this.Room_Data.DataSource = dataManager._rDTOList.Where(p => p.FloorID == fEntity.FloorID).ToList();
            this.Room_Data.CellValueChanged += Room_Data_CellValueChanged;
        }

        private void Room_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rEntity = Room_Data.SelectedRows[0].DataBoundItem as RoomDTO;
            this.Device_Data.CellValueChanged -= Device_Data_CellValueChanged;
            this.Device_Data.DataSource = dataManager._dDTOList.Where(p => p.RoomID == rEntity.RoomID).ToList();
        }

        private void Device_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dEntity = Device_Data.SelectedRows[0].DataBoundItem as DeviceDTO;
            if (_Type.SelectedIndex != -1)
            {
                int count = 0;
                List<PerformOrSensorDTO> psEntities = null;
                switch (_Type.SelectedIndex)
                {
                    case 0:
                        psEntities = dataManager._psList.Where(p => p._Type == 0 && p.DeviceID == dEntity.DeviceID).ToList();
                        break;
                    case 1:
                        psEntities = dataManager._psList.Where(p => p._Type == 1 && p.DeviceID == dEntity.DeviceID).ToList();
                        break;
                }
                this.Perform_Or_Sensor_Data.DataSource = psEntities;
                count = psEntities.Count;
            }
        }


        private void Floor_Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var fEntity = this.Floor_Data.SelectedRows[0].DataBoundItem as FloorDTO;
            if (fEntity.Floor_Check)
                managePower.AddPower(fEntity);
            else
                managePower.RemovePower(fEntity);
        }
        private void Room_Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var rEntity = this.Room_Data.SelectedRows[0].DataBoundItem as RoomDTO;
            if (rEntity.Room_Check)
                managePower.AddPower(rEntity);
            else
                managePower.RemovePower(rEntity);
        }
        private void Device_Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dEntity = this.Device_Data.SelectedRows[0].DataBoundItem as DeviceDTO;
            if (dEntity.Device_Check)
                managePower.AddPower(dEntity);
            else
                managePower.RemovePower(dEntity);
        }
        private void Perform_Or_Sensor_Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var psEntity = this.Perform_Or_Sensor_Data.SelectedRows[0].DataBoundItem as PerformOrSensorDTO;
            if (psEntity.PS_Check)
                managePower.AddPower(psEntity);
            else
                managePower.RemovePower(psEntity);
        }
    }
    class DataManager
    {
        public List<FloorDTO> _fDTOList { get;private set; }
        public List<RoomDTO> _rDTOList { get;private set; }
        public List<DeviceDTO> _dDTOList { get; private set; }
        public List<PerformOrSensorDTO> _psList { get; private set; }
        public DataManager(User user)
        {
            #region 仓库
            SqlDao<Floor> fRepository = new SqlDao<Floor>();
            SqlDao<FloorToRoom> ftrRepository=new SqlDao<FloorToRoom>();
            SqlDao<Room> rRepository = new SqlDao<Room>();
            SqlDao<RoomToDevice> rtdRepository=new SqlDao<RoomToDevice>();
            SqlDao<Device> dRepository = new SqlDao<Device>();
            SqlDao<Perform> pRepository = new SqlDao<Perform>();
            SqlDao<Sensor> sRepository = new SqlDao<Sensor>();
            SqlDao<UserToFloor> utfRepository = new SqlDao<UserToFloor>();
            SqlDao<Power> powerRepository = new SqlDao<Power>();
            SqlDao<Role> roleRepository = new SqlDao<Role>();
            SqlDao<RoleToPower> rtpRepositoy = new SqlDao<RoleToPower>();
            SqlDao<UserToRole> utrRepository = new SqlDao<UserToRole>();
            SqlDao<DeviceToPerform> dtpRepository = new SqlDao<DeviceToPerform>();
            SqlDao<DeviceToSensor> dtsRepository = new SqlDao<DeviceToSensor>();
            #endregion
            #region 加载数据
            List<Power> powerList = (from utr in utrRepository.GetByCondition(p => p.UserID == user.UserID)
                                     join r in roleRepository.GetAll()
                                         on utr.RoleID equals r.RoleID
                                     join rtp in rtpRepositoy.GetAll()
                                         on r.RoleID equals rtp.RoleID
                                     join p in powerRepository.GetAll()
                                         on rtp.PowerID equals p.PowerID
                                     select p).ToList();
            List<PowerDTO> powerDTOList = powerList.Select(p => {
                JavaScriptSerializer js = new JavaScriptSerializer();
                return js.Deserialize<PowerDTO>(p.PowerValue);
            }).ToList();
            _fDTOList = (from utf in utfRepository.GetByCondition(p => p.UserID == user.UserID)
                         join f in fRepository.GetAll()
                         on utf.FloorID equals f.FloorID
                         join p in powerDTOList
                         on f.FloorID equals p.FloorID into fp
                         from _fp in fp.DefaultIfEmpty()
                         select new FloorDTO
                         {
                             Floor_Check=_fp==null?false:true,
                             FloorID=f.FloorID,
                             FloorInfo=f.FloorInfo,
                             FloorName=f.FloorName
                         }).ToList();
            _rDTOList = (from f in _fDTOList
                         join ftr in ftrRepository.GetAll()
                         on f.FloorID equals ftr.FloorID
                         join r in rRepository.GetAll()
                         on ftr.RoomID equals r.RoomID
                         join p in powerDTOList
                         on r.RoomID equals p.RoomID into rp
                         from _rp in rp.DefaultIfEmpty()
                         select new RoomDTO {
                            Room_Check=_rp==null?false:true,
                            FloorID=f.FloorID,
                            RoomID=r.RoomID,
                            RoomInfo=r.RoomInfo,
                            RoomName=r.RoomName
                         }).ToList();
            _dDTOList = (from r in _rDTOList
                         join rtd in rtdRepository.GetAll()
                         on r.RoomID equals rtd.RoomID
                         join d in dRepository.GetAll()
                         on rtd.DeviceID equals d.DeviceID
                         join p in powerDTOList
                         on d.DeviceID equals p.DeviceID into dp
                         from _dp in dp.DefaultIfEmpty()
                         select new DeviceDTO {
                            RoomID=r.RoomID,
                            Device_Check=_dp==null?false:true,
                            DeviceID=d.DeviceID,
                            DeviceInfo=d.DeviceInfo,
                            DeviceName=d.DeviceName
                         }).ToList();
            var _performList = (from d in _dDTOList
                                join dtp in dtpRepository.GetAll()
                                on d.DeviceID equals dtp.DeviceID
                                join p in pRepository.GetAll()
                                on dtp.PerformID equals p.PerformID
                                join power in powerDTOList.Where(p => p._Type == 0)
                                on p.PerformID equals power.Type_Of_Id into pp
                                from _pp in pp.DefaultIfEmpty()
                                select new PerformOrSensorDTO {
                                    _Type=0,
                                    PS_Check=_pp==null?false:true,
                                    DeviceID=d.DeviceID,
                                    PSID=p.PerformID,
                                    PSInfo=p.PerformInfo,
                                    PSName=p.PerformName
                                }).ToList();
            var _sensorList=(from d in _dDTOList
                             join dts in dtsRepository.GetAll()
                             on d.DeviceID equals dts.DeviceID
                             join s in sRepository.GetAll()
                             on dts.SensorID equals s.SenseID
                             join power in powerDTOList.Where(p=>p._Type==1)
                             on s.SenseID equals power.Type_Of_Id into sp
                             from _sp in sp.DefaultIfEmpty()
                             select new PerformOrSensorDTO{
                                _Type=1,
                                PS_Check=_sp==null?false:true,
                                DeviceID=d.DeviceID,
                                PSID=s.SenseID,
                                PSInfo=s.SensorInfo,
                                PSName=s.SenseName
                             }).ToList();
            _psList = new List<PerformOrSensorDTO>();
            _psList.AddRange(_performList);
            _psList.AddRange(_sensorList);
            #endregion
        }
    }
    /// <summary>
    /// 处理勾选事件
    /// </summary>
    class ManagePower
    {
        private FloorDTO fDTO;

        private FloorDTO FDTO
        {
            get { return fDTO; }
            set
            {
                fDTO = value;
                RDTO = null;
            }
        }
        private RoomDTO rDTO;

        private RoomDTO RDTO
        {
            get { return rDTO; }
            set
            {
                rDTO = value;
                DDTO = null;
            }
        }
        private DeviceDTO dDTO;

        private DeviceDTO DDTO
        {
            get { return dDTO; }
            set
            {
                dDTO = value;
                PSDTO = null;
            }
        }
        private PerformOrSensorDTO psDTO;

        private PerformOrSensorDTO PSDTO
        {
            get { return psDTO; }
            set { psDTO = value; }
        }
        private int comboBoxSelectIndex;
        public List<FloorDTO> fDTOList;
        public ManagePower()
        {
            fDTOList = new List<FloorDTO>();
        }
        public List<PowerDTO> Result()
        {

            return null;
        }
        public void AddPower(object sender)
        {
            if (sender is FloorDTO)
            {
                FDTO = sender as FloorDTO;
            }
            else if (sender is RoomDTO)
            {
                RDTO = sender as RoomDTO;
            }
            else if (sender is DeviceDTO)
            {
                DDTO = sender as DeviceDTO;
            }
            else
            {
                PSDTO = sender as PerformOrSensorDTO;
            }
        }
        public void RemovePower(object sender)
        {
            if(sender is FloorDTO)
            {
                FDTO = null;
            }
            else  if(sender is RoomDTO)
            {
                RDTO = null;
            }
            else if(sender is DeviceDTO)
            {
                DDTO = null;
            }
            else
            {
                PSDTO = null;
            }
        }
        public void setComboBoxSelectIndex(int comboBoxSelectIndex)
        {
            this.comboBoxSelectIndex = comboBoxSelectIndex;
        }
    }
}
